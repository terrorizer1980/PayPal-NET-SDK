using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceRemindTest
    {

        public static async Task<HttpResponse> RemindInvoice(String id) {
            InvoiceRemindRequest request = new InvoiceRemindRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestInvoiceRemindRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            var expected = createResponse.Result<Invoice>();

            HttpResponse sendResponse = await InvoiceSendTest.SendInvoice(expected.Id);
            Assert.Equal(202, (int) sendResponse.StatusCode);

            HttpResponse remindResponse = await RemindInvoice(expected.Id);
            Assert.Equal(202, (int) remindResponse.StatusCode);
        }
    }
}
