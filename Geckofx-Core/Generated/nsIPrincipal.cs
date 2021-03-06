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
// Generated by IDLImporter from file nsIPrincipal.idl
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
    ///Defines the abstract interface for a principal. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("188fc4a2-3157-4956-a7a2-d674991770da")]
	public interface nsIPrincipal : nsISerializable
	{
		
		/// <summary>
        /// Initialize the object implementing nsISerializable, which must have
        /// been freshly constructed via CreateInstance.  All data members that
        /// can't be set to default values must have been serialized by write,
        /// and should be read from aInputStream in the same order by this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);
		
		/// <summary>
        /// Serialize the object implementing nsISerializable to aOutputStream, by
        /// writing each data member that must be recovered later to reconstitute
        /// a working replica of this object, in a canonical member and byte order,
        /// to aOutputStream.
        ///
        /// NB: a class that implements nsISerializable *must* also implement
        /// nsIClassInfo, in particular nsIClassInfo::GetClassID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);
		
		/// <summary>
        /// Returns whether the other principal is equivalent to this principal.
        /// Principals are considered equal if they are the same principal, or
        /// they have the same origin.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Like equals, but takes document.domain changes into account.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EqualsConsideringDomain([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Returns a hash value for the principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHashValueAttribute();
		
		/// <summary>
        /// The codebase URI to which this principal pertains.  This is
        /// generally the document URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// The domain URI to which this principal pertains.
        /// This is null unless script successfully sets document.domain to our URI
        /// or a superdomain of our URI.
        /// Setting this has no effect on the URI.
        /// See https://developer.mozilla.org/en-US/docs/Web/Security/Same-origin_policy#Changing_origin
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetDomainAttribute();
		
		/// <summary>
        /// The domain URI to which this principal pertains.
        /// This is null unless script successfully sets document.domain to our URI
        /// or a superdomain of our URI.
        /// Setting this has no effect on the URI.
        /// See https://developer.mozilla.org/en-US/docs/Web/Security/Same-origin_policy#Changing_origin
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDomainAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);
		
		/// <summary>
        /// Returns whether the other principal is equal to or weaker than this
        /// principal. Principals are equal if they are the same object or they
        /// have the same origin.
        ///
        /// Thus a principal always subsumes itself.
        ///
        /// The system principal subsumes itself and all other principals.
        ///
        /// A null principal (corresponding to an unknown, hence assumed minimally
        /// privileged, security context) is not equal to any other principal
        /// (including other null principals), and therefore does not subsume
        /// anything but itself.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Subsumes([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Same as the previous method, subsumes(), but takes document.domain into
        /// account.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SubsumesConsideringDomain([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Checks whether this principal is allowed to load the network resource
        /// located at the given URI under the same-origin policy. This means that
        /// codebase principals are only allowed to load resources from the same
        /// domain, the system principal is allowed to load anything, and null
        /// principals can only load URIs where they are the principal. This is
        /// changed by the optional flag allowIfInheritsPrincipal (which defaults to
        /// false) which allows URIs that inherit their loader's principal.
        ///
        /// If the load is allowed this function does nothing. If the load is not
        /// allowed the function throws NS_ERROR_DOM_BAD_URI.
        ///
        /// NOTE: Other policies might override this, such as the Access-Control
        /// specification.
        /// NOTE: The 'domain' attribute has no effect on the behaviour of this
        /// function.
        ///
        ///
        /// @param uri    The URI about to be loaded.
        /// @param report If true, will report a warning to the console service
        /// if the load is not allowed.
        /// @param allowIfInheritsPrincipal   If true, the load is allowed if the
        /// loadee inherits the principal of the
        /// loader.
        /// @throws NS_ERROR_DOM_BAD_URI if the load is not allowed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckMayLoad([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.U1)] bool report, [MarshalAs(UnmanagedType.U1)] bool allowIfInheritsPrincipal);
		
		/// <summary>
        /// A Content Security Policy associated with this principal.
        ///
        /// Please note that if a csp was already set on the
        /// principal, then it should not be destroyed! Instead, the
        /// current csp should be quried and extended by
        /// calling AppendPolicy() on it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetCspAttribute();
		
		/// <summary>
        /// A Content Security Policy associated with this principal.
        ///
        /// Please note that if a csp was already set on the
        /// principal, then it should not be destroyed! Instead, the
        /// current csp should be quried and extended by
        /// calling AppendPolicy() on it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCspAttribute(System.IntPtr aCsp);
		
		/// <summary>
        /// A speculative Content Security Policy associated with this
        /// principal. Set during speculative loading (preloading) and
        /// used *only* for preloads.
        ///
        /// If you want to query the CSP associated with that principal,
        /// then this is *not* what you want. Instead query 'csp'.
        ///
        /// Please note that if a preloadCSP was already set on the
        /// principal, then it should not be destroyed! Instead, the
        /// current preloadCSP should be quried and extended by
        /// calling AppendPolicy() on it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPreloadCspAttribute();
		
		/// <summary>
        /// A speculative Content Security Policy associated with this
        /// principal. Set during speculative loading (preloading) and
        /// used *only* for preloads.
        ///
        /// If you want to query the CSP associated with that principal,
        /// then this is *not* what you want. Instead query 'csp'.
        ///
        /// Please note that if a preloadCSP was already set on the
        /// principal, then it should not be destroyed! Instead, the
        /// current preloadCSP should be quried and extended by
        /// calling AppendPolicy() on it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreloadCspAttribute(System.IntPtr aPreloadCsp);
		
		/// <summary>
        /// The CSP of the principal in JSON notation.
        /// Note, that the CSP itself is not exposed to JS, but script
        /// should be able to obtain a JSON representation of the CSP.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCspJSONAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCspJSON);
		
		/// <summary>
        /// Returns the jar prefix of the principal.
        /// The jar prefix is a string that can be used to isolate data or
        /// permissions between different principals while taking into account
        /// parameters like the app id or the fact that the principal is embedded in
        /// a mozbrowser.
        /// Some principals will return an empty string.
        /// Some principals will assert if you try to access the jarPrefix.
        ///
        /// The jarPrefix is intended to be an opaque identifier. It is currently
        /// "human-readable" but no callers should assume it will stay as is and
        /// it might be crypto-hashed at some point.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetJarPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aJarPrefix);
		
		/// <summary>
        /// A dictionary of the non-default origin attributes associated with this
        /// nsIPrincipal.
        ///
        /// Attributes are tokens that are taken into account when determining whether
        /// two principals are same-origin - if any attributes differ, the principals
        /// are cross-origin, even if the scheme, host, and port are the same.
        /// Attributes should also be considered for all security and bucketing decisions,
        /// even those which make non-standard comparisons (like cookies, which ignore
        /// scheme, or quotas, which ignore subdomains).
        ///
        /// If you're looking for an easy-to-use canonical stringification of the origin
        /// attributes, see |originSuffix| below.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOriginAttributesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// A canonical representation of the origin for this principal. This
        /// consists of a base string (which, for codebase principals, is of the
        /// format scheme://host:port), concatenated with |originAttributes| (see
        /// below).
        ///
        /// We maintain the invariant that principalA.equals(principalB) if and only
        /// if principalA.origin == principalB.origin.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOrigin);
		
		/// <summary>
        /// The base part of |origin| without the concatenation with |originSuffix|.
        /// This doesn't have the important invariants described above with |origin|,
        /// and as such should only be used for legacy situations.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginNoSuffixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginNoSuffix);
		
		/// <summary>
        /// A string of the form !key1=value1&key2=value2, where each pair represents
        /// an attribute with a non-default value. If all attributes have default
        /// values, this is the empty string.
        ///
        /// The value of .originSuffix is automatically serialized into .origin, so any
        /// consumers using that are automatically origin-attribute-aware. Consumers with
        /// special requirements must inspect and compare .originSuffix manually.
        ///
        /// originsuffix are intended to be a replacement for jarPrefix, which will
        /// eventually be removed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginSuffixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aOriginSuffix);
		
		/// <summary>
        /// The base domain of the codebase URI to which this principal pertains
        /// (generally the document URI), handling null principals and
        /// non-hierarchical schemes correctly.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBaseDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aBaseDomain);
		
		/// <summary>
        /// Gets the principal's app status, which indicates whether the principal
        /// corresponds to "app code", and if it does, how privileged that code is.
        /// This method returns one of the APP_STATUS constants above.
        ///
        /// Note that a principal may have
        ///
        /// appId != nsIScriptSecurityManager::NO_APP_ID &&
        /// appId != nsIScriptSecurityManager::UNKNOWN_APP_ID
        ///
        /// and still have appStatus == APP_STATUS_NOT_INSTALLED.  That's because
        /// appId identifies the app that contains this principal, but a window
        /// might be contained in an app and not be running code that the app has
        /// vouched for.  For example, the window might be inside an <iframe
        /// mozbrowser>, or the window's origin might not match the app's origin.
        ///
        /// If you're doing a check to determine "does this principal correspond to
        /// app code?", you must check appStatus; checking appId != NO_APP_ID is not
        /// sufficient.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetAppStatusAttribute();
		
		/// <summary>
        /// Gets the id of the app this principal is inside.  If this principal is
        /// not inside an app, returns nsIScriptSecurityManager::NO_APP_ID.
        ///
        /// Note that this principal does not necessarily have the permissions of
        /// the app identified by appId.  For example, this principal might
        /// correspond to an iframe whose origin differs from that of the app frame
        /// containing it.  In this case, the iframe will have the appId of its
        /// containing app frame, but the iframe must not run with the app's
        /// permissions.
        ///
        /// Similarly, this principal might correspond to an <iframe mozbrowser>
        /// inside an app frame; in this case, the content inside the iframe should
        /// not have any of the app's permissions, even if the iframe is at the same
        /// origin as the app.
        ///
        /// If you're doing a security check based on appId, you must check
        /// appStatus as well.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAppIdAttribute();
		
		/// <summary>
        /// Gets the id of the user context this principal is inside.  If this
        /// principal is inside the default userContext, this returns
        /// nsIScriptSecurityManager::DEFAULT_USER_CONTEXT_ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetUserContextIdAttribute();
		
		/// <summary>
        /// Returns true iff the principal is inside a browser element.  (<iframe
        /// mozbrowser mozapp> does not count as a browser element.)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInBrowserElementAttribute();
		
		/// <summary>
        /// Returns true if this principal has an unknown appId. This shouldn't
        /// generally be used. We only expose it due to not providing the correct
        /// appId everywhere where we construct principals.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUnknownAppIdAttribute();
		
		/// <summary>
        /// Returns true iff this is a null principal (corresponding to an
        /// unknown, hence assumed minimally privileged, security context).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsNullPrincipalAttribute();
		
		/// <summary>
        /// Returns true iff this principal corresponds to a codebase origin.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCodebasePrincipalAttribute();
		
		/// <summary>
        /// Returns true iff this is an expanded principal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsExpandedPrincipalAttribute();
		
		/// <summary>
        /// Returns true iff this is the system principal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSystemPrincipalAttribute();
		
		/// <summary>
        /// Returns true if this principal's origin is recognized as being on the
        /// whitelist of sites that can use the CSS Unprefixing Service.
        ///
        /// (This interface provides a trivial implementation, just returning false;
        /// subclasses can implement something more complex as-needed.)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsOnCSSUnprefixingWhitelist();
	}
	
	/// <summary>nsIPrincipalConsts </summary>
	public class nsIPrincipalConsts
	{
		
		// 
		public const short APP_STATUS_NOT_INSTALLED = 0;
		
		// 
		public const short APP_STATUS_INSTALLED = 1;
		
		// 
		public const short APP_STATUS_PRIVILEGED = 2;
		
		// 
		public const short APP_STATUS_CERTIFIED = 3;
	}
	
	/// <summary>
    /// If nsSystemPrincipal is too risky to use, but we want a principal to access
    /// more than one origin, nsExpandedPrincipals letting us define an array of
    /// principals it subsumes. So script with an nsExpandedPrincipals will gain
    /// same origin access when at least one of its principals it contains gained
    /// sameorigin acccess. An nsExpandedPrincipal will be subsumed by the system
    /// principal, and by another nsExpandedPrincipal that has all its principals.
    /// It is added for jetpack content-scripts to let them interact with the
    /// content and a well defined set of other domains, without the risk of
    /// leaking out a system principal to the content. See: Bug 734891
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f3e177Df-6a5e-489f-80a7-2dd1481471d8")]
	public interface nsIExpandedPrincipal
	{
		
		/// <summary>
        /// An array of principals that the expanded principal subsumes.
        /// Note: this list is not reference counted, it is shared, so
        /// should not be changed and should only be used ephemerally.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetWhiteListAttribute();
	}
}
