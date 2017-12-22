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
// Generated by IDLImporter from file nsIWebBrowserChrome.idl
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
    /// nsIWebBrowserChrome corresponds to the top-level, outermost window
    /// containing an embedded Gecko web browser.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E8C414C4-DC38-4BA3-AB4E-EC4CBBE22907")]
	public interface nsIWebBrowserChrome
	{
		
		/// <summary>
        /// Called when the status text in the chrome needs to be updated.
        /// @param statusType indicates what is setting the text
        /// @param status status string. null is an acceptable value meaning
        /// no status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatus(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string status);
		
		/// <summary>
        /// The currently loaded WebBrowser.  The browser chrome may be
        /// told to set the WebBrowser object to a new object by setting this
        /// attribute.  In this case the implementer is responsible for taking the
        /// new WebBrowser object and doing any necessary initialization or setup
        /// as if it had created the WebBrowser itself.  This includes positioning
        /// setting up listeners etc.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowser GetWebBrowserAttribute();
		
		/// <summary>
        /// The currently loaded WebBrowser.  The browser chrome may be
        /// told to set the WebBrowser object to a new object by setting this
        /// attribute.  In this case the implementer is responsible for taking the
        /// new WebBrowser object and doing any necessary initialization or setup
        /// as if it had created the WebBrowser itself.  This includes positioning
        /// setting up listeners etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWebBrowserAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser aWebBrowser);
		
		/// <summary>
        /// The chrome flags for this browser chrome. The implementation should
        /// reflect the value of this attribute by hiding or showing its chrome
        /// appropriately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetChromeFlagsAttribute();
		
		/// <summary>
        /// The chrome flags for this browser chrome. The implementation should
        /// reflect the value of this attribute by hiding or showing its chrome
        /// appropriately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeFlagsAttribute(uint aChromeFlags);
		
		/// <summary>
        /// Asks the implementer to destroy the window associated with this
        /// WebBrowser object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyBrowserWindow();
		
		/// <summary>
        /// Tells the chrome to size itself such that the browser will be the
        /// specified size.
        /// @param aCX new width of the browser
        /// @param aCY new height of the browser
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeBrowserTo(int aCX, int aCY);
		
		/// <summary>
        /// Shows the window as a modal window.
        /// @return (the function error code) the status value specified by
        /// in exitModalEventLoop.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAsModal();
		
		/// <summary>
        /// Is the window modal (that is, currently executing a modal loop)?
        /// @return true if it's a modal window
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWindowModal();
		
		/// <summary>
        /// Exit a modal event loop if we're in one. The implementation
        /// should also exit out of the loop if the window is destroyed.
        /// @param aStatus - the result code to return from showAsModal
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitModalEventLoop(int aStatus);
	}
	
	/// <summary>nsIWebBrowserChromeConsts </summary>
	public class nsIWebBrowserChromeConsts
	{
		
		// <summary>
        // nsIWebBrowserChrome corresponds to the top-level, outermost window
        // containing an embedded Gecko web browser.
        // </summary>
		public const ulong STATUS_SCRIPT = 0x00000001;
		
		// 
		public const ulong STATUS_LINK = 0x00000003;
		
		// <summary>
        // Definitions for the chrome flags
        // </summary>
		public const ulong CHROME_DEFAULT = 0x00000001;
		
		// 
		public const ulong CHROME_WINDOW_BORDERS = 0x00000002;
		
		// 
		public const ulong CHROME_WINDOW_CLOSE = 0x00000004;
		
		// 
		public const ulong CHROME_WINDOW_RESIZE = 0x00000008;
		
		// 
		public const ulong CHROME_MENUBAR = 0x00000010;
		
		// 
		public const ulong CHROME_TOOLBAR = 0x00000020;
		
		// 
		public const ulong CHROME_LOCATIONBAR = 0x00000040;
		
		// 
		public const ulong CHROME_STATUSBAR = 0x00000080;
		
		// 
		public const ulong CHROME_PERSONAL_TOOLBAR = 0x00000100;
		
		// 
		public const ulong CHROME_SCROLLBARS = 0x00000200;
		
		// 
		public const ulong CHROME_TITLEBAR = 0x00000400;
		
		// 
		public const ulong CHROME_EXTRA = 0x00000800;
		
		// <summary>
        // createBrowserWindow specific flags
        // </summary>
		public const ulong CHROME_WITH_SIZE = 0x00001000;
		
		// 
		public const ulong CHROME_WITH_POSITION = 0x00002000;
		
		// <summary>
        // special cases
        // </summary>
		public const ulong CHROME_WINDOW_MIN = 0x00004000;
		
		// 
		public const ulong CHROME_WINDOW_POPUP = 0x00008000;
		
		// <summary>
        // docshells.
        // </summary>
		public const ulong CHROME_PRIVATE_WINDOW = 0x00010000;
		
		// 
		public const ulong CHROME_NON_PRIVATE_WINDOW = 0x00020000;
		
		// 
		public const ulong CHROME_PRIVATE_LIFETIME = 0x00040000;
		
		// <summary>
        // Whether this was opened by nsGlobalWindow::ShowModalDialog.
        // </summary>
		public const ulong CHROME_MODAL_CONTENT_WINDOW = 0x00080000;
		
		// <summary>
        // Whether this window should use remote (out-of-process) tabs.
        // </summary>
		public const ulong CHROME_REMOTE_WINDOW = 0x00100000;
		
		// <summary>
        // platforms.
        // </summary>
		public const ulong CHROME_MAC_SUPPRESS_ANIMATION = 0x01000000;
		
		// 
		public const ulong CHROME_WINDOW_RAISED = 0x02000000;
		
		// 
		public const ulong CHROME_WINDOW_LOWERED = 0x04000000;
		
		// 
		public const ulong CHROME_CENTER_SCREEN = 0x08000000;
		
		// <summary>
        // dependent.
        // </summary>
		public const ulong CHROME_DEPENDENT = 0x10000000;
		
		// <summary>
        //       mean it's actually modal.
        // </summary>
		public const ulong CHROME_MODAL = 0x20000000;
		
		// 
		public const ulong CHROME_OPENAS_DIALOG = 0x40000000;
		
		// 
		public const ulong CHROME_OPENAS_CHROME = 0x80000000;
		
		// 
		public const ulong CHROME_ALL = 0x00000ffe;
	}
}
