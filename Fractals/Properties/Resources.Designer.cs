﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fractals.Properties {
    using System;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fractals.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to #if defined CUDA
        ///
        ///	#define DeviceKernel __global__
        ///	#define DeviceFunc __device__
        ///	#define DeviceVar const
        ///	#define DeviceBlockStart extern &quot;C&quot; {
        ///	#define DeviceBlockEnd }
        ///
        ///	#define uint unsigned int
        ///	#define ulong unsigned long
        ///	#define mul_hi __mulhi
        ///
        ///	#define get_global_id(i) i == 0 ? threadIdx.x + blockIdx.x * blockDim.x : i == 1 ? threadIdx.y + blockIdx.y * blockDim.y : -1
        ///	#define get_global_size(i) i == 0 ? gridDim.x * blockDim.x : i == 1 ? gridDim.y * blockDim.y : -1
        ///
        ///	#define ptr_buf [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Fractals {
            get {
                return ResourceManager.GetString("Fractals", resourceCulture);
            }
        }
        
        internal static byte[] Fractals_MPI {
            get {
                object obj = ResourceManager.GetObject("Fractals_MPI", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] FractalsCuda_x64 {
            get {
                object obj = ResourceManager.GetObject("FractalsCuda_x64", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] FractalsCuda_x86 {
            get {
                object obj = ResourceManager.GetObject("FractalsCuda_x86", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}