internal class AttributeTableBuilderBase : AttributeTableBuilder
{
    protected void AddTypeAttributes(Type type, params Attribute[] attribs)
    {
        base.AddCallback(type, delegate(AttributeCallbackBuilder builder)
        {
            builder.AddCustomAttributes(attribs);
        });
    }

    protected void AddMemberAttributes(Type type, string memberName, params Attribute[] attribs)
    {
        base.AddCallback(type, delegate(AttributeCallbackBuilder builder)
        {
            builder.AddCustomAttributes(memberName, attribs);
        });
    }

    protected void AddAssemblyAttributes(Assembly assembly, params Attribute[] attribs)
    {
        base.AddCustomAttributes(assembly, attribs);
    }
}

internal class Helper
{
    [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

    public static void LoadParent()
    {
        var path = Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
        var dllName = Path.GetFileNameWithoutExtension(Path.GetFileName(path).Replace(".Design", ""));
        path = Path.Combine(path, "..\\..", dllName + ".dll");
        AppDomain.CurrentDomain.AssemblyResolve += (_, args) =>
        {
            if (args.Name.Contains(dllName))
                return System.Reflection.Assembly.LoadFrom(path);
            return null;
        };

    }
}