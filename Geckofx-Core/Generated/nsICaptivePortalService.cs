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
// Generated by IDLImporter from file nsICaptivePortalService.idl
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
	[Guid("b5fd5629-d04c-4138-9529-9311f291ecd4")]
	public interface nsICaptivePortalServiceCallback
	{
		
		/// <summary>
        /// Invoke callbacks after captive portal detection finished.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Complete([MarshalAs(UnmanagedType.U1)] bool success, int error);
	}
	
	/// <summary>
    /// Service used for captive portal detection.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bdbe0555-fc3d-4f7b-9205-c309ceb2d641")]
	public interface nsICaptivePortalService
	{
		
		/// <summary>
        /// Called from XPCOM to trigger a captive portal recheck.
        /// A network request will only be performed if no other checks are currently
        /// ongoing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RecheckCaptivePortal();
		
		/// <summary>
        /// Returns the state of the captive portal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStateAttribute();
		
		/// <summary>
        /// Returns the time difference between NOW and the last time a request was
        /// completed in milliseconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetLastCheckedAttribute();
	}
	
	/// <summary>nsICaptivePortalServiceConsts </summary>
	public class nsICaptivePortalServiceConsts
	{
		
		// <summary>
        // Service used for captive portal detection.
        // </summary>
		public const long UNKNOWN = 0;
		
		// 
		public const long NOT_CAPTIVE = 1;
		
		// 
		public const long UNLOCKED_PORTAL = 2;
		
		// 
		public const long LOCKED_PORTAL = 3;
	}
}
