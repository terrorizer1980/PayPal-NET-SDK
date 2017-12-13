// This class was generated on Wed, 13 Dec 2017 14:33:09 CST by version 0.1 of Braintree SDK Generator
// VerifyWebhookSignatureResponse.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOQUtDMQzA8bufouRcxHNvgmeVOeZBRLItbwvWtiapUmTfXep7FFEvHpuSf34fsG6FIMCGhKfm7ml7zPnZ3fEhoVUhtyItOSmBhw0K4zbSNb70FfBwRboTLsY5QYD1kdzb3HlfOjo6snTOwcOlCLb58IWHFeH+JsUGYcKo1AevlYX2Y3AruZAYk0J4GGQ14XT47foi8A676kkNreqf1PnL5clZfw3p9/1/aU3qD2yqMZ4eT2efAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// The verify webhook signature response.
    /// </summary>
    [DataContract]
    public class VerifyWebhookSignatureResponse {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public VerifyWebhookSignatureResponse() {}

        /// <summary>
        /// REQUIRED
        /// The status of the signature verification.
        /// </summary>
        [DataMember(Name="verification_status", EmitDefaultValue = false)]
        public string VerificationStatus { get; set; }
    }
}

