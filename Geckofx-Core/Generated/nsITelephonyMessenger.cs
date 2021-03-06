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
// Generated by IDLImporter from file nsITelephonyMessenger.idl
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
	[Guid("84045b7e-84fb-11e4-a94c-5ba58d0d5932")]
	public interface nsITelephonyMessenger
	{
		
		/// <summary>
        /// To broadcast 'telephony-new-call' system message
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyNewCall();
		
		/// <summary>
        /// To broadcast 'telephony-call-ended' system message
        ///
        /// @param aServiceId
        /// The ID of Service where this info is notified from.
        /// @param aNumber
        /// The phone number of the call to be ended.
        /// @param aCdmaWaitingNumber
        /// The CDMA call waiting number to be ended if available.
        /// @param aEmergency
        /// true if it's a emergency number.
        /// @param aDuration
        /// The duration of this call.
        /// @param aOutgoing
        /// true if it's an outgoing call.
        /// @param aHangUpLocal
        /// true if this call was hung up by the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCallEnded(uint aServiceId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNumber, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCdmaWaitingNumber, [MarshalAs(UnmanagedType.U1)] bool aEmergency, uint aDuration, [MarshalAs(UnmanagedType.U1)] bool aOutgoing, [MarshalAs(UnmanagedType.U1)] bool aHangUpLocal);
		
		/// <summary>
        /// 'ussd-received' system message
        ///
        /// @param aServiceId
        /// The ID of Service where this info is notified from.
        /// @param aMessage
        /// USSD Message to be displayed.
        /// @param aSessionEnded
        /// True if USSD session is ended.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyUssdReceived(uint aServiceId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMessage, [MarshalAs(UnmanagedType.U1)] bool aSessionEnded);
	}
}
