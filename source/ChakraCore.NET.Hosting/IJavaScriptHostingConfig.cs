using System;
using System.Collections.Generic;
using System.Text;

namespace ChakraCore.NET.Hosting
{
    public interface IJavaScriptHostingConfig
    {
        ModuleInfo LoadModule(string name);
        

        IPluginInstaller LoadPlugin(string name);
        
    }
}
