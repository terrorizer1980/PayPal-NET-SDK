using System;
using System.Text;
using BraintreeHttp;

namespace PayPal.Core
{
    public class PayPalEnvironment : BraintreeHttp.Environment
    {
        private string baseUrl;
        private string clientId;
        private string clientSecret;

        public PayPalEnvironment(string clientId, string clientSecret, string baseUrl)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
			this.baseUrl = baseUrl;
        }

        public string BaseUrl()
        {
            return this.baseUrl;
        }

        public string AuthorizationString()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));
        }
	}

	public class SandboxEnvironment : PayPalEnvironment
	{
		public SandboxEnvironment(string clientId, string clientSecret) : base(clientId, clientSecret, "https://api.sandbox.paypal.com")
		{ }
	}

	public class LiveEnvironment : PayPalEnvironment
	{
		public LiveEnvironment(string clientId, string clientSecret) : base(clientId, clientSecret, "https://api.paypal.com")
		{ }
	}
}
