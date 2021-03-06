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
// Generated by IDLImporter from file nsITetheringService.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("779de2d3-6d29-4ee6-b069-6251839f757a")]
	public interface nsITetheringService
	{
		
		/// <summary>
        /// Current tethering state. One of the TETHERING_STATE_* constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStateAttribute();
		
		/// <summary>
        /// Enable or disable Wifi Tethering.
        ///
        /// @param enabled
        /// Boolean that indicates whether tethering should be enabled (true) or
        /// disabled (false).
        /// @param interfaceName
        /// The Wifi network interface name for internal interface.
        /// @param config
        /// The Wifi Tethering configuration from settings db.
        /// @param callback
        /// Callback function used to report status to WifiManager.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWifiTethering([MarshalAs(UnmanagedType.U1)] bool enabled, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, ref Gecko.JsVal config, [MarshalAs(UnmanagedType.Interface)] nsIWifiTetheringCallback callback);
	}
	
	/// <summary>nsITetheringServiceConsts </summary>
	public class nsITetheringServiceConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this file,
        // You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const long TETHERING_STATE_INACTIVE = 0;
		
		// 
		public const long TETHERING_STATE_WIFI = 1;
		
		// 
		public const long TETHERING_STATE_USB = 2;
	}
}
