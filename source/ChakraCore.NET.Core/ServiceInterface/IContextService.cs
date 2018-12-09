
using ChakraCore.NET.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChakraCore.NET
{
    public interface IContextService:IService
    {
        string RunScript(string script);
        JavaScriptValue ParseScript(string script);
        void RunModule(string script, LoadModuleDelegate loadModuleCallback);
        CancellationTokenSource ContextShutdownCTS { get; }
    }

    public class ModuleInfo
    {
        public string SourceCode { get; set; }

        public string Url { get; set; }
    }

    public delegate ModuleInfo LoadModuleDelegate(string name);
}
