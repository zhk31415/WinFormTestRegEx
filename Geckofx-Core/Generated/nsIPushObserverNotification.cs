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
// Generated by IDLImporter from file nsIPushObserverNotification.idl
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
    /// A push message received by an `nsIPushNotificationService`, used as the
    /// subject of a `push-notification` observer notification.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56f57607-28b6-44b0-aa56-3d4d3c88be15")]
	public interface nsIPushObserverNotification
	{
		
		/// <summary>
        ///The URL that receives push messages from an application server. </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPushEndpointAttribute();
		
		/// <summary>
        ///The URL that receives push messages from an application server. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPushEndpointAttribute([MarshalAs(UnmanagedType.LPStr)] string aPushEndpoint);
		
		/// <summary>
        /// The notification version sent by the application server. This is a
        /// monotonically increasing number.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetVersionAttribute();
		
		/// <summary>
        /// The notification version sent by the application server. This is a
        /// monotonically increasing number.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVersionAttribute(long aVersion);
		
		/// <summary>
        /// The notification payload. Delivery is not guaranteed; if the browser is
        /// offline when the application server sends the push message, the payload
        /// may be discarded.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDataAttribute();
		
		/// <summary>
        /// The notification payload. Delivery is not guaranteed; if the browser is
        /// offline when the application server sends the push message, the payload
        /// may be discarded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute([MarshalAs(UnmanagedType.LPStr)] string aData);
		
		/// <summary>
        /// How many times has a push event occured against this pushEndpoint
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPushCountAttribute();
		
		/// <summary>
        /// How many times has a push event occured against this pushEndpoint
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPushCountAttribute(long aPushCount);
		
		/// <summary>
        /// The last time a push occured against this this pushEndpoint
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastPushAttribute();
		
		/// <summary>
        /// The last time a push occured against this this pushEndpoint
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastPushAttribute(long aLastPush);
	}
}
