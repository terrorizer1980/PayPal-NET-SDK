using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.Invoices.Test
{
    [Collection("Invoices")]
    public class InvoiceListTest
    {

        [Fact]
        public async void TestInvoiceListRequest()
        {
            HttpResponse createResponse = await InvoiceCreateTest.CreateInvoice();
            InvoiceGetAllRequest request = new InvoiceGetAllRequest();

            HttpResponse listResponse = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) listResponse.StatusCode);
            Assert.NotNull(listResponse.Result<Invoices>());
            var invoices = listResponse.Result<Invoices>();
            Assert.NotNull(invoices.InvoiceList);
            Assert.NotNull(invoices.TotalCount);
        }
    }
}
