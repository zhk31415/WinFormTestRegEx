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
// Generated by IDLImporter from file nsIDocShellLoadInfo.idl
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
    /// The nsIDocShellLoadInfo interface defines an interface for specifying
    /// setup information used in a nsIDocShell::loadURI call.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e7570e5a-f1d6-452d-b4f8-b35fdc63aa03")]
	public interface nsIDocShellLoadInfo
	{
		
		/// <summary>
        ///This is the referrer for the load. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferrerAttribute();
		
		/// <summary>
        ///This is the referrer for the load. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);
		
		/// <summary>
        /// The originalURI to be passed to nsIDocShell.internalLoad. May be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetOriginalURIAttribute();
		
		/// <summary>
        /// The originalURI to be passed to nsIDocShell.internalLoad. May be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);
		
		/// <summary>
        /// loadReplace flag to be passed to nsIDocShell.internalLoad.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLoadReplaceAttribute();
		
		/// <summary>
        /// loadReplace flag to be passed to nsIDocShell.internalLoad.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadReplaceAttribute([MarshalAs(UnmanagedType.U1)] bool aLoadReplace);
		
		/// <summary>
        ///The owner of the load, that is, the entity responsible for
        /// causing the load to occur. This should be a nsIPrincipal typically.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetOwnerAttribute();
		
		/// <summary>
        ///The owner of the load, that is, the entity responsible for
        /// causing the load to occur. This should be a nsIPrincipal typically.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);
		
		/// <summary>
        ///If this attribute is true and no owner is specified, copy
        /// the owner from the referring document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInheritOwnerAttribute();
		
		/// <summary>
        ///If this attribute is true and no owner is specified, copy
        /// the owner from the referring document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInheritOwnerAttribute([MarshalAs(UnmanagedType.U1)] bool aInheritOwner);
		
		/// <summary>
        ///If this attribute is true only ever use the owner specify by
        /// the owner and inheritOwner attributes.
        /// If there are security reasons for why this is unsafe, such
        /// as trying to use a systemprincipal owner for a content docshell
        /// the load fails.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOwnerIsExplicitAttribute();
		
		/// <summary>
        ///If this attribute is true only ever use the owner specify by
        /// the owner and inheritOwner attributes.
        /// If there are security reasons for why this is unsafe, such
        /// as trying to use a systemprincipal owner for a content docshell
        /// the load fails.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerIsExplicitAttribute([MarshalAs(UnmanagedType.U1)] bool aOwnerIsExplicit);
		
		/// <summary>
        ///Contains a load type as specified by the load* constants </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLoadTypeAttribute();
		
		/// <summary>
        ///Contains a load type as specified by the load* constants </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(System.IntPtr aLoadType);
		
		/// <summary>
        ///SHEntry for this page </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry GetSHEntryAttribute();
		
		/// <summary>
        ///SHEntry for this page </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSHEntryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);
		
		/// <summary>
        ///Target for load, like _content, _blank etc. </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTargetAttribute();
		
		/// <summary>
        ///Target for load, like _content, _blank etc. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTarget);
		
		/// <summary>
        ///Post data </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetPostDataStreamAttribute();
		
		/// <summary>
        ///Post data </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPostDataStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostDataStream);
		
		/// <summary>
        ///Additional headers </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetHeadersStreamAttribute();
		
		/// <summary>
        ///Additional headers </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeadersStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeadersStream);
		
		/// <summary>
        ///True if the referrer should be sent, false if it shouldn't be
        /// sent, even if it's available. This attribute defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSendReferrerAttribute();
		
		/// <summary>
        ///True if the referrer should be sent, false if it shouldn't be
        /// sent, even if it's available. This attribute defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSendReferrerAttribute([MarshalAs(UnmanagedType.U1)] bool aSendReferrer);
		
		/// <summary>
        ///Referrer policy for the load. This attribute holds one of
        /// the values (REFERRER_POLICY_*) defined in nsIHttpChannel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetReferrerPolicyAttribute();
		
		/// <summary>
        ///Referrer policy for the load. This attribute holds one of
        /// the values (REFERRER_POLICY_*) defined in nsIHttpChannel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerPolicyAttribute(System.IntPtr aReferrerPolicy);
		
		/// <summary>
        ///True if the docshell has been created to load an iframe where the
        /// srcdoc attribute has been set.  Set when srcdocData is specified.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSrcdocLoadAttribute();
		
		/// <summary>
        ///When set, the load will be interpreted as a srcdoc load, where contents
        /// of this string will be loaded instead of the URI.  Setting srcdocData
        /// sets isSrcdocLoad to true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);
		
		/// <summary>
        ///When set, the load will be interpreted as a srcdoc load, where contents
        /// of this string will be loaded instead of the URI.  Setting srcdocData
        /// sets isSrcdocLoad to true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);
		
		/// <summary>
        ///When set, this is the Source Browsing Context for the navigation. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShell GetSourceDocShellAttribute();
		
		/// <summary>
        ///When set, this is the Source Browsing Context for the navigation. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSourceDocShellAttribute([MarshalAs(UnmanagedType.Interface)] nsIDocShell aSourceDocShell);
		
		/// <summary>
        /// Used for srcdoc loads to give view-source knowledge of the load's base
        /// URI as this information isn't embedded in the load's URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBaseURIAttribute();
		
		/// <summary>
        /// Used for srcdoc loads to give view-source knowledge of the load's base
        /// URI as this information isn't embedded in the load's URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
	}
	
	/// <summary>nsIDocShellLoadInfoConsts </summary>
	public class nsIDocShellLoadInfoConsts
	{
		
		// <summary>
        //these are load type enums... </summary>
		public const long loadNormal = 0;
		
		// <summary>
        // Normal Load
        // </summary>
		public const long loadNormalReplace = 1;
		
		// <summary>
        // Normal Load but replaces current history slot
        // </summary>
		public const long loadHistory = 2;
		
		// <summary>
        // Load from history
        // </summary>
		public const long loadReloadNormal = 3;
		
		// <summary>
        // Reload
        // </summary>
		public const long loadReloadBypassCache = 4;
		
		// 
		public const long loadReloadBypassProxy = 5;
		
		// 
		public const long loadReloadBypassProxyAndCache = 6;
		
		// 
		public const long loadLink = 7;
		
		// 
		public const long loadRefresh = 8;
		
		// 
		public const long loadReloadCharsetChange = 9;
		
		// 
		public const long loadBypassHistory = 10;
		
		// 
		public const long loadStopContent = 11;
		
		// 
		public const long loadStopContentAndReplace = 12;
		
		// 
		public const long loadNormalExternal = 13;
		
		// 
		public const long loadNormalBypassCache = 14;
		
		// 
		public const long loadNormalBypassProxy = 15;
		
		// 
		public const long loadNormalBypassProxyAndCache = 16;
		
		// 
		public const long loadPushState = 17;
		
		// <summary>
        // history.pushState or replaceState
        // </summary>
		public const long loadReplaceBypassCache = 18;
		
		// 
		public const long loadReloadMixedContent = 19;
		
		// 
		public const long loadNormalAllowMixedContent = 20;
	}
}
