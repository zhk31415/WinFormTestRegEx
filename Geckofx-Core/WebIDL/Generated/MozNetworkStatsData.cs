namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNetworkStatsData : WebIDLBase
    {
        
        public MozNetworkStatsData(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint RxBytes
        {
            get
            {
                return this.GetProperty<uint>("rxBytes");
            }
        }
        
        public uint TxBytes
        {
            get
            {
                return this.GetProperty<uint>("txBytes");
            }
        }
        
        public IntPtr Date
        {
            get
            {
                return this.GetProperty<IntPtr>("date");
            }
        }
    }
}
