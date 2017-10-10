using BraintreeHttp;

namespace Paypal.Core
{
    public class PaypalHttpClient : HttpClient
    {
        public PaypalHttpClient(Environment environment) : base(environment) {}

        protected override string GetUserAgent() {
            return "paypal HttpClient";
        }
    }
}
