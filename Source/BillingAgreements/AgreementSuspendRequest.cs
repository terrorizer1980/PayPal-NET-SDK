// This class was generated on Wed, 13 Dec 2017 14:33:02 CST by version 0.1 of Braintree SDK Generator
// AgreementSuspendRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6STQW8TMRCF7/wKa86mWxAn36IG1B6ggURcUFVN1pOs0cY2M7OIVZT/jozTJE0QCHHcp2fP9/aNt/ABNwQOcM1EG4p6JYNkih4sTElaDllDiuBgXnUxaJah70Ncm8Mha5ajuZtegYWPA/E4Q8YNKbGA+/Jg4ZbQE5+r7xJvzrUZavdM28JizIVQlENcg4XPyAGXPZ2TP4ZL6EVH5m5q0spoR0deo8nscxbmCTOOdcy1hU+E/j72I7gV9kJF+DYEJg9OeSALM06ZWAMJuDj0/e6heki0XnJgnhwGzhWVzBNc4j/lkOJ99Kfe56kmxh+/n8K1A3OZ9Ov0ReJ/irkXTnP+vYeYlH77/5lQUjSrxGclVNK2w7im/+WrPeyKS3KKQvWeIlu4SVEp7ssBzLkPLRbC5qukCBZuVfN70i55cDC7ny+gbiI4aL6/ajKOBVia/eK/PGSQZnu6f7vm+Hre/sjUKvnS/CA3yRO419dvdi9+AgAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// Suspends a billing agreement, by ID.
    /// </summary>
    public class AgreementSuspendRequest : HttpRequest
    {
        public AgreementSuspendRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/suspend?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public AgreementSuspendRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor) 
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
