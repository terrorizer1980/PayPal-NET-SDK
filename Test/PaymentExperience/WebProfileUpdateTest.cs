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

    public class WebProfileUpdateTest : TestHarness
    {
        private WebProfile buildRequestBody()
        {
            var jsonContent = new StringContent("{\"flow_config\":{\"bank_txn_pending_url\":\"BMqyc0PPsIAFd\",\"landing_page_type\":\"pY4tt4WbTUCHtw3P 2\",\"return_uri_http_method\":\"RA0IR4p87z\",\"user_action\":\"IqFyEbbLS5KZ6YvfCia\"},\"id\":\"EQC6fh6iC98bv\",\"input_fields\":{\"address_override\":4,\"allow_note\":true,\"no_shipping\":9},\"name\":\"vF5EBQf1EO5ARvHW1\",\"presentation\":{\"brand_name\":\"qAMDbwr8N0Qe8C94eH\",\"locale_code\":\"GUDVP6OLz5iqP\",\"logo_image\":\"5Apq0Rpdw2Ba\"},\"temporary\":false}", Encoding.UTF8, "application/json");
            return (WebProfile) new JsonSerializer().DeserializeResponse(jsonContent, typeof(WebProfile));
        }

        [Fact]
        public async void TestWebProfileUpdateRequest()
        {
            WebProfileUpdateRequest request = new WebProfileUpdateRequest("utp7S6QOCIM");
            request.RequestBody(buildRequestBody());

            HttpResponse response = await client().Execute(request);
            Assert.Equal((int) response.StatusCode, 204);

            // Add your own checks here
        }
    }
}
