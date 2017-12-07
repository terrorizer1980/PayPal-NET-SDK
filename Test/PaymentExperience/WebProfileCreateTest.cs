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

    public class WebProfileCreateTest : TestHarness
    {
        private WebProfile buildRequestBody()
        {
            var jsonContent = new StringContent("{\"flow_config\":{\"bank_txn_pending_url\":\"Yqza2ZTb7CKS6F\",\"landing_page_type\":\"ft86piXdGt6B\",\"return_uri_http_method\":\"u28QM HpefCJT\",\"user_action\":\"OP7YCU0FIPUOhJQq\"},\"id\":\"xLFdtWXf6Ghix7APOD\",\"input_fields\":{\"address_override\":5,\"allow_note\":false,\"no_shipping\":2},\"name\":\"Zeea1ic08XwM7\",\"presentation\":{\"brand_name\":\"QrBB5F  0Uw\",\"locale_code\":\"w4TdVXdB3z5JC\",\"logo_image\":\"SyB9UTAeVPbh\"},\"temporary\":false}", Encoding.UTF8, "application/json");
            return (WebProfile) new JsonSerializer().DeserializeResponse(jsonContent, typeof(WebProfile));
        }

        [Fact]
        public async void TestWebProfileCreateRequest()
        {
            WebProfileCreateRequest request = new WebProfileCreateRequest();
            request.RequestBody(buildRequestBody());

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 201);
            Assert.NotNull(response.Result<WebProfile>());

            // Add your own checks here
        }
    }
}
