using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.PaymentExperience.Test
{

    public class WebProfileGetTest : TestHarness
    {

        public static async Task<HttpResponse> getWebProfile(String id) {
            WebProfileGetRequest request = new WebProfileGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestWebProfileGetRequest()
        {
            HttpResponse createResponse = await WebProfileCreateTest.createWebProfile();
            var expected = createResponse.Result<WebProfile>();

            HttpResponse response = await getWebProfile(expected.Id);

            Assert.Equal((int) response.StatusCode, 200);
            var webProfile = response.Result<WebProfile>();
            Assert.NotNull(webProfile);
            Assert.Equal(webProfile.Id, expected.Id);
            Assert.Equal(webProfile.Name, expected.Name);
            Assert.Equal(webProfile.FlowConfig.LandingPageType, expected.FlowConfig.LandingPageType);
            Assert.Equal(webProfile.Presentation.LogoImage, expected.Presentation.LogoImage);
            Assert.Equal(webProfile.InputFields.AllowNote, expected.InputFields.AllowNote);
        }
    }
}
