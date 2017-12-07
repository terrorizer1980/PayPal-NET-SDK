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

    public class WebProfileGetListTest : TestHarness
    {

        [Fact]
        public async void TestWebProfileGetListRequest()
        {
            WebProfileGetListRequest request = new WebProfileGetListRequest();

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<List<WebProfile>>());

            // Add your own checks here
        }
    }
}
