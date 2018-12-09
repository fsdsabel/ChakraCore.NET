using System;

namespace ChakraCore.NET.DebugAdapter2.VSCode.Managed
{
    public class VSCodeChakraDebugger2Managed : IDisposable
    {
        private VSCodeChakraDebugger2 _nativeDebugger;
        public VSCodeChakraDebugger2Managed(object runtimeHandle) 
        {
            _nativeDebugger = new VSCodeChakraDebugger2(runtimeHandle);
        }

        public bool IsRunning => _nativeDebugger.IsRunning;

        public void Start(string runtimeName, bool breakOnNextLine, int port)
        {
            _nativeDebugger.Start(runtimeName, breakOnNextLine, port);
        }
        
        public void Stop()
        {
            _nativeDebugger.Stop();
        }

        public void WaitForDebugger()
        {
            _nativeDebugger.WaitForDebugger();
        }

        public void Dispose()
        {
            _nativeDebugger.Dispose();
        }
    }
}
