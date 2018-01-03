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
    public class WebhooksGetAllTest
    {

        public static async Task<HttpResponse>  GetAllWebhooks()
        {
            WebhooksGetAllRequest request = new WebhooksGetAllRequest();
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebhooksGetAllRequest()
        {
            HttpResponse createResponse = await WebhooksCreateTest.createWebhook();
            var response = await GetAllWebhooks();
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<WebhookList>());
        }
    }
}
