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
    public class WebhooksGetTest
    {

        public static async Task<HttpResponse> getWebhooks(String id) {
            WebhooksGetRequest request = new WebhooksGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebhooksGetRequest()
        {
            HttpResponse createResponse = await WebhooksCreateTest.createWebhook();
            var expected = createResponse.Result<Webhook>();

            HttpResponse response = await getWebhooks(expected.Id);

            Assert.Equal(200, (int) response.StatusCode);
            var webhook = response.Result<Webhook>();
            Assert.NotNull(webhook);
            Assert.Equal(expected.Id, webhook.Id);
            Assert.Equal("PAYMENT.AUTHORIZATION.CREATED", webhook.EventTypes[0].Name);
        }
    }
}
