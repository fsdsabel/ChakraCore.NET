#tool nuget:?package=vswhere
var target = Argument("target", "Default");

var platforms = new [] { PlatformTarget.x64, PlatformTarget.x86 };

Task("Dependencies")
  .Does(() =>
{
  DirectoryPath vsCpp = VSWhereLatest();
  if(vsCpp != null) {
    var sln = "./dependencies/ChakraCore-Debugger/ChakraCore.Debugger.sln";
    NuGetRestore(sln);

    foreach(var platform in platforms)     
    {
      MSBuild(sln,
        new MSBuildSettings 
        { 
          ToolPath = vsCpp.CombineWithFilePath("./MSBuild/15.0/Bin/amd64/MSBuild.exe"),
          Verbosity = Verbosity.Minimal,
          ToolVersion = MSBuildToolVersion.VS2017,
          Configuration = "Release",
          PlatformTarget = platform
        });
    }
  } else {
    throw new Exception("Could not find VS2017 C++ compilers. Please install components.");
  }
});

Task("Default")
  .IsDependentOn("Dependencies")
  .Does(() =>
{   
  DirectoryPath vsCpp = VSWhereLatest();
  if(vsCpp != null) {
    foreach(var platform in platforms)     
    {
      MSBuild("./source/ChakraCore.NET.sln",
      new MSBuildSettings 
          { 
            ToolPath = vsCpp.CombineWithFilePath("./MSBuild/15.0/Bin/amd64/MSBuild.exe"),
            Verbosity = Verbosity.Minimal,
            ToolVersion = MSBuildToolVersion.VS2017,
            Configuration = "Release",
            PlatformTarget = platform
          });
      
    }
  } else {
    throw new Exception("Could not find VS2017 compilers. Please install components.");
  }
});

RunTarget(target);