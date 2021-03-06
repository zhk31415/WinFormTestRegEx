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
// Generated by IDLImporter from file nsITransferable.idl
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
    /// nsIFlavorDataProvider allows a flavor to 'promise' data later,
    /// supplying the data lazily.
    ///
    /// To use it, call setTransferData, passing the flavor string,
    /// a nsIFlavorDataProvider QI'd to nsISupports, and a data size of 0.
    ///
    /// When someone calls getTransferData later, if the data size is
    /// stored as 0, the nsISupports will be QI'd to nsIFlavorDataProvider,
    /// and its getFlavorData called.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7E225E5F-711C-11D7-9FAE-000393636592")]
	public interface nsIFlavorDataProvider
	{
		
		/// <summary>
        /// Retrieve the data from this data provider.
        ///
        /// @param  aTransferable (in parameter) the transferable we're being called for.
        /// @param  aFlavor (in parameter) the flavor of data to retrieve
        /// @param  aData the data. Some variant of class in nsISupportsPrimitives.idl
        /// @param  aDataLen the length of the data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFlavorData([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable, [MarshalAs(UnmanagedType.LPStr)] string aFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aData, ref uint aDataLen);
	}
	
	/// <summary>nsITransferable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("97e0c418-1c1e-4106-bad1-9fcb11dff2fe")]
	public interface nsITransferable
	{
		
		/// <summary>
        /// Initializes a transferable object.  This should be called on all
        /// transferable objects.  Failure to do so will result in fatal assertions in
        /// debug builds.
        ///
        /// The load context is used to track whether the transferable is storing privacy-
        /// sensitive information.  For example, we try to delete data that you copy
        /// to the clipboard when you close a Private Browsing window.
        ///
        /// To get the appropriate load context in Javascript callers, one needs to get
        /// to the document that the transferable corresponds to, and then get the load
        /// context from the document like this:
        ///
        /// var loadContext = doc.defaultView.QueryInterface(Ci.nsIInterfaceRequestor)
        /// .getInterface(Ci.nsIWebNavigation)
        /// .QueryInterface(Ci.nsILoadContext);
        ///
        /// In C++ callers, if you have the corresponding document, you can just call
        /// nsIDocument::GetLoadContext to get to the load context object.
        ///
        /// @param aContext the load context associated with the transferable object.
        /// This can be set to null if a load context is not available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Computes a list of flavors (mime types as nsISupportsCString) that the transferable
        /// can export, either through intrinsic knowledge or output data converters.
        ///
        /// @param  aDataFlavorList fills list with supported flavors. This is a copy of
        /// the internal list, so it may be edited w/out affecting the transferable.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray FlavorsTransferableCanExport();
		
		/// <summary>
        /// Given a flavor retrieve the data.
        ///
        /// @param  aFlavor (in parameter) the flavor of data to retrieve
        /// @param  aData the data. Some variant of class in nsISupportsPrimitives.idl
        /// @param  aDataLen the length of the data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTransferData([MarshalAs(UnmanagedType.LPStr)] string aFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aData, ref uint aDataLen);
		
		/// <summary>
        /// Returns the best flavor in the transferable, given those that have
        /// been added to it with |AddFlavor()|
        ///
        /// @param  aFlavor (out parameter) the flavor of data that was retrieved
        /// @param  aData the data. Some variant of class in nsISupportsPrimitives.idl
        /// @param  aDataLen the length of the data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAnyTransferData([MarshalAs(UnmanagedType.LPStr)] ref string aFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aData, ref uint aDataLen);
		
		/// <summary>
        /// Returns true if the data is large.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsLargeDataSet();
		
		/// <summary>
        /// Computes a list of flavors (mime types as nsISupportsCString) that the transferable can
        /// accept into it, either through intrinsic knowledge or input data converters.
        ///
        /// @param  outFlavorList fills list with supported flavors. This is a copy of
        /// the internal list, so it may be edited w/out affecting the transferable.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray FlavorsTransferableCanImport();
		
		/// <summary>
        /// Sets the data in the transferable with the specified flavor. The transferable
        /// will maintain its own copy the data, so it is not necessary to do that beforehand.
        ///
        /// @param  aFlavor the flavor of data that is being set
        /// @param  aData the data, either some variant of class in nsISupportsPrimitives.idl,
        /// an nsIFile, or an nsIFlavorDataProvider (see above)
        /// @param  aDataLen the length of the data, or 0 if passing a nsIFlavorDataProvider
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTransferData([MarshalAs(UnmanagedType.LPStr)] string aFlavor, [MarshalAs(UnmanagedType.Interface)] nsISupports aData, uint aDataLen);
		
		/// <summary>
        /// Add the data flavor, indicating that this transferable
        /// can receive this type of flavor
        ///
        /// @param  aDataFlavor a new data flavor to handle
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDataFlavor([MarshalAs(UnmanagedType.LPStr)] string aDataFlavor);
		
		/// <summary>
        /// Removes the data flavor matching the given one (string compare) and the data
        /// that goes along with it.
        ///
        /// @param  aDataFlavor a data flavor to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDataFlavor([MarshalAs(UnmanagedType.LPStr)] string aDataFlavor);
		
		/// <summary>Member GetConverterAttribute </summary>
		/// <returns>A nsIFormatConverter</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFormatConverter GetConverterAttribute();
		
		/// <summary>Member SetConverterAttribute </summary>
		/// <param name='aConverter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetConverterAttribute([MarshalAs(UnmanagedType.Interface)] nsIFormatConverter aConverter);
		
		/// <summary>
        /// Use of the SetIsPrivateData() method generated by isPrivateData attribute should
        /// be avoided as much as possible because the value set may not reflect the status
        /// of the context in which the transferable was created.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsPrivateDataAttribute();
		
		/// <summary>
        /// Use of the SetIsPrivateData() method generated by isPrivateData attribute should
        /// be avoided as much as possible because the value set may not reflect the status
        /// of the context in which the transferable was created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsPrivateDataAttribute([MarshalAs(UnmanagedType.U1)] bool aIsPrivateData);
		
		/// <summary>
        /// The source dom node this transferable was created from.
        /// Note, currently only in use on Windows for network principal
        /// information in drag operations.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetRequestingNodeAttribute();
		
		/// <summary>
        /// The source dom node this transferable was created from.
        /// Note, currently only in use on Windows for network principal
        /// information in drag operations.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestingNodeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRequestingNode);
	}
	
	/// <summary>nsITransferableConsts </summary>
	public class nsITransferableConsts
	{
		
		// 
		public const long kFlavorHasDataProvider = 0;
	}
}
