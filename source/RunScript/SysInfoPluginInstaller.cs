﻿using System;
using System.Collections.Generic;
using System.Text;
using ChakraCore.NET;
using ChakraCore.NET.Hosting;
namespace RunScript
{
    class SysInfoPluginInstaller : IPluginInstaller
    {
        public string Name => "SysInfo";

        public ModuleInfo GetSDK()
        {
            return new ModuleInfo { SourceCode = Properties.Resources.info };
        }

        public void Install(JSValue stub)
        {
            stub.WriteProperty<string>("CommandArguments", SysInfoPlugin.Default.CommandArguments);
            stub.WriteProperty("Is64BitProcess", SysInfoPlugin.Default.Is64BitProcess);
            stub.WriteProperty("CurrentPath", SysInfoPlugin.Default.CurrentPath);
            stub.Binding.SetFunction("CurrentThread", () => { return System.Threading.Thread.CurrentThread.ManagedThreadId; });
        }
    }

    struct SysInfoPlugin
    {
        public string CommandArguments;
        public bool Is64BitProcess;
        public string CurrentPath;
        public static SysInfoPlugin Default = new SysInfoPlugin()
        {
            CommandArguments = string.Join(" ", Environment.GetCommandLineArgs()),
            Is64BitProcess = Environment.Is64BitProcess,
            CurrentPath=Environment.CurrentDirectory
        };
    }

}
