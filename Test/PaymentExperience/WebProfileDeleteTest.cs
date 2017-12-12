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
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();
            var expected = createResponse.Result<WebProfile>();
            WebProfileDeleteRequest request = new WebProfileDeleteRequest(expected.Id);

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 204);
        }
    }
}
