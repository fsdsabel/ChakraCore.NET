﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChakraCore.NET.UnitTest.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ChakraCore.NET.UnitTest.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var array = new Int8Array(buffer);
        ///array.fill(0x0f);.
        /// </summary>
        internal static string ArrayBufferReadWrite {
            get {
                return ResourceManager.GetString("ArrayBufferReadWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var array = new Int8Array(buffer1);
        ///array.fill(0x0f);
        ///var buffer2 = buffer1;.
        /// </summary>
        internal static string JSArrayBufferSetGet {
            get {
                return ResourceManager.GetString("JSArrayBufferSetGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function add(s) {
        ///    return s + s
        ///}
        ///function addcallback(s, callback) {
        ///    return s + callback(s)
        ///}.
        /// </summary>
        internal static string JSCall {
            get {
                return ResourceManager.GetString("JSCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to for (var i = 0; i &lt; dv1.byteLength; i++) {
        ///    dv1.setInt8(i, dv1.getInt8(i) + 1)
        ///}.
        /// </summary>
        internal static string JSDataViewReadWrite {
            get {
                return ResourceManager.GetString("JSDataViewReadWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var callProxyResult = myStub.echo(&apos;hi&apos;);.
        /// </summary>
        internal static string JSProxy {
            get {
                return ResourceManager.GetString("JSProxy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to for (var i = 0; i &lt; array1.length; i++) {
        ///    array1[i] = array1[i] + 1
        ///};.
        /// </summary>
        internal static string JSTypedArrayReadWrite {
            get {
                return ResourceManager.GetString("JSTypedArrayReadWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var b = a;.
        /// </summary>
        internal static string JSValueTest {
            get {
                return ResourceManager.GetString("JSValueTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var a = &apos;test&apos;;
        ///a;.
        /// </summary>
        internal static string RunScript {
            get {
                return ResourceManager.GetString("RunScript", resourceCulture);
            }
        }
    }
}