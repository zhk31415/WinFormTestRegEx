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
// Generated by IDLImporter from file nsISimpleEnumerator.idl
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
    /// Used to enumerate over elements defined by its implementor.
    /// Although hasMoreElements() can be called independently of getNext(),
    /// getNext() must be pre-ceeded by a call to hasMoreElements(). There is
    /// no way to "reset" an enumerator, once you obtain one.
    ///
    /// @version 1.0
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D1899240-F9D2-11D2-BDD6-000064657374")]
	public interface nsISimpleEnumerator
	{
		
		/// <summary>
        /// Called to determine whether or not the enumerator has
        /// any elements that can be returned via getNext(). This method
        /// is generally used to determine whether or not to initiate or
        /// continue iteration over the enumerator, though it can be
        /// called without subsequent getNext() calls. Does not affect
        /// internal state of enumerator.
        ///
        /// @see getNext()
        /// @return true if there are remaining elements in the enumerator.
        /// false if there are no more elements in the enumerator.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();
		
		/// <summary>
        /// Called to retrieve the next element in the enumerator. The "next"
        /// element is the first element upon the first call. Must be
        /// pre-ceeded by a call to hasMoreElements() which returns PR_TRUE.
        /// This method is generally called within a loop to iterate over
        /// the elements in the enumerator.
        ///
        /// @see hasMoreElements()
        /// @throws NS_ERROR_FAILURE if there are no more elements
        /// to enumerate.
        /// @return the next element in the enumeration.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetNext();
	}
}
