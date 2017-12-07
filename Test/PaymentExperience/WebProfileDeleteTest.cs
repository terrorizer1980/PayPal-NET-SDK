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

    public class WebProfileDeleteTest : TestHarness
    {

        [Fact]
        public async void TestWebProfileDeleteRequest()
        {
            WebProfileDeleteRequest request = new WebProfileDeleteRequest("swFC29zgh7SzwOfgy");

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);

            // Add your own checks here
        }
    }
}
