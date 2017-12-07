using System;
using PayPal.Core;
using BraintreeHttp;

namespace PayPal.Test
{
    public class TestHarness
    {
        private class TestEnvironment: SandboxEnvironment
        {
            public TestEnvironment(): base("clientid", "clientsecret") {}

            public string BaseUrl()
            {
                return System.Environment.GetEnvironmentVariable("BASE_URL");
            }
        }

        protected HttpClient client()
        {
            return new PayPalHttpClient(new TestEnvironment());
        }
    }
}