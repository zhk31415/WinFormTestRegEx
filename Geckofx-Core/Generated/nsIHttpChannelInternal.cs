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
// Generated by IDLImporter from file nsIHttpChannelInternal.idl
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
    /// The callback interface for nsIHttpChannelInternal::HTTPUpgrade()
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5b515449-ab64-4dba-b3cd-da8fc2f83064")]
	public interface nsIHttpUpgradeListener
	{
		
		/// <summary>
        /// The callback interface for nsIHttpChannelInternal::HTTPUpgrade()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnTransportAvailable([MarshalAs(UnmanagedType.Interface)] nsISocketTransport aTransport, [MarshalAs(UnmanagedType.Interface)] nsIAsyncInputStream aSocketIn, [MarshalAs(UnmanagedType.Interface)] nsIAsyncOutputStream aSocketOut);
	}
	
	/// <summary>
    /// Dumping ground for http.  This interface will never be frozen.  If you are
    /// using any feature exposed by this interface, be aware that this interface
    /// will change and you will be broken.  You have been warned.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("332d5f9c-991c-45e3-922f-99e6fe0deb60")]
	public interface nsIHttpChannelInternal
	{
		
		/// <summary>
        /// An http channel can own a reference to the document URI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetDocumentURIAttribute();
		
		/// <summary>
        /// An http channel can own a reference to the document URI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI);
		
		/// <summary>
        /// Get the major/minor version numbers for the request
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestVersion(ref uint major, ref uint minor);
		
		/// <summary>
        /// Get the major/minor version numbers for the response
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponseVersion(ref uint major, ref uint minor);
		
		/// <summary>
        /// Retrieves all security messages from the security message queue
        /// and empties the queue after retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TakeAllSecurityMessages(System.IntPtr aMessages);
		
		/// <summary>
        /// Helper method to set a cookie with a consumer-provided
        /// cookie header, _but_ using the channel's other information
        /// (URI's, prompters, date headers etc).
        ///
        /// @param aCookieHeader
        /// The cookie header to be parsed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookie([MarshalAs(UnmanagedType.LPStr)] string aCookieHeader);
		
		/// <summary>
        /// Setup this channel as an application cache fallback channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupFallbackChannel([MarshalAs(UnmanagedType.LPStr)] string aFallbackKey);
		
		/// <summary>
        /// When set, these flags modify the algorithm used to decide whether to
        /// send 3rd party cookies for a given channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetThirdPartyFlagsAttribute();
		
		/// <summary>
        /// When set, these flags modify the algorithm used to decide whether to
        /// send 3rd party cookies for a given channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetThirdPartyFlagsAttribute(uint aThirdPartyFlags);
		
		/// <summary>
        /// This attribute was added before the "flags" above and is retained here
        /// for compatibility. When set to true, has the same effect as
        /// THIRD_PARTY_FORCE_ALLOW, described above.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetForceAllowThirdPartyCookieAttribute();
		
		/// <summary>
        /// This attribute was added before the "flags" above and is retained here
        /// for compatibility. When set to true, has the same effect as
        /// THIRD_PARTY_FORCE_ALLOW, described above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForceAllowThirdPartyCookieAttribute([MarshalAs(UnmanagedType.U1)] bool aForceAllowThirdPartyCookie);
		
		/// <summary>
        /// True iff the channel has been canceled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanceledAttribute();
		
		/// <summary>
        /// External handlers may set this to true to notify the channel
        /// that it is open on behalf of a download.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetChannelIsForDownloadAttribute();
		
		/// <summary>
        /// External handlers may set this to true to notify the channel
        /// that it is open on behalf of a download.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChannelIsForDownloadAttribute([MarshalAs(UnmanagedType.U1)] bool aChannelIsForDownload);
		
		/// <summary>
        /// The local IP address to which this channel is bound, in the
        /// format produced by PR_NetAddrToString. May be IPv4 or IPv6.
        /// Note: in the presence of NAT, this may not be the same as the
        /// address that the remote host thinks it's talking to.
        ///
        /// May throw NS_ERROR_NOT_AVAILABLE if accessed when the channel's
        /// endpoints are not yet determined, or in any case when
        /// nsIHttpActivityObserver.isActive is false. See bugs 534698 and 526207.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLocalAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aLocalAddress);
		
		/// <summary>
        /// The local port number to which this channel is bound.
        ///
        /// May throw NS_ERROR_NOT_AVAILABLE if accessed when the channel's
        /// endpoints are not yet determined, or in any case when
        /// nsIHttpActivityObserver.isActive is false. See bugs 534698 and 526207.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLocalPortAttribute();
		
		/// <summary>
        /// The IP address of the remote host that this channel is
        /// connected to, in the format produced by PR_NetAddrToString.
        ///
        /// May throw NS_ERROR_NOT_AVAILABLE if accessed when the channel's
        /// endpoints are not yet determined, or in any case when
        /// nsIHttpActivityObserver.isActive is false. See bugs 534698 and 526207.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRemoteAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRemoteAddress);
		
		/// <summary>
        /// The remote port number that this channel is connected to.
        ///
        /// May throw NS_ERROR_NOT_AVAILABLE if accessed when the channel's
        /// endpoints are not yet determined, or in any case when
        /// nsIHttpActivityObserver.isActive is false. See bugs 534698 and 526207.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRemotePortAttribute();
		
		/// <summary>
        /// Transfer chain of redirected cache-keys.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheKeysRedirectChain(System.IntPtr cacheKeys);
		
		/// <summary>
        /// HTTPUpgrade allows for the use of HTTP to bootstrap another protocol
        /// via the RFC 2616 Upgrade request header in conjunction with a 101 level
        /// response. The nsIHttpUpgradeListener will have its
        /// onTransportAvailable() method invoked if a matching 101 is processed.
        /// The arguments to onTransportAvailable provide the new protocol the low
        /// level tranport streams that are no longer used by HTTP.
        ///
        /// The onStartRequest and onStopRequest events are still delivered and the
        /// listener gets full control over the socket if and when onTransportAvailable
        /// is delievered.
        ///
        /// @param aProtocolName
        /// The value of the HTTP Upgrade request header
        /// @param aListener
        /// The callback object used to handle a successful upgrade
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HTTPUpgrade([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolName, [MarshalAs(UnmanagedType.Interface)] nsIHttpUpgradeListener aListener);
		
		/// <summary>
        /// Enable/Disable Spdy negotiation on per channel basis.
        /// The network.http.spdy.enabled preference is still a pre-requisite
        /// for starting spdy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowSpdyAttribute();
		
		/// <summary>
        /// Enable/Disable Spdy negotiation on per channel basis.
        /// The network.http.spdy.enabled preference is still a pre-requisite
        /// for starting spdy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowSpdyAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowSpdy);
		
		/// <summary>
        /// This attribute en/disables the timeout for the first byte of an HTTP
        /// response. Enabled by default.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetResponseTimeoutEnabledAttribute();
		
		/// <summary>
        /// This attribute en/disables the timeout for the first byte of an HTTP
        /// response. Enabled by default.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResponseTimeoutEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aResponseTimeoutEnabled);
		
		/// <summary>
        /// If the underlying transport supports RWIN manipulation, this is the
        /// intiial window value for the channel. HTTP/2 implements this.
        /// 0 means no override from system default. Set before opening channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetInitialRwinAttribute();
		
		/// <summary>
        /// If the underlying transport supports RWIN manipulation, this is the
        /// intiial window value for the channel. HTTP/2 implements this.
        /// 0 means no override from system default. Set before opening channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInitialRwinAttribute(uint aInitialRwin);
		
		/// <summary>
        /// Get value of the URI passed to nsIHttpChannel.redirectTo() if any.
        /// May return null when redirectTo() has not been called.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetApiRedirectToURIAttribute();
		
		/// <summary>
        /// Enable/Disable use of Alternate Services with this channel.
        /// The network.http.altsvc.enabled preference is still a pre-requisite.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowAltSvcAttribute();
		
		/// <summary>
        /// Enable/Disable use of Alternate Services with this channel.
        /// The network.http.altsvc.enabled preference is still a pre-requisite.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowAltSvcAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowAltSvc);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeAttribute();
		
		/// <summary>
        /// Force a channel that has not been AsyncOpen'ed to skip any check for possible
        /// interception and proceed immediately to open a previously-synthesized cache
        /// entry using the provided ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceIntercepted(ulong aInterceptionID);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetResponseSynthesizedAttribute();
		
		/// <summary>
        /// Set by nsCORSListenerProxy if credentials should be included in
        /// cross-origin requests. false indicates "same-origin", users should still
        /// check flag LOAD_ANONYMOUS!
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCorsIncludeCredentialsAttribute();
		
		/// <summary>
        /// Set by nsCORSListenerProxy if credentials should be included in
        /// cross-origin requests. false indicates "same-origin", users should still
        /// check flag LOAD_ANONYMOUS!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCorsIncludeCredentialsAttribute([MarshalAs(UnmanagedType.U1)] bool aCorsIncludeCredentials);
		
		/// <summary>
        /// Set by nsCORSListenerProxy to indicate CORS load type. Defaults to CORS_MODE_NO_CORS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCorsModeAttribute();
		
		/// <summary>
        /// Set by nsCORSListenerProxy to indicate CORS load type. Defaults to CORS_MODE_NO_CORS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCorsModeAttribute(uint aCorsMode);
		
		/// <summary>
        /// Set to indicate Request.redirect mode exposed during ServiceWorker
        /// interception. No policy enforcement is performed by the channel for this
        /// value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRedirectModeAttribute();
		
		/// <summary>
        /// Set to indicate Request.redirect mode exposed during ServiceWorker
        /// interception. No policy enforcement is performed by the channel for this
        /// value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRedirectModeAttribute(uint aRedirectMode);
		
		/// <summary>
        /// The URI of the top-level window that's associated with this channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetTopWindowURIAttribute();
		
		/// <summary>
        /// The network interface id that's associated with this channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetworkInterfaceIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNetworkInterfaceId);
		
		/// <summary>
        /// The network interface id that's associated with this channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNetworkInterfaceIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNetworkInterfaceId);
		
		/// <summary>
        /// Read the proxy URI, which, if non-null, will be used to resolve
        /// proxies for this channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetProxyURIAttribute();
		
		/// <summary>
        /// Make cross-origin CORS loads happen with a CORS preflight, and specify
        /// the CORS preflight parameters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCorsPreflightParameters(System.IntPtr unsafeHeaders);
	}
	
	/// <summary>nsIHttpChannelInternalConsts </summary>
	public class nsIHttpChannelInternalConsts
	{
		
		// <summary>
        // This flag is set to force relevant cookies to be sent with this load
        // even if normally they wouldn't be.
        // </summary>
		public const ulong THIRD_PARTY_FORCE_ALLOW = 1<<0;
		
		// 
		public const ulong CORS_MODE_SAME_ORIGIN = 0;
		
		// 
		public const ulong CORS_MODE_NO_CORS = 1;
		
		// 
		public const ulong CORS_MODE_CORS = 2;
		
		// 
		public const ulong REDIRECT_MODE_FOLLOW = 0;
		
		// 
		public const ulong REDIRECT_MODE_ERROR = 1;
		
		// 
		public const ulong REDIRECT_MODE_MANUAL = 2;
	}
}
