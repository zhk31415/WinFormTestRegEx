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
// Generated by IDLImporter from file nsILocalCertService.idl
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
	[Guid("9702fdd4-4c2c-439c-ba2e-19cda018eb99")]
	public interface nsILocalCertService
	{
		
		/// <summary>
        /// Get or create a new self-signed X.509 cert to represent this device over a
        /// secure transport, like TLS.
        ///
        /// The cert is stored permanently in the profile's key store after first use,
        /// and is valid for 1 year.  If an expired or otherwise invalid cert is found
        /// with the nickname supplied here, it is removed and a new one is made.
        ///
        /// @param nickname Nickname that identifies the cert
        /// @param cb       Callback to be notified with the result
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrCreateCert([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase nickname, [MarshalAs(UnmanagedType.Interface)] nsILocalCertGetCallback cb);
		
		/// <summary>
        /// Remove a X.509 cert with the given nickname.
        ///
        /// @param nickname Nickname that identifies the cert
        /// @param cb       Callback to be notified with the result
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveCert([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase nickname, [MarshalAs(UnmanagedType.Interface)] nsILocalCertCallback cb);
		
		/// <summary>
        /// Whether calling |getOrCreateCert| or |removeCert| will trigger a login
        /// prompt to be displayed.  Generally this happens if the user has set a
        /// master password, but has not yet logged in.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLoginPromptRequiredAttribute();
	}
	
	/// <summary>nsILocalCertGetCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cc09633e-7c70-4093-a9cf-79ab676ca8a9")]
	public interface nsILocalCertGetCallback
	{
		
		/// <summary>
        /// Called with the result of the getOrCreateCert operation above.
        ///
        /// @param cert   Requested cert, or null if some error
        /// @param result Result code from the get operation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleCert([MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert, int result);
	}
	
	/// <summary>nsILocalCertCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("518124e9-55e6-4e23-97c0-4995b3a1bec6")]
	public interface nsILocalCertCallback
	{
		
		/// <summary>
        /// Called with the result of the removeCert operation above.
        ///
        /// @param result Result code from the operation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleResult(int result);
	}
}
