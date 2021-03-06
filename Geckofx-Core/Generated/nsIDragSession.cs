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
// Generated by IDLImporter from file nsIDragSession.idl
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
    ///-*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("25bce737-73f0-43c7-bc20-c71044a73c5a")]
	public interface nsIDragSession
	{
		
		/// <summary>
        /// Set the current state of the drag, whether it can be dropped or not.
        /// usually the target "frame" sets this so the native system can render the correct feedback
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanDropAttribute();
		
		/// <summary>
        /// Set the current state of the drag, whether it can be dropped or not.
        /// usually the target "frame" sets this so the native system can render the correct feedback
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanDropAttribute([MarshalAs(UnmanagedType.U1)] bool aCanDrop);
		
		/// <summary>
        /// Indicates if the drop event should be dispatched only to chrome.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOnlyChromeDropAttribute();
		
		/// <summary>
        /// Indicates if the drop event should be dispatched only to chrome.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnlyChromeDropAttribute([MarshalAs(UnmanagedType.U1)] bool aOnlyChromeDrop);
		
		/// <summary>
        /// Sets the action (copy, move, link, et.c) for the current drag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDragActionAttribute();
		
		/// <summary>
        /// Sets the action (copy, move, link, et.c) for the current drag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDragActionAttribute(uint aDragAction);
		
		/// <summary>
        /// Sets the current width and height of the drag target area.
        /// It will contain the current size of the Frame that the drag is currently in
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTargetSizeAttribute();
		
		/// <summary>
        /// Sets the current width and height of the drag target area.
        /// It will contain the current size of the Frame that the drag is currently in
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetSizeAttribute(uint aTargetSize);
		
		/// <summary>
        /// Get the number of items that were dropped
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumDropItemsAttribute();
		
		/// <summary>
        /// The document where the drag was started, which will be null if the
        /// drag originated outside the application. Useful for determining if a drop
        /// originated in the same document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetSourceDocumentAttribute();
		
		/// <summary>
        /// The dom node that was originally dragged to start the session, which will be null if the
        /// drag originated outside the application.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetSourceNodeAttribute();
		
		/// <summary>
        /// The data transfer object for the current drag.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDataTransfer GetDataTransferAttribute();
		
		/// <summary>
        /// The data transfer object for the current drag.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataTransferAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer aDataTransfer);
		
		/// <summary>
        /// Get data from a Drag&Drop. Can be called while the drag is in process
        /// or after the drop has completed.
        ///
        /// @param  aTransferable the transferable for the data to be put into
        /// @param  aItemIndex which of multiple drag items, zero-based
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetData([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable, uint aItemIndex);
		
		/// <summary>
        /// Check to set if any of the native data on the clipboard matches this data flavor
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDataFlavorSupported([MarshalAs(UnmanagedType.LPStr)] string aDataFlavor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UserCancelled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DragEventDispatchedToChildProcess();
		
		/// <summary>
        /// NS_DRAGDROP_OVER sent from parent process to child process.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateDragEffect();
	}
}
