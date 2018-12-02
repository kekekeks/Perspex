using Nuke.Common.Tooling;

public static class ToolSettingsExtensions
{
    public static T When<T>(this T settings, bool condition, Configure<T> configurator)
    {
        return condition ? configurator(settings) : settings;
    }
}