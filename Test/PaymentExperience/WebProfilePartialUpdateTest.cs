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

    public class WebProfilePartialUpdateTest : TestHarness
    {
        private List<JsonPatch> buildRequestBody()
        {
            var jsonContent = new StringContent("{}", Encoding.UTF8, "application/json");
            return (List<JsonPatch>) new JsonSerializer().DeserializeResponse(jsonContent, typeof(List<JsonPatch>));
        }

        [Fact]
        public async void TestWebProfilePartialUpdateRequest()
        {
            WebProfilePartialUpdateRequest request = new WebProfilePartialUpdateRequest("OGd4DWyJqzs7R4BW9BC");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 204);

            // Add your own checks here
        }
    }
}
