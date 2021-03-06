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
// Generated by IDLImporter from file nsIEncodedChannel.idl
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
    /// A channel interface which allows special handling of encoded content
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("29c29ce6-8ce4-45e6-8d60-36c8fa3e255b")]
	public interface nsIEncodedChannel
	{
		
		/// <summary>
        /// This attribute holds the MIME types corresponding to the content
        /// encodings on the channel.  The enumerator returns nsISupportsCString
        /// objects.  The first one corresponds to the outermost encoding on the
        /// channel and then we work our way inward.  "identity" is skipped and not
        /// represented on the list.  Unknown encodings make the enumeration stop.
        /// If you want the actual Content-Encoding value, use
        /// getResponseHeader("Content-Encoding").
        ///
        /// When there is no Content-Encoding header, this property is null.
        ///
        /// Modifying the Content-Encoding header on the channel will cause
        /// this enumerator to have undefined behavior.  Don't do it.
        ///
        /// Also note that contentEncodings only exist during or after OnStartRequest.
        /// Calling contentEncodings before OnStartRequest is an error.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetContentEncodingsAttribute();
		
		/// <summary>
        /// This attribute controls whether or not content conversion should be
        /// done per the Content-Encoding response header.  applyConversion can only
        /// be set before or during OnStartRequest.  Calling this during
        /// OnDataAvailable is an error.
        ///
        /// TRUE by default.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetApplyConversionAttribute();
		
		/// <summary>
        /// This attribute controls whether or not content conversion should be
        /// done per the Content-Encoding response header.  applyConversion can only
        /// be set before or during OnStartRequest.  Calling this during
        /// OnDataAvailable is an error.
        ///
        /// TRUE by default.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetApplyConversionAttribute([MarshalAs(UnmanagedType.U1)] bool aApplyConversion);
		
		/// <summary>
        /// This function will start converters if they are available.
        /// aNewNextListener will be nullptr if no converter is available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoApplyContentConversions([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aNextListener, [MarshalAs(UnmanagedType.Interface)] ref nsIStreamListener aNewNextListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
	}
}
