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
// Generated by IDLImporter from file nsISlowScriptDebug.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f7dbb80c-5d1e-4fd9-b55c-a9ffda4a75b1")]
	public interface nsISlowScriptDebugCallback
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleSlowScriptDebug([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
	}
	
	/// <summary>nsISlowScriptDebuggerStartupCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b1c6ecd0-8fa4-11e4-b4a9-0800200c9a66")]
	public interface nsISlowScriptDebuggerStartupCallback
	{
		
		/// <summary>Member FinishDebuggerStartup </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FinishDebuggerStartup();
	}
	
	/// <summary>nsISlowScriptDebugRemoteCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dbee14b0-8fa0-11e4-b4a9-0800200c9a66")]
	public interface nsISlowScriptDebugRemoteCallback
	{
		
		/// <summary>Member HandleSlowScriptDebug </summary>
		/// <param name='aBrowser'> </param>
		/// <param name='aCallback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleSlowScriptDebug([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aBrowser, [MarshalAs(UnmanagedType.Interface)] nsISlowScriptDebuggerStartupCallback aCallback);
	}
	
	/// <summary>nsISlowScriptDebug </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f75d4164-3aa7-4395-ba44-a5f95b2e8427")]
	public interface nsISlowScriptDebug
	{
		
		/// <summary>Member GetActivationHandlerAttribute </summary>
		/// <returns>A nsISlowScriptDebugCallback</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISlowScriptDebugCallback GetActivationHandlerAttribute();
		
		/// <summary>Member SetActivationHandlerAttribute </summary>
		/// <param name='aActivationHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActivationHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISlowScriptDebugCallback aActivationHandler);
		
		/// <summary>Member GetRemoteActivationHandlerAttribute </summary>
		/// <returns>A nsISlowScriptDebugRemoteCallback</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISlowScriptDebugRemoteCallback GetRemoteActivationHandlerAttribute();
		
		/// <summary>Member SetRemoteActivationHandlerAttribute </summary>
		/// <param name='aRemoteActivationHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRemoteActivationHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISlowScriptDebugRemoteCallback aRemoteActivationHandler);
	}
}
