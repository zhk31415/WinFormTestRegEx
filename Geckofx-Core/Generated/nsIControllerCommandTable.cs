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
// Generated by IDLImporter from file nsIControllerCommandTable.idl
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
    /// nsIControllerCommandTable
    ///
    /// An interface via which a controller can maintain a series of commands,
    /// and efficiently dispatch commands to their respective handlers.
    ///
    /// Controllers that use an nsIControllerCommandTable should support
    /// nsIInterfaceRequestor, and be able to return an interface to their
    /// controller command table via getInterface().
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c847f90e-b8f3-49db-a4df-8867831f2800")]
	public interface nsIControllerCommandTable
	{
		
		/// <summary>
        /// Make this command table immutable, so that commands cannot
        /// be registered or unregistered. Some command tables are made
        /// mutable after command registration so that they can be
        /// used as singletons.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MakeImmutable();
		
		/// <summary>
        /// Register and unregister commands with the command table.
        ///
        /// @param aCommandName  the name of the command under which to register or
        /// unregister the given command handler.
        ///
        /// @param aCommand      the handler for this command.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIControllerCommand aCommand);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIControllerCommand aCommand);
		
		/// <summary>
        /// Find the command handler which has been registered to handle the named command.
        ///
        /// @param aCommandName  the name of the command to find the handler for.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIControllerCommand FindCommandHandler([MarshalAs(UnmanagedType.LPStr)] string aCommandName);
		
		/// <summary>
        /// Get whether the named command is enabled.
        ///
        /// @param aCommandName    the name of the command to test
        /// @param aCommandRefCon  the command context data
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);
		
		/// <summary>
        /// Tell the command to update its state (if it is a state updating command)
        ///
        /// @param aCommandName    the name of the command to update
        /// @param aCommandRefCon  the command context data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);
		
		/// <summary>
        /// Get whether the named command is supported.
        ///
        /// @param aCommandName    the name of the command to test
        /// @param aCommandRefCon  the command context data
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SupportsCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);
		
		/// <summary>
        /// Execute the named command.
        ///
        /// @param aCommandName    the name of the command to execute
        /// @param aCommandRefCon  the command context data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommandParams([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParam, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParam, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSupportedCommands(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] commands);
	}
}
