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
            var jsonContent = new StringContent("[ { \"op\": \"add\", \"path\": \"/presentation/brand_name\", \"value\": \"new_brand_name\" }, { \"op\": \"remove\", \"path\": \"/flow_config/landing_page_type\" } ]", Encoding.UTF8, "application/json");
            return (List<JsonPatch>) new JsonSerializer().DeserializeResponse(jsonContent, typeof(List<JsonPatch>));
        }

        [Fact]
        public async void TestWebProfilePartialUpdateRequest()
        {
            // Create
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();
            var expected = createResponse.Result<WebProfile>();
            expected.FlowConfig.BankTxnPendingUrl = "https://updated.com";

            // Partial Update
            WebProfilePartialUpdateRequest request = new WebProfilePartialUpdateRequest(expected.Id);
            request.RequestBody(buildRequestBody());
                
            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 204);

            // Get
            HttpResponse getResponse = await WebProfileGetTest.getWebProfile(expected.Id);
            Assert.Equal((int) getResponse.StatusCode, 200);
            var updated = getResponse.Result<WebProfile>();
            Assert.NotNull(updated);
            Assert.Equal(updated.Presentation.BrandName, "new_brand_name");
        }
    }
}
