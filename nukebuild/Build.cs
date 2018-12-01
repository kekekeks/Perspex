using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Nuke.Common;
using Nuke.Common.Git;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.Utilities;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Xunit.XunitTasks;

partial class Build : NukeBuild
{
    // NOTE: those could be readonly fields
    [Parameter("configuration")]
    public string NukeArgConfiguration { get; set; }
    
    [Parameter("skip-tests")]
    public bool NukeArgSkipTests { get; set; }
    
    [Parameter("force-nuget-version")]
    public string NukeArgForceNugetVersion { get; set; }
    
    BuildParameters parameters { get; set; }
    protected override void OnBuildInitialized()
    {
        parameters = new BuildParameters(this);
        Information("Building version {0} of Avalonia ({1}) using version {2} of Nuke.", 
            parameters.Version,
            parameters.Configuration,
            typeof(NukeBuild).Assembly.GetName().Version.ToString());

        if (parameters.IsLocalBuild)
        {
            Information("Repository Name: " + parameters.RepositoryName);
            Information("Repository Branch: " + parameters.RepositoryBranch);
        }
        Information("Configuration: " + parameters.Configuration);
        Information("IsLocalBuild: " + parameters.IsLocalBuild);
        Information("IsRunningOnUnix: " + parameters.IsRunningOnUnix);
        Information("IsRunningOnWindows: " + parameters.IsRunningOnWindows);
        Information("IsRunningOnAppVeyor: " + parameters.IsRunningOnAppVeyor);
        Information("IsRunnongOnAzure:" + parameters.IsRunningOnAzure);
        Information("IsPullRequest: " + parameters.IsPullRequest);
        Information("IsMainRepo: " + parameters.IsMainRepo);
        Information("IsMasterBranch: " + parameters.IsMasterBranch);
        Information("IsReleaseBranch: " + parameters.IsReleaseBranch);
        Information("IsTagged: " + parameters.IsTagged);
        Information("IsReleasable: " + parameters.IsReleasable);
        Information("IsMyGetRelease: " + parameters.IsMyGetRelease);
        Information("IsNuGetRelease: " + parameters.IsNuGetRelease);
    }

    Target CleanImpl => _ => _.Executes(() =>
    {
        var data = parameters;
        DeleteDirectories(data.BuildDirs);
        EnsureCleanDirectories(data.BuildDirs);
        EnsureCleanDirectory(data.ArtifactsDir);
        EnsureCleanDirectory(data.NugetRoot);
        EnsureCleanDirectory(data.ZipRoot);
        EnsureCleanDirectory(data.TestResultsRoot);
    });


    Target BuildImpl => _ => _
        .Executes(() =>
        {
            var data = parameters;
            if (data.IsRunningOnWindows)
                MSBuild(data.MSBuildSolution, c => c
                    .SetConfiguration(data.Configuration)
                    .SetVerbosity(MSBuildVerbosity.Minimal)
                    .AddProperty("PackageVersion", parameters.Version)
                    .AddProperty("iOSRoslynPathHackRequired", "true")
                    .SetToolsVersion(MSBuildToolsVersion._15_0)
                    .AddTargets("Restore", "Build")
                );

            else
                DotNetBuild(parameters.MSBuildSolution, c => c
                    .AddProperty("PackageVersion", parameters.Version)
                    .SetConfiguration(parameters.Configuration)
                );
        });
    
    
    void RunCoreTest(string project, bool coreOnly = false)
    {
        if(!project.EndsWith(".csproj"))
            project = System.IO.Path.Combine(project, System.IO.Path.GetFileName(project)+".csproj");
        Information("Running tests from " + project);
        var frameworks = new List<string>(){"netcoreapp2.0"};
        foreach(var fw in frameworks)
        {
            if(!fw.StartsWith("netcoreapp") && coreOnly)
                continue;
            Information("Running for " + fw);
            DotNetTest(c =>
            {
                c = c
                    .SetProjectFile(project)
                    .SetConfiguration(parameters.Configuration)
                    .SetFramework(fw)
                    .EnableNoBuild()
                    .EnableNoRestore();
                // NOTE: I can see that we could maybe add another extension method "Switch" or "If" to make this more  convenient
                if (parameters.PublishTestResults)
                    c = c.SetLogger("trx").SetResultsDirectory(parameters.TestResultsRoot);
                return c;
            });
        }
    }

    Target RunUnitTestsImpl => _ => _
        .OnlyWhen(() => !parameters.SkipTests)
        .Executes(() =>
        {
            RunCoreTest("./tests/Avalonia.Base.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Controls.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Input.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Interactivity.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Layout.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Markup.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Markup.Xaml.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Styling.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Visuals.UnitTests", false);
            RunCoreTest("./tests/Avalonia.Skia.UnitTests", false);
            RunCoreTest("./tests/Avalonia.ReactiveUI.UnitTests", false);

        });

    Target RunRenderTestsImpl => _ => _
        .OnlyWhen(() => !parameters.SkipTests && parameters.IsRunningOnWindows)
        .Executes(() =>
        {
            RunCoreTest("./tests/Avalonia.Skia.RenderTests/Avalonia.Skia.RenderTests.csproj", true);
            RunCoreTest("./tests/Avalonia.Direct2D1.RenderTests/Avalonia.Direct2D1.RenderTests.csproj", true);
        });
    
    Target RunDesignerTestsImpl => _ => _
        .OnlyWhen(() => !parameters.SkipTests && parameters.IsRunningOnWindows)
        .Executes(() =>
        {
            RunCoreTest("./tests/Avalonia.DesignerSupport.Tests", false);
        });

    [PackageExecutable("JetBrains.dotMemoryUnit", "dotMemoryUnit.exe")] readonly Tool DotMemoryUnit;
    
    Target RunLeakTestsImpl => _ => _
        .OnlyWhen(() => !parameters.SkipTests && parameters.IsRunningOnWindows)
        .Executes(() =>
        {

            var dotMemoryUnitPath =
                ToolPathResolver.GetPackageExecutable("JetBrains.dotMemoryUnit", "dotMemoryUnit.exe");
            var xunitRunnerPath =
                ToolPathResolver.GetPackageExecutable("xunit.runner.console", "xunit.console.x86.exe");
            var args = new[]
            {
                Path.GetFullPath(xunitRunnerPath),
                "--propagate-exit-code",
                "--",
                "tests\\Avalonia.LeakTests\\bin\\Release\\net461\\Avalonia.LeakTests.dll"
            };
            var cargs = string.Join(" ", args.Select(a => '"' + a + '"'));

            var proc = Process.Start(new ProcessStartInfo(dotMemoryUnitPath, cargs)
            {
                UseShellExecute = false
            });

            if (!proc.WaitForExit(120000))
            {
                proc.Kill();
                throw new Exception("Leak tests timed out");
            }

            var leakTestsExitCode = proc.ExitCode;
            
            if (leakTestsExitCode != 0)
            {
                throw new Exception("Leak Tests failed");
            }
            
            // NOTE: rough alternative following. Zero exit code is checked automatically
            var testAssembly = "tests\\Avalonia.LeakTests\\bin\\Release\\net461\\Avalonia.LeakTests.dll";
            DotMemoryUnit(
                $"{XunitPath.DoubleQuoteIfNeeded()} --propagate-exit-code -- {testAssembly}",
                timeout: 120_000);
        });

    Target ZipFilesImpl => _ => _
        .Executes(() =>
        {
            var data = parameters;
            Zip(data.ZipCoreArtifacts, data.BinRoot);

            Zip(data.ZipNuGetArtifacts, data.NugetRoot);

            Zip(data.ZipTargetControlCatalogDesktopDir,
                GlobFiles(data.ZipSourceControlCatalogDesktopDir, "*.dll").Concat(
                    GlobFiles(data.ZipSourceControlCatalogDesktopDir, "*.config")).Concat(
                    GlobFiles(data.ZipSourceControlCatalogDesktopDir, "*.so")).Concat(
                    GlobFiles(data.ZipSourceControlCatalogDesktopDir, "*.dylib")).Concat(
                    GlobFiles(data.ZipSourceControlCatalogDesktopDir, "*.exe")));
        });

    void DotNetCorePack()
    {
        
    }

    Target CreateNugetPackagesImpl => _ => _
        .Executes(() =>
        {
            if (parameters.IsRunningOnWindows)

                MSBuild(parameters.MSBuildSolution, c => c
                    .SetConfiguration(parameters.Configuration)
                    .SetVerbosity(MSBuildVerbosity.Minimal)
                    .AddProperty("PackageVersion", parameters.Version)
                    .AddProperty("iOSRoslynPathHackRequired", "true")
                    .SetToolsVersion(MSBuildToolsVersion._15_0)
                    .AddTargets("Restore", "Pack"));
            else
                DotNetPack(parameters.MSBuildSolution, c =>
                    c.SetConfiguration(parameters.Configuration)
                        .AddProperty("PackageVersion", parameters.Version));
        });

    Target Compile => _ => _
        .DependsOn(CleanImpl)
        .DependsOn(BuildImpl);
    
    Target RunTests => _ => _
        .DependsOn(Compile)
        .DependsOn(RunUnitTestsImpl)
        .DependsOn(RunRenderTestsImpl)
        .DependsOn(RunDesignerTestsImpl)
        .DependsOn(RunLeakTestsImpl);
    
    Target Package => _ => _
        .DependsOn(RunTests)
        .DependsOn(CreateNugetPackagesImpl);
    
    Target CiAppVeyor => _ => _
        .DependsOn(Package)
        .DependsOn(ZipFilesImpl);
    
    Target CiTravis => _ => _
        .DependsOn(RunTests);
    
    Target CiAsuzeLinux => _ => _
        .DependsOn(RunTests);
    
    Target CiAsuzeOSX => _ => _
        .DependsOn(Package)
        .DependsOn(ZipFilesImpl);
    
    // NOTE: order of targets here is not about execution order. For this, use DependsOn or Before/After on target
    Target CiAsuzeWindows => _ => _
        .DependsOn(Package)
        .DependsOn(ZipFilesImpl);

    // Nice!
    public static int Main() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? Execute<Build>(x => x.Package)
            : Execute<Build>(x => x.RunTests);

}
