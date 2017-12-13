// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// PlanUpdateRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/3ySQW/TThDF7/9PMZrz/pvCgYNvVQNKkGgDDVxQVU2843qr9e52dlywonx3tLaBkCCuzzOz772f93hDHWOFyVO46JMlZTS45FyLS+piwAo/j3KGxrG3GVwAgp3z3oVHKHsGdgOslxewDqAtw/u72xsQfu45K+yiHQy4UPveMhAk0rqFuHviWkFbUsiJa9c4zuNyTCxUHgaNkFiaKJ2BGBiiQBeFf9rQCJNfAxQsEAT+Bi/ke4YmCjDV7Txgp5ULNPixZxk2JNSxsmSsvt4bXDFZllP1XZTuVNuQtn9oe9wOqfSXVVx4RINfSBztPB/1+uDsWafblmG9hNiMoY/b/B2sGL4SoWF649LgJyZ7G/yAVUM+cxGeeydssVLp2eBGSn/qOGMVeu8P99MMZ52O/DI8QtoUGH8xXeSHmeCZ9asAVFwV8+OVY6QjF0rJD5BI1JGfw4wfhHPspeZ8Eu3NP6PNwlm2MpNTDJmnK0U0eB2DcpjjYrHi6vGHWjzlGNDgSjV9YG2jxQo3V9vrFU5kscLFy6tFoqHjoHkxU/m/UMmL/YzygAbffk9cK9s7Je3zdbSM1evLy8N/PwAAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// Updates fields in a billing plan, by ID. In the JSON request body, include a patch object that specifies the operation to perform, one or more fields to update, and a new value for each updated field.
    /// </summary>
    public class PlanUpdateRequest : HttpRequest
    {
        public PlanUpdateRequest(string PlanId) : base("/v1/payments/billing-plans/{plan_id}?", new HttpMethod("PATCH"), typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(PlanId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public PlanUpdateRequest RequestBody(List<JsonPatch> PatchRequest) 
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
