using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.Vault.Test
{

    public class CreditCardGetTest : TestHarness
    {

        public static async Task<HttpResponse> getCreditCard(String id) {
            CreditCardGetRequest request = new CreditCardGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestCreditCardGetRequest()
        {
            HttpResponse createResponse = await CreditCardCreateTest.createCreditCard();
            var expected = createResponse.Result<CreditCard>();

            HttpResponse response = await getCreditCard(expected.Id);

            Assert.Equal(200, (int) response.StatusCode);
            var CreditCard = response.Result<CreditCard>();
            Assert.NotNull(CreditCard);
            Assert.Equal(CreditCard.Id, expected.Id);
            Assert.Equal(CreditCard.FirstName, expected.FirstName);
            Assert.Equal(CreditCard.LastName, expected.LastName);
            Assert.Equal(CreditCard.BillingAddress.City, expected.BillingAddress.City);
        }
    }
}
