using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.Webhooks.Test
{
    [Collection("Webhooks")]
    public class WebhooksDeleteTest
    {
        public static async Task<HttpResponse> DeleteWebhook(String id) {
            WebhooksDeleteRequest request = new WebhooksDeleteRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebhooksDeleteRequest()
        {
            HttpResponse createResponse = await WebhooksCreateTest.createWebhook();
            var expected = createResponse.Result<Webhook>();

            HttpResponse response = await DeleteWebhook(expected.Id);
            Assert.Equal(204, (int) response.StatusCode);
        }
    }
}
