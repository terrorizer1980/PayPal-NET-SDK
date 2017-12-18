// This class was generated on Wed, 13 Dec 2017 14:31:23 CST by version 0.1 of Braintree SDK Generator
// WebProfilePartialUpdateRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/3yTQW/aQBCF7/0VozkvkFZVD74haAWVmtAG9VJF0dge6o2W3c3sOMRC/PdqsWlSqHJDj9Hb970Z7/GatowF7rgcRQkb63gcSdSSG7WxJmU0OOdUiY1qg8cCV/3frhsGEhDsuAR+jiyWfcUwOBkoO1jOx7D0oA3D19ubaxB+bDkplKHuDKTIld10QBBJqwZC+cCVmuN4JG0gbPrfvSO4UFHOARqgf94A+RoIPO/giVzLYzT4vWXpViS0ZWVJWPy6M7hgqlnO1S9BtufairT5R9vjuou5p6Ri/W80+JPEUul46G/Id2/ri77WDcNyfg6iAeKpyIEkB5+KUNe/dWXwB1N9412HxYZc4iw8tla4xkKlZYMrCZFFLScsfOvc4a6f4aS9yd/gx+5XueP/hM/y/bCYi/xTD5RTZYKjy+tNpQxCMbruhAOnq9AAwim0UnE6Q/v0JtogXLDlmRSDT9y7ZNHgLHhlP+BijmL7E5k8pODR4EI1fmNtQp2Pd7qeLbDfMBY4eXo/idRt2evo5X4nr76GNNm/7PaABj8/R66U61slbdMs1IzFh6uPh3d/AAAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.PaymentExperience
{
    /// <summary>
    /// Partially-updates a web experience profile, by ID. In the JSON request body, specify a patch object, the path of the profile location to update, and a new value.
    /// </summary>
    public class WebProfilePartialUpdateRequest<T> : HttpRequest
    {
        public WebProfilePartialUpdateRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", new HttpMethod("PATCH"), typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public WebProfilePartialUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest) 
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
