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
// Generated by IDLImporter from file nsIStkCmdFactory.idl
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
    /// This StkCmdFactory provides series factory methods to create objects defined
    /// in nsIStkProactiveCmd.idl and MozStkCommandEvent.webidl.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("743536c4-006f-11e5-a3f7-bf7a7fd59b9b")]
	public interface nsIStkCmdFactory
	{
		
		/// <summary>
        /// @param  aCommandDetails
        /// A JS object which complies with 'dictionary MozStkCommand'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return a nsIStkProactiveCmd instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkProactiveCmd CreateCommand(ref Gecko.JsVal aCommandDetails);
		
		/// <summary>
        /// @param  aStkProactiveCmd
        /// a nsIStkProactiveCmd instance.
        ///
        /// @return a JS object which complies with 'dictionary MozStkCommand'
        /// in MozStkCommandEvent.webidl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal CreateCommandMessage([MarshalAs(UnmanagedType.Interface)] nsIStkProactiveCmd aStkProactiveCmd);
		
		/// <summary>
        /// @param  aStkProactiveCmd
        /// a nsIStkProactiveCmd instance.
        ///
        /// @return a JSON string which complies with 'dictionary MozStkCommand'
        /// in MozStkCommandEvent.webidl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeflateCommand([MarshalAs(UnmanagedType.Interface)] nsIStkProactiveCmd aStkProactiveCmd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// @param  a JSON string which complies with 'dictionary MozStkCommand'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return a nsIStkProactiveCmd instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkProactiveCmd InflateCommand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aJSON);
		
		/// <summary>
        /// @param aResponseMessage
        /// A JS object which complies with 'dictionary MozStkResponse'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return a nsIStkTerminalResponse instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkTerminalResponse CreateResponse(ref Gecko.JsVal aResponseMessage);
		
		/// <summary>
        /// @param  aStkTerminalResponse
        /// a nsIStkTerminalResponse instance.
        ///
        /// @return a JS object which complies with 'dictionary MozStkResponse'
        /// in MozStkCommandEvent.webidl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal CreateResponseMessage([MarshalAs(UnmanagedType.Interface)] nsIStkTerminalResponse aStkTerminalResponse);
		
		/// <summary>
        /// @param  aStkTerminalResponse
        /// a nsIStkTerminalResponse instance.
        ///
        /// @return a JSON string which complies with 'dictionary MozStkResponse'
        /// in MozStkCommandEvent.webidl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeflateResponse([MarshalAs(UnmanagedType.Interface)] nsIStkTerminalResponse aStkTerminalResponse, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// @param  a JSON string which complies with 'dictionary MozStkResponse'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return a nsIStkTerminalResponse instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkTerminalResponse InflateResponse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aJSON);
		
		/// <summary>
        /// @param aEventMessage
        /// A JS object which complies with 'dictionary MozStkXxxEvent'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return a nsIStkDownloadEvent instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkDownloadEvent CreateEvent(ref Gecko.JsVal aEventMessage);
		
		/// <summary>
        /// @param  aStkDownloadEvent
        /// a nsIStkDownloadEvent instance.
        ///
        /// @return a JS object which complies with 'dictionary MozStkXxxEvent'
        /// in MozStkCommandEvent.webidl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal CreateEventMessage([MarshalAs(UnmanagedType.Interface)] nsIStkDownloadEvent aStkDownloadEvent);
		
		/// <summary>
        /// @param  aStkDownloadEvent
        /// a nsIStkDownloadEvent instance.
        ///
        /// @return a JSON string which complies with 'dictionary MozStkXxxEvent'
        /// in MozStkCommandEvent.webidl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeflateDownloadEvent([MarshalAs(UnmanagedType.Interface)] nsIStkDownloadEvent aStkDownloadEvent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// @param  a JSON string which complies with 'dictionary MozStkXxxEvent'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return a nsIStkDownloadEvent instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkDownloadEvent InflateDownloadEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aJSON);
		
		/// <summary>
        /// @param aStkTimerMessage
        /// a JS object which complies with 'dictionary MozStkTimer'
        /// in MozStkCommandEvent.webidl
        ///
        /// @return an instance of nsIStkTimer with the same timerId and timerValue
        /// from aStkTimerMessage.
        ///
        /// Note: This API is specific to nsIIcc::sendStkTimerExpiration().
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStkTimer CreateTimer(ref Gecko.JsVal aStkTimerMessage);
	}
}
