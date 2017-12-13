// This class was generated on Wed, 13 Dec 2017 14:33:00 CST by version 0.1 of Braintree SDK Generator
// AgreementBillBalanceRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6RTwW7TQBC98xWjObtxQZx8Cw2oQaIJJOKCqmrsncSLNrvu7Biwovw7WjtNUxeBUE+Wn2bmvTdvdo83tGMskLbCvGOvk9I6d1GSI18xZjjjWIlt1AaPBb6zzkXQmuFYAZsgQB5O/RmUHcxnE5j7vu7janEDwvctR4UymC4D6yvXGk5toR9MDnxQBq1JwfSEJQ80whSD71l6Vuuc9VugKvUBedPDJ3agXWjTxxuoWhH2VTfBDD+3LN2ShHasLBGLb7cZXjMZljH6IchujC1J6yfYHtddk/YWVazfYoZfSSyVjsf7vLPm2RbXNcN8BmEzEp9c/qxtVYOG3ur5ppONqQh1A/Nlhl+YzMK7DosNucgJuG+tsMFCpeUMlxIaFrUcsfCtc4fboYajDkNONqYnDSslZXjQG+Rv1mKqvTPntU+NTsE8/j/4HXJR6LufLeG/bB6Bc5//jiad2h8jGd3aYy6D0qomv+WX6htyOKSq2AQfeZiT4Ayvglf2x3CQmsbZipLC/HsMHjO8Vm0+sdbBYIHLxWqNw3FigfmP13lDXRIc8+M7uTh5iPn+/CQP+eiZv//VcKVsUvxtvAqGsXhz+fbw6jcAAAD//w==
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
    /// Bills the balance for an agreement, by ID. In the JSON request body, include an optional note that describes the reason for the billing action and the agreement amount and currency.
    /// </summary>
    public class AgreementBillBalanceRequest : HttpRequest
    {
        public AgreementBillBalanceRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/bill-balance?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public AgreementBillBalanceRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor) 
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
