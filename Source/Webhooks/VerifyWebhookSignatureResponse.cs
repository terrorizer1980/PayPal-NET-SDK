// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// VerifyWebhookSignatureResponse.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOQUtDMQzA8bufouRcxHNvgmeVOeZBRLItbwvWtiapUmTfXep7FFEvHpuSf34fsG6FIMCGhKfm7ml7zPnZ3fEhoVUhtyItOSmBhw0K4zbSNb70FfBwRboTLsY5QYD1kdzb3HlfOjo6snTOwcOlCLb58IWHFeH+JsUGYcKo1AevlYX2Y3AruZAYk0J4GGQ14XT47foi8A676kkNreqf1PnL5clZfw3p9/1/aU3qD2yqMZ4eT2efAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * The verify webhook signature response.
    */
    [DataContract]
    public class VerifyWebhookSignatureResponse {

        // Required default constructor
        public VerifyWebhookSignatureResponse() {}

        /**
        * REQUIRED
        * The status of the signature verification.
        */
        [DataMember(Name="verification_status")]
        public string VerificationStatus { get; set; }
    }
}

