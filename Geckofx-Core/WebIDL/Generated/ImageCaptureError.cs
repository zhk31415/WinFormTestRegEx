namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageCaptureError : WebIDLBase
    {
        
        public ImageCaptureError(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort Code
        {
            get
            {
                return this.GetProperty<ushort>("code");
            }
        }
        
        public string Message
        {
            get
            {
                return this.GetProperty<string>("message");
            }
        }
    }
}
