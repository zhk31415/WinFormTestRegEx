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
// Generated by IDLImporter from file nsPIDNSService.idl
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
    /// This is a private interface used by the internals of the networking library.
    /// It will never be frozen.  Do not use it in external code.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6b16fb1f-5709-4c94-a89f-a22be873c54d")]
	public interface nsPIDNSService : nsIDNSService
	{
		
		/// <summary>
        /// kicks off an asynchronous host lookup.
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        /// @param aListener
        /// the listener to be notified when the result is available.
        /// @param aListenerTarget
        /// optional parameter (may be null).  if non-null, this parameter
        /// specifies the nsIEventTarget of the thread on which the
        /// listener's onLookupComplete should be called.  however, if this
        /// parameter is null, then onLookupComplete will be called on an
        /// unspecified thread (possibly recursively).
        ///
        /// @return An object that can be used to cancel the host lookup.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsICancelable AsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);
		
		/// <summary>
        /// Attempts to cancel a previously requested async DNS lookup
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        /// @param aListener
        /// the original listener which was to be notified about the host lookup
        /// result - used to match request information to requestor.
        /// @param aReason
        /// nsresult reason for the cancellation
        ///
        /// @return An object that can be used to cancel the host lookup.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CancelAsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);
		
		/// <summary>
        /// called to synchronously resolve a hostname.  warning this method may
        /// block the calling thread for a long period of time.  it is extremely
        /// unwise to call this function on the UI thread of an application.
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        ///
        /// @return DNS record corresponding to the given hostname.
        /// @throws NS_ERROR_UNKNOWN_HOST if host could not be resolved.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDNSRecord Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags);
		
		/// <summary>
        /// kicks off an asynchronous host lookup.
        ///
        /// This function is identical to asyncResolve except an additional
        /// parameter aNetwortInterface. If parameter aNetworkInterface is an empty
        /// string function will return the same result as asyncResolve.
        /// Setting aNetworkInterface value make only sense for gonk,because it
        /// an per networking interface query is possible.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsICancelable AsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);
		
		/// <summary>
        /// Attempts to cancel a previously requested async DNS lookup
        /// This is an extended versin with a additional parameter aNetworkInterface
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CancelAsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);
		
		/// <summary>
        /// The method takes a pointer to an nsTArray
        /// and fills it with cache entry data
        /// Called by the networking dashboard
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDNSCacheEntries(System.IntPtr args);
		
		/// <summary>
        /// @return the hostname of the operating system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMyHostNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMyHostName);
		
		/// <summary>
        /// called to initialize the DNS service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>
        /// called to shutdown the DNS service.  any pending asynchronous
        /// requests will be canceled, and the local cache of DNS records
        /// will be cleared.  NOTE: the operating system may still have
        /// its own cache of DNS records, which would be unaffected by
        /// this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
		
		/// <summary>
        /// Whether or not DNS prefetching (aka RESOLVE_SPECULATE) is enabled
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrefetchEnabledAttribute();
		
		/// <summary>
        /// Whether or not DNS prefetching (aka RESOLVE_SPECULATE) is enabled
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrefetchEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aPrefetchEnabled);
		
		/// <summary>
        /// @return whether the DNS service is offline.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOfflineAttribute();
		
		/// <summary>
        /// @return whether the DNS service is offline.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aOffline);
	}
}