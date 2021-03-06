namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIdentityProviderRegistrar : WebIDLBase
    {
        
        public RTCIdentityProviderRegistrar(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Idp
        {
            get
            {
                return this.GetProperty<nsISupports>("idp");
            }
        }
        
        public void Register(nsISupports idp)
        {
            this.CallVoidMethod("register", idp);
        }
        
        public Promise <object> GenerateAssertion(string contents, string origin)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin);
        }
        
        public Promise <object> GenerateAssertion(string contents, string origin, string usernameHint)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin, usernameHint);
        }
        
        public Promise <object> ValidateAssertion(string assertion, string origin)
        {
            return this.CallMethod<Promise <object>>("validateAssertion", assertion, origin);
        }
    }
}
