using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using static PayPal.Test.TestHarness;

namespace PayPal.Orders.Test
{
    [Collection("Orders")]
    public class OrdersPayTest
    {
        private ExecuteOrder buildRequestBody()
        {
            ExecuteOrder executeOrder = new ExecuteOrder()
            {
                DisbursementMode = "INSTANT"
            };
            return executeOrder;
        }

        [Fact]
        public async void TestOrdersPayRequest()
        {
            var orderId = "4V297170UB1090910";
            OrdersPayRequest request = new OrdersPayRequest(orderId);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<PayOrderResponse>());

            PayOrderResponse payOrderResponse = response.Result<PayOrderResponse>();
            Assert.Equal(orderId, payOrderResponse.OrderId);
            Assert.Equal("APPROVED", payOrderResponse.Status);
        }
    }
}
