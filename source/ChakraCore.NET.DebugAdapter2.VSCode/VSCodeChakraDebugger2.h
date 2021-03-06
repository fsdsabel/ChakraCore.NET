#pragma once

using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::InteropServices;

namespace ChakraCore {
	namespace NET {
		namespace DebugAdapter2 {
			namespace VSCode {

				public ref class VSCodeChakraDebugger2
				{
				private:
					std::unique_ptr<DebugProtocolHandler>* m_debugProtocolHandler;
					std::unique_ptr<DebugService>* m_debugService;
					String^ m_runtimeName;
					JsRuntimeHandle m_runtimeHandle;
					bool m_isRunning;
				public:
					VSCodeChakraDebugger2(Object^ runtimeHandle) :
						m_isRunning(false),
						m_debugProtocolHandler(nullptr),
						m_debugService(nullptr),
						m_runtimeName(nullptr)
					{
						if (runtimeHandle->GetType() == IntPtr::typeid) {
							m_runtimeHandle = safe_cast<IntPtr>(runtimeHandle).ToPointer();
						}
						else if (runtimeHandle->GetType()->IsValueType) {
							// try to handle as struct - it's a bit quirky but keeps us independent of Chakra-.NET wrapper library
							auto pointer = Marshal::AllocHGlobal(Marshal::SizeOf(runtimeHandle));
							Marshal::StructureToPtr(runtimeHandle, pointer, false);
							m_runtimeHandle = Marshal::ReadIntPtr(pointer).ToPointer();
							Marshal::FreeHGlobal(pointer);
						}
						else {
							throw gcnew ArgumentException("Given handle cannot be converted to JSRuntime handle.", "runtimeHandle");
						}
					}

					~VSCodeChakraDebugger2();


					void Start(String^ runtimeName, bool breakOnNextLine, int port);

					void Stop();

					void WaitForDebugger();

					property Boolean IsRunning {
						Boolean get() { return m_isRunning; }
					}
				};
			}
		}
	}
}