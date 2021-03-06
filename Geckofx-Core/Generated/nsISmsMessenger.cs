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
// Generated by IDLImporter from file nsISmsMessenger.idl
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
	[Guid("3be7c6ac-e27d-11e4-b6da-7bbe0e4cd4ec")]
	public interface nsISmsMessenger
	{
		
		/// <summary>
        /// To broadcast system messages of 'sms-received', 'sms-delivery-success',
        /// 'sms-sent', 'sms-failed' and 'sms-delivery-error'.
        ///
        /// Note: Except aNotificationType, all parameters are the attributes of the
        /// nsISmsMessage generated by nsIMobileMessageService.createSmsMessage().
        ///
        /// @param aNotificationType
        /// A predefined constant of nsISmsMessenger.NOTIFICATION_TYPE_*.
        /// @param aId
        /// The unique identity of this message.
        /// @param aThreadId
        /// The unique identity of the thread this message belongs to.
        /// @param aIccId
        /// Integrated Circuit Card Identifier. null if ICC is not available.
        /// @param aDelivery
        /// A predefined constant of nsISmsService.DELIVERY_TYPE_*.
        /// @param aDeliveryStatus
        /// A predefined constant of nsISmsService.DELIVERY_STATUS_TYPE_*.
        /// @param aSender
        /// Sender address. null if not available.
        /// @param aReceiver
        /// Receiver address. null if not available.
        /// @param aBody
        /// Text message body. null if not available.
        /// @param aMessageClass
        /// A predefined constant of nsISmsService.MESSAGE_CLASS_TYPE_*.
        /// @param aTimestamp
        /// The device system time when creating or saving this message.
        /// @param aSentTimestamp
        /// The SMSC timestamp of the incoming message.
        /// 0 if not available.
        /// @param aDeliveryTimestamp
        /// The delivery timestamp to the remote party of the sent message.
        /// 0 if not available.
        /// @param aRead
        /// True if the message was read.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySms(ushort aNotificationType, int aId, ulong aThreadId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIccId, uint aDelivery, uint aDeliveryStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSender, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReceiver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBody, uint aMessageClass, long aTimestamp, long aSentTimestamp, long aDeliveryTimestamp, [MarshalAs(UnmanagedType.U1)] bool aRead);
	}
	
	/// <summary>nsISmsMessengerConsts </summary>
	public class nsISmsMessengerConsts
	{
		
		// <summary>
        //'sms-received' system message </summary>
		public const ushort NOTIFICATION_TYPE_RECEIVED = 0;
		
		// <summary>
        //'sms-sent' system message </summary>
		public const ushort NOTIFICATION_TYPE_SENT = 1;
		
		// <summary>
        //'sms-delivery-success' system message </summary>
		public const ushort NOTIFICATION_TYPE_DELIVERY_SUCCESS = 2;
		
		// <summary>
        //'sms-failed' system message </summary>
		public const ushort NOTIFICATION_TYPE_SENT_FAILED = 3;
		
		// <summary>
        //'sms-delivery-error' system message </summary>
		public const ushort NOTIFICATION_TYPE_DELIVERY_ERROR = 4;
	}
}
