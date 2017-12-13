using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.Vault.Test
{

    public class CreditCardListTest : TestHarness
    {

        [Fact]
        public async void TestCreditCardListRequest()
        {
            HttpResponse createResponse = await CreditCardCreateTest.createCreditCard();
            CreditCardListRequest request = new CreditCardListRequest();

            HttpResponse response = await client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<CreditCardList>());
        }
    }
}
