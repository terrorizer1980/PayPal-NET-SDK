// This class was generated on Wed, 13 Dec 2017 14:34:03 CST by version 0.1 of Braintree SDK Generator
// CreditCardDeleteRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2yRTW/iMBCG7/srrDl7CbtH31YkK5D2g7aolwqhIR4aV8Z2xxPUCPHfK5MegPb6aMZ+3neO8A/3BAZaJuvke4tsJ5Y8CYGGmnLLLomLAQzUZ5wVqgP2XsiqcUmVJa22g1rUE9Bw1xMPS2TckxBnME9rDXNCS3xLf0fe37IlSnfFjrAaUnHMwi48g4ZHZIdbT1fum6KxcfaT96ojtahV3Cnp6Ct3JVGNmYv+L2Ycxh+nGu4J7f/gBzA79JkKeO0dkwUj3JOGJcdELI4ymNB7f1qPM5RlfKTAgnKKIdMlm8UgFD7GAFPyrsUiXb3kGEDDXCT9JemiLfU3f5pVA2NBYKA6/KjOYaqL2+XqeN3GCTQ0b4laIfsgKH2eRUtgfk6np2/vAAAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Vault
{
    /// <summary>
    /// Deletes a vaulted credit card, by ID.
    /// </summary>
    public class CreditCardDeleteRequest : HttpRequest
    {
        public CreditCardDeleteRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
