// This class was generated on Wed, 13 Dec 2017 14:33:01 CST by version 0.1 of Braintree SDK Generator
// AgreementReActivateRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6RUQW/aTBC9f79iNGcH56t68g2FVqFSAw2olyoiY++ANzK7zuw4rYX475VZYoipWlW9gPZ5dua9ec/e4R1tGTOkjTBv2elI+IoKtS+kjAlOOBRia7XeYYb3p2cBCEITanaGDeS2qqzbQN8mgbyF6WQEUwdaMnxazO5A+LnhoJB70yZgXVE1hoEcPPb3VkFJeWWOY708gs+fuFD4brWMPwTOK4OWpBALcw6HKcIUvIO1l+Pxla71DsiZA9rPAtr6pvtzBopGhF3RjjDBLw1LOyehLStLwOzbQ4K3TIZliH70sh1ic9LyDbbDZVt3Sw4q1m0wwa8klvKKh8tfWXOx82XJMJ2AXw/Iqz/Txx3vsQi1cdR1gvdMZuaqFrM1VYE74LmxwgYzlYYTnIuvWdRywMw1VbV/iDUcNDbpeY/7oYvOHZj07vxOy9DJC2VjMKfzq8BohMLh9oXqv5J5BM51/tmLLlq/9GCQrZMRkWlRktvwv/KLPuy7qlB7Fzj26eAEb7xTdkdzkOq6ssUh2ulT8A4TvFWtP7OW3mCG89liiTGNmGH68n9aU9sRDunxbb3qNYR0d57Bffr2I/DhR82Fsuncb8KNN4zZu+v3+/9+AgAA//8=
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
    /// Re-activates a suspended billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with with a note that describes the reason for the re-activation and the agreement amount and currency.
    /// </summary>
    public class AgreementReActivateRequest : HttpRequest
    {
        public AgreementReActivateRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/re-activate?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public AgreementReActivateRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor) 
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
