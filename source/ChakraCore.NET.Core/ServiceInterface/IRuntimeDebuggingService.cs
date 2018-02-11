﻿using System;
using System.Collections.Generic;
using System.Text;
using ChakraCore.NET.Debug;
using ChakraCore.NET.API;
namespace ChakraCore.NET
{
    public interface IRuntimeDebuggingService:IService
    {
        void AttachAdapter(IDebugAdapter adapter);
        void DetachAdapter();
        void AddScriptSource(string name, string content);
        void ScriptReady();
        #region Chakracore Debug Features
        string SetBreakpoint(uint scriptId, uint line, uint column);
        string GetBreakpoints();
        void RemoveBreakpoint(uint breakpointId);
        void SetBreakpointOnException(JavaScriptDiagBreakOnExceptionAttributes attributes);
        void SetStepType(JavaScriptDiagStepType stepType);
        IEnumerable<string> GetScripts();
        string GetScriptSource(uint scriptId);
        string GetStackTrace();
        string GetStackProperties(uint stackFrameIndex);
        string GetProperties(uint objectHandle, uint from, uint to);
        void RequestAsyncBreak();
        JavaScriptValue GetObjectFromHandle(uint objectHandle);
        JavaScriptValue Evaluate(string expression, uint stackFrameIndex, JavaScriptParseScriptAttributes parseScriptAttributes, bool forceSetValueProp);
        #endregion

    }
}
