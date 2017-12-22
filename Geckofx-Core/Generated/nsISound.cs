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
// Generated by IDLImporter from file nsISound.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C3C28D92-A17F-43DF-976D-4EEAE6F995FC")]
	public interface nsISound
	{
		
		/// <summary>
        ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        ///
        /// This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Play([MarshalAs(UnmanagedType.Interface)] nsIURL aURL);
		
		/// <summary>
        /// for playing system sounds
        ///
        /// NS_SYSSOUND_* params are obsolete. The new events will not be supported by
        /// this method.  You should use playEventSound method instaed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PlaySystemSound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase soundAlias);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Beep();
		
		/// <summary>
        /// Not strictly necessary, but avoids delay before first sound.
        /// The various methods on nsISound call Init() if they need to.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PlayEventSound(uint aEventId);
	}
	
	/// <summary>nsISoundConsts </summary>
	public class nsISoundConsts
	{
		
		// <summary>
        // In some situations, playEventSound will be called.  Then, each
        // implementations will play a system sound for the event if it's necessary.
        //
        // NOTE: Don't change these values because they are used in
        // nsPIPromptService.idl. So, if they are changed, that makes big impact for
        // the embedders.
        // </summary>
		public const ulong EVENT_NEW_MAIL_RECEIVED = 0;
		
		// 
		public const ulong EVENT_ALERT_DIALOG_OPEN = 1;
		
		// 
		public const ulong EVENT_CONFIRM_DIALOG_OPEN = 2;
		
		// 
		public const ulong EVENT_PROMPT_DIALOG_OPEN = 3;
		
		// 
		public const ulong EVENT_SELECT_DIALOG_OPEN = 4;
		
		// 
		public const ulong EVENT_MENU_EXECUTE = 5;
		
		// 
		public const ulong EVENT_MENU_POPUP = 6;
		
		// 
		public const ulong EVENT_EDITOR_MAX_LEN = 7;
	}
}
