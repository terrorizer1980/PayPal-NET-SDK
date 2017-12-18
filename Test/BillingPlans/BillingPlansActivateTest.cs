using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.BillingPlans.Test
{
    [Collection("Billing Plan")]
    public class PlanActivateTest
    {
        private List<JsonPatch<Plan>> buildRequestBody()
        {
            var updates = new Plan() {
                State = "ACTIVE"
            };
            var patch = new JsonPatch<Plan>() 
            {
                Op = "replace",
                Path = "/",
                Value = updates
            };
            return new List<JsonPatch<Plan>>() { patch };
        }

        [Fact]
        public async void TestPlanActivate()
        {
            // Create
            HttpResponse createResponse = await PlanCreateTest.createPlan();
            var expected = createResponse.Result<Plan>();

            //  Update
            PlanUpdateRequest<Plan> request = new PlanUpdateRequest<Plan>(expected.Id);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);

            // Get
            HttpResponse getResponse = await PlanGetTest.getPlan(expected.Id);
            Assert.Equal(200, (int) getResponse.StatusCode);
            var updated = getResponse.Result<Plan>();
            Assert.NotNull(updated);
            Assert.Equal("ACTIVE", updated.State);
        }
    }
}
