#include "stdafx.h"

#include "VSCodeChakraDebugger2.h"

#include <msclr\marshal.h>
#include <msclr\marshal_cppstd.h>

using namespace System::Reflection;
using namespace ChakraCore::NET::DebugAdapter2::VSCode;

void VSCodeChakraDebugger2::Start(String^ runtimeName, bool breakOnNextLine, int port) {

    auto result = JsNoError;
    

    auto protocolHandler = std::make_unique<DebugProtocolHandler>((JsRuntimeHandle*)m_runtimeHandle);
    auto service = std::make_unique<DebugService>();

    m_runtimeName = runtimeName;

    result = service->RegisterHandler(msclr::interop::marshal_as<std::string>(runtimeName), *protocolHandler, breakOnNextLine);

    if (result == JsNoError)
    {
        result = service->Listen(port);
    }

    if (result == JsNoError)
    {
        m_debugProtocolHandler = new std::unique_ptr<DebugProtocolHandler>();
        *m_debugProtocolHandler = std::move(protocolHandler);
        m_debugService = new std::unique_ptr<DebugService>();
        *m_debugService = std::move(service);
    }

    if (result != JsNoError) {
        throw gcnew Exception("Unable to start debugging.");
    }
    
    m_isRunning = true;
}

void VSCodeChakraDebugger2::Stop()
{
    if (IsRunning) {
        (*m_debugService)->Close();
        String^ runtimeName = m_runtimeName;
        (*m_debugService)->UnregisterHandler(msclr::interop::marshal_as<std::string>(runtimeName));
        (*m_debugService)->Destroy();
        (*m_debugProtocolHandler)->Destroy();
        m_debugProtocolHandler->release();
        m_isRunning = false;
    }
}

void VSCodeChakraDebugger2::WaitForDebugger() {
    (*m_debugProtocolHandler)->WaitForDebugger();
}

VSCodeChakraDebugger2::~VSCodeChakraDebugger2()
{
    Stop();
    m_runtimeHandle = nullptr;
}
