// Automatically generated by Opus v0.30
namespace glRap
{
    // Define module classes here
    [Opus.Core.ModuleTargets(Platform=Opus.Core.EPlatform.Unix)]
    class glrap : C.DynamicLibrary
    {
        sealed class SourceFiles : C.ObjectFileCollection
        {
            public SourceFiles()
            {
                this.AddRelativePaths(this, "source", "unix", "entrypoint.cpp");
            }
        }

        [Opus.Core.SourceFiles]
        SourceFiles sourceFiles = new SourceFiles();
    }

    [Opus.Core.ModuleTargets(Platform = Opus.Core.EPlatform.Windows)]
    class opengl32 : C.DynamicLibrary
    {
        sealed class SourceFiles : C.ObjectFileCollection
        {
            public SourceFiles()
            {
                this.AddRelativePaths(this, "source", "win", "entrypoint.cpp");
            }
        }

        [Opus.Core.SourceFiles]
        SourceFiles sourceFiles = new SourceFiles();

        [Opus.Core.DependentModules(Toolchains = new string[] { "visualc" })]
        Opus.Core.TypeArray dependents = new Opus.Core.TypeArray(typeof(WindowsSDK.WindowsSDK));

        [C.RequiredLibraries(Toolchains = new string[] { "visualc" })]
        Opus.Core.StringArray libraries = new Opus.Core.StringArray("KERNEL32.lib");
    }
}
