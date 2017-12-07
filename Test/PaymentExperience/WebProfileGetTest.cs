using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.PaymentExperience.Test
{

    public class WebProfileGetTest : TestHarness
    {

        [Fact]
        public async void TestWebProfileGetRequest()
        {
            WebProfileGetRequest request = new WebProfileGetRequest("ud6XZM7KwGVNH");

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<WebProfile>());

            // Add your own checks here
        }
    }
}
