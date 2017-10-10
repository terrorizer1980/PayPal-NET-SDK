using BraintreeHttp;

namespace Paypal.Core
{
    public class PaypalEnvironment : Environment 
    {
        private string baseUrl;

        public PaypalEnvironment(string baseUrl) 
        {
            this.baseUrl = baseUrl;
        } 

        public string BaseUrl() 
        {
            return this.baseUrl;
        }
    }
}
