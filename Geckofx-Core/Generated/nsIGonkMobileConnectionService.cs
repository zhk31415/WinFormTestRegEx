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
// Generated by IDLImporter from file nsIGonkMobileConnectionService.idl
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
	[Guid("3c306f88-86bf-11e5-91af-3b2233acec65")]
	public interface nsIGonkMobileConnectionService : nsIMobileConnectionService
	{
		
		/// <summary>Member GetNumItemsAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetNumItemsAttribute();
		
		/// <summary>Member GetItemByServiceId </summary>
		/// <param name='serviceId'> </param>
		/// <returns>A nsIMobileConnection</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIMobileConnection GetItemByServiceId(uint serviceId);
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyNetworkInfoChanged(uint clientId, ref Gecko.JsVal networkInfo);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyVoiceInfoChanged(uint clientId, ref Gecko.JsVal voiceInfo);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDataInfoChanged(uint clientId, ref Gecko.JsVal dataInfo);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDataError(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySignalStrengthChanged(uint clientId, ref Gecko.JsVal signal);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyOperatorChanged(uint clientId, ref Gecko.JsVal info);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyOtaStatusChanged(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase status);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyRadioStateChanged(uint clientId, int radioState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyEmergencyCallbackModeChanged(uint clientId, [MarshalAs(UnmanagedType.U1)] bool active, uint timeoutMs);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyNetworkSelectModeChanged(uint clientId, int mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySpnAvailable(uint clientId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyLastHomeNetworkChanged(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase network);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCFStateChanged(uint clientId, ushort action, ushort reason, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, ushort timeSeconds, ushort serviceClass);
		
		/// <summary>
        /// Notify Display Info from received Cdma-Info-Record.
        /// See 3.7.4.1 Display in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param display
        ///            The string to be displayed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecDisplay(uint clientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase display);
		
		/// <summary>
        /// Notify Called Party Number from received Cdma-Info-Record.
        /// See 3.7.4.2 Called Party Number in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param type
        /// The type of number. (3-bit binary)
        /// See Table 2.7.1.3.2.4-2 in 3GPP2 C.S0005-F.
        /// @param plan
        /// The numbering plan. (4-bit binary)
        /// See Table 2.7.1.3.2.4-3 in 3GPP2 C.S0005-F.
        /// @param number
        /// The string presentation of the number.
        /// @param pi (2-bit binary)
        /// The Presentation indicator of the number.
        /// See Table 2.7.4.4-1 in 3GPP2 C.S0005-F.
        /// @param si (2-bit binary)
        /// The Screening Indicator of the number.
        /// See Table 2.7.4.4-2 in 3GPP2 C.S0005-F.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecCalledPartyNumber(uint clientId, ushort type, ushort plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, ushort pi, ushort si);
		
		/// <summary>
        /// Notify Calling Party Number from received Cdma-Info-Record.
        /// See 3.7.4.3 Calling Party Number in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param type
        /// The type of number. (3-bit binary)
        /// See Table 2.7.1.3.2.4-2 in 3GPP2 C.S0005-F.
        /// @param plan
        /// The numbering plan. (4-bit binary)
        /// See Table 2.7.1.3.2.4-3 in 3GPP2 C.S0005-F.
        /// @param number
        /// The string presentation of the number.
        /// @param pi (2-bit binary)
        /// The Presentation indicator of the number.
        /// See Table 2.7.4.4-1 in 3GPP2 C.S0005-F.
        /// @param si (2-bit binary)
        /// The Screening Indicator of the number.
        /// See Table 2.7.4.4-2 in 3GPP2 C.S0005-F.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecCallingPartyNumber(uint clientId, ushort type, ushort plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, ushort pi, ushort si);
		
		/// <summary>
        /// Notify Connected Party Number from received Cdma-Info-Record.
        /// See 3.7.4.4 Connected Party Number in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param type
        /// The type of number. (3-bit binary)
        /// See Table 2.7.1.3.2.4-2 in 3GPP2 C.S0005-F.
        /// @param plan
        /// The numbering plan. (4-bit binary)
        /// See Table 2.7.1.3.2.4-3 in 3GPP2 C.S0005-F.
        /// @param number
        /// The string presentation of the number.
        /// @param pi (2-bit binary)
        /// The Presentation indicator of the number.
        /// See Table 2.7.4.4-1 in 3GPP2 C.S0005-F.
        /// @param si (2-bit binary)
        /// The Screening Indicator of the number.
        /// See Table 2.7.4.4-2 in 3GPP2 C.S0005-F.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecConnectedPartyNumber(uint clientId, ushort type, ushort plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, ushort pi, ushort si);
		
		/// <summary>
        /// Notify Signal Info from received Cdma-Info-Record.
        /// See 3.7.4.5 Signal in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param type
        /// The signal type. (2-bit binary)
        /// See Table 3.7.5.5-1 in 3GPP2 C.S0005-F.
        /// @param alertPitch
        /// The pitch of the alerting signal. (2-bit binary)
        /// See Table 3.7.5.5-2 in 3GPP2 C.S0005-F.
        /// @param signal
        /// The signal code. (6-bit binary)
        /// See Table 3.7.5.5-3, 3.7.5.5-4, 3.7.5.5-5 in 3GPP2 C.S0005-F.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecSignal(uint clientId, ushort type, ushort alertPitch, ushort signal);
		
		/// <summary>
        /// Notify Redirecting Number from received Cdma-Info-Record.
        /// See 3.7.4.11 Redirecting Number in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param type
        /// The type of number. (3-bit binary)
        /// See Table 2.7.1.3.2.4-2 in 3GPP2 C.S0005-F.
        /// @param plan
        /// The numbering plan. (4-bit binary)
        /// See Table 2.7.1.3.2.4-3 in 3GPP2 C.S0005-F.
        /// @param number
        /// The string presentation of the number.
        /// @param pi (2-bit binary)
        /// The Presentation indicator of the number.
        /// See Table 2.7.4.4-1 in 3GPP2 C.S0005-F.
        /// @param si (2-bit binary)
        /// The Screening Indicator of the number.
        /// See Table 2.7.4.4-2 in 3GPP2 C.S0005-F.
        /// @param reason (4-bit binary)
        /// The redirection reason.
        /// See Table 3.7.5.11-1 in 3GPP2 C.S0005-F.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecRedirectingNumber(uint clientId, ushort type, ushort plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, ushort pi, ushort si, ushort reason);
		
		/// <summary>
        /// Notify Line Control from received Cdma-Info-Record.
        /// See 3.7.4.15 Line Control in 3GPP2 C.S0005-F.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param polarityIncluded (1-bit)
        /// Polarity parameter included.
        /// @param toggle (1-bit)
        /// Toggle mode.
        /// @param reverse (1-bit)
        /// Reverse polarity.
        /// @param powerDenial (8-bit)
        /// Power denial timeout.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecLineControl(uint clientId, ushort polarityIncluded, ushort toggle, ushort reverse, ushort powerDenial);
		
		/// <summary>
        /// Notify CLIR from received Cdma-Info-Record.
        /// See 'ANNEX 1 Country-Specific Record Type for Japan' in T53.
        /// http://www.arib.or.jp/english/html/overview/doc/T53v6_5_pdf/5_ANNEX_v6_5.pdf
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param cause
        /// Reason code. (8-bit binary)
        /// See Table A 1.1-1 in T53.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecClir(uint clientId, ushort cause);
		
		/// <summary>
        /// Notify Audio Control from received Cdma-Info-Record.
        ///
        /// Note: No information from ARIB about Audio Control.
        /// It seems obsolete according to ANNEX 1 in T53.
        /// upLink/downLink are 'byte' value according to ril.h.
        /// Treat them as 'signed short' to preserve the flexibility when needed.
        ///
        /// @param clientId
        /// The ID of radioInterface where this info is notified from.
        /// @param upLink
        /// @param downLink
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCdmaInfoRecAudioControl(uint clientId, short upLink, short downLink);
		
		/// <summary>
        /// Notify Device Identities.
        ///
        /// @param aClientId
        /// The ID of radioInterface where this info is notified from.
        /// @param aImei
        /// Device IMEI, valid if GSM subscription is available.
        /// @param aImeisv
        /// Device IMEISV, valid if GSM subscription is available.
        /// @param aEsn
        /// Device ESN, valid if CDMA subscription is available.
        /// @param aMeid
        /// Device MEID, valid if CDMA subscription is available.
        ///
        /// Note: The value might be dummy like "000..." from modem
        /// if the corresponding subscription is not available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDeviceIdentitiesChanged(uint aClientId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImei, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImeisv, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEsn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMeid);
	}
}
