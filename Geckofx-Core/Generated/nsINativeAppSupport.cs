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
// Generated by IDLImporter from file nsINativeAppSupport.idl
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
    ///nsINativeAppSupport
    ///
    /// This "pseudo" (in the XPCOM sense) interface provides for
    /// platform-specific general application support:
    /// o It manages the details of the simple DDE communication
    /// supported on the Win32 platform (it is the addition of this
    /// item that prompted the creation of this interface.
    ///
    /// Due to the nature of the beast, this interface is not a full-blown
    /// XPCOM component.  The primary reason is that objects that implement
    /// this interface generally must be operational *before* XPCOM (or any
    /// of the rest of Mozilla) are initialized.  As a result, this
    /// interface is instantiated by somewhat unconventional means.
    ///
    /// To create the implementor of this interface, you call the function
    /// NS_CreateNativeAppSupport.  This is done in the startup code
    /// in nsAppRunner.cpp
    ///
    /// The interface provides these functions:
    /// start - You call this to inform the native app support that the
    /// application is starting.  In addition, it serves as a
    /// query as to whether the application should continue to
    /// run.
    ///
    /// If the returned boolean result is PR_FALSE, then the
    /// application should exit without further processing.  In
    /// such cases, the returned nsresult indicates whether the
    /// reason to exit is due to an error or not.
    ///
    /// Win32 Note: In the case of starting a second instance
    /// of this executable, this function will return
    /// PR_FALSE and nsresult==NS_OK.  This means that
    /// the command line arguments have been
    /// successfully passed to the instance of the
    /// application acting as a DDE server.
    ///
    /// stop - You call this to inform the native app support that the
    /// application *wishes* to terminate.  If the returned boolean
    /// value is PR_FALSE, then the application should continue
    /// (as if there were still additional top-level windows open).
    ///
    /// Win32 Note: If this is the instance of the application
    /// acting as the DDE server, and there are current
    /// DDE conversations active with other instances
    /// acting as DDE clients, then this function will
    /// return PR_FALSE.
    ///
    /// quit - Like Stop, but this method *forces* termination (or more
    /// precisely, indicates that the application is about to be
    /// terminated regardless of what a call to Stop might have
    /// returned.
    ///
    /// This method is intended to be called when the user selects
    /// the "Quit" option (close all windows and exit).
    ///
    /// Win32 Note: Stop is problematic in the case of "Quit" (close
    /// all windows and exit the application) because
    /// either we don't Quit or (potentially) we lose
    /// requests coming from other instances of the
    /// application.  The strategy is to give preference
    /// to the user's explicit Quit request.  In the
    /// unlikely event that a request is pending from
    /// another instance of the application, then such
    /// requests are essentially ignored.  This is
    /// roughly equivalent to handling that request by
    /// opening a new window, followed by immediately
    /// closing it.  Since this is the same as if the
    /// request came in immediately before the Quit
    /// call (versus immediately after it), no harm.
    ///
    /// There is an exposure here: Upon return from this
    /// function, any DDE connect request (for Mozilla)
    /// will fail and other instances of the application
    /// will start up as a DDE server.  In that case,
    /// those instances may do things that conflict with
    /// the subsequent shutting down of the instance that
    /// is quitting.  For this reason, the call to Quit
    /// should be deferred as long as possible.
    ///
    /// onLastWindowClosing -  Called when the last window is closed. Used as a
    /// "soft" shutdown, passwords are flushed.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5fdf8480-1f98-11d4-8077-00600811a9c3")]
	public interface nsINativeAppSupport
	{
		
		/// <summary>
        /// Startup/shutdown.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Start();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Enable();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Stop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Quit();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnLastWindowClosing();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReOpen();
	}
}
