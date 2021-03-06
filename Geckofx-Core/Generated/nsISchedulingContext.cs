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
// Generated by IDLImporter from file nsISchedulingContext.idl
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
    /// The nsISchedulingContext is used to maintain state about connections
    /// that are in some way associated with each other (often by being part
    /// of the same load group) and how they interact with blocking items like
    /// HEAD css/js loads.
    ///
    /// This used to be known as nsILoadGroupConnectionInfo.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("658e3e6e-8633-4b1a-8d66-fa9f72293e63")]
	public interface nsISchedulingContext
	{
		
		/// <summary>
        /// A unique identifier for this scheduling context
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIDAttribute();
		
		/// <summary>
        /// Number of active blocking transactions associated with this context
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetBlockingTransactionCountAttribute();
		
		/// <summary>
        /// Increase the number of active blocking transactions associated
        /// with this context by one.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddBlockingTransaction();
		
		/// <summary>
        /// Decrease the number of active blocking transactions associated
        /// with this context by one. The return value is the number of remaining
        /// blockers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint RemoveBlockingTransaction();
		
		/// <summary>
        /// This gives out a weak pointer to the push cache.
        /// The nsISchedulingContext implementation owns the cache
        /// and will destroy it when overwritten or when the context
        /// ends.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSpdyPushCacheAttribute();
		
		/// <summary>
        /// This gives out a weak pointer to the push cache.
        /// The nsISchedulingContext implementation owns the cache
        /// and will destroy it when overwritten or when the context
        /// ends.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpdyPushCacheAttribute(System.IntPtr aSpdyPushCache);
	}
	
	/// <summary>
    /// The nsISchedulingContextService is how anyone gets access to a scheduling
    /// context when they haven't been explicitly given a strong reference to an
    /// existing one. It is responsible for creating and handing out strong
    /// references to nsISchedulingContexts, but only keeps weak references itself.
    /// The shared scheduling context will go away once no one else is keeping a
    /// reference to it. If you ask for a scheduling context that has no one else
    /// holding a reference to it, you'll get a brand new scheduling context. Anyone
    /// who asks for the same scheduling context while you're holding a reference
    /// will get a reference to the same scheduling context you have.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7fcbf4da-d828-4acc-b144-e5435198f727")]
	public interface nsISchedulingContextService
	{
		
		/// <summary>
        /// Get an existing scheduling context from its ID
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISchedulingContext GetSchedulingContext(System.IntPtr id);
		
		/// <summary>
        /// Create a new scheduling context identifier
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr NewSchedulingContextID();
		
		/// <summary>
        /// Remove an existing scheduling context from its ID
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSchedulingContext(System.IntPtr id);
	}
}
