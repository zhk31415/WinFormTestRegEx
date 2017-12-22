// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIStatusReporter.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Status reporters show Firefox's service status.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ffcb716c-deeb-44ea-9d9d-ab25dc6980a8")]
	public interface nsIStatusReporter
	{
		
		/// <summary>
        /// Status reporters show Firefox's service status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);
		
		/// <summary>
        /// The name of the process containing this reporter.  Each reporter initially
        /// has "" in this field, indicating that it applies to the current process.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProcessAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProcess);
		
		/// <summary>
        /// A human-readable status description.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDescription);
	}
	
	/// <summary>nsIStatusReporterManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fd531273-3319-4fcd-90f2-9f53876c3828")]
	public interface nsIStatusReporterManager
	{
		
		/// <summary>
        /// Return an enumerator of nsIStatusReporters that are currently registered.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateReporters();
		
		/// <summary>
        /// Register the given nsIStatusReporter.  After a reporter is registered,
        /// it will be available via enumerateReporters().  The Manager service
        /// will hold a strong reference to the given reporter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterReporter([MarshalAs(UnmanagedType.Interface)] nsIStatusReporter reporter);
		
		/// <summary>
        /// Unregister the given status reporter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterReporter([MarshalAs(UnmanagedType.Interface)] nsIStatusReporter reporter);
		
		/// <summary>
        /// Initialize.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>
        /// Dump service status as a json file
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DumpReports();
	}
}
