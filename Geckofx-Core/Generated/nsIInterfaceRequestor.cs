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
// Generated by IDLImporter from file nsIInterfaceRequestor.idl
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
    /// The nsIInterfaceRequestor interface defines a generic interface for
    /// requesting interfaces that a given object might provide access to.
    /// This is very similar to QueryInterface found in nsISupports.
    /// The main difference is that interfaces returned from GetInterface()
    /// are not required to provide a way back to the object implementing this
    /// interface.  The semantics of QI() dictate that given an interface A that
    /// you QI() on to get to interface B, you must be able to QI on B to get back
    /// to A.  This interface however allows you to obtain an interface C from A
    /// that may or most likely will not have the ability to get back to A.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("033A1470-8B2A-11d3-AF88-00A024FFC08C")]
	public interface nsIInterfaceRequestor
	{
		
		/// <summary>
        /// Retrieves the specified interface pointer.
        ///
        /// @param uuid The IID of the interface being requested.
        /// @param result [out] The interface pointer to be filled in if
        /// the interface is accessible.
        /// @throws NS_NOINTERFACE - interface not accessible.
        /// @throws NS_ERROR* - method failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetInterface(ref System.Guid uuid);
	}
}
