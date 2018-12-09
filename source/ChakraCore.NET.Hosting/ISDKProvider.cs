using System;
using System.Collections.Generic;
using System.Text;

namespace ChakraCore.NET.Hosting
{
    public interface ISDKProvider
    {
        ModuleInfo GetSDK();
    }
}
