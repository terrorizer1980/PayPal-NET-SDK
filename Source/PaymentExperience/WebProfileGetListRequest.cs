// This class was generated on Wed, 13 Dec 2017 14:31:23 CST by version 0.1 of Braintree SDK Generator
// WebProfileGetListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2SRT4/TMBBH73wKa85pUzhw8K0qhR74E6CCA+IwSX6hrhzbjCe0UdXvjkLK7qp7svQse97TXOgj9yBLJ9SLJLFzHstf0IV3WamgN8iNuKQuBrL03mXNhr03J9QG5wRxCA3M7WU2XRTDpoc0Bw5qopg81Ec0uqSCPg+QsWLhHgrJZH/8LGgHbiH39G2U/p5VrId79gW/B2Tdjwlkw+D9hHKKIWNmF5pP+o7aVLMmFfSNxXHtcat/VroOhkV4NLH71/o/cMpYTxfzr6+ncdx+Cn4k27HPmJWcoH0AlcQEUYc8K14L2sSgCDdt4pS8a3gaXR5zDFTQTjV9gB5iS5bebfc055Ol8s/LMvHYI+jicQPlk/3lkgranhMaRftVWYe8iS3Ivlqtri/+AgAA//8=
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
    /// Lists all web experience profiles for a merchant or subject.
    /// </summary>
    public class WebProfileGetListRequest : HttpRequest
    {
        public WebProfileGetListRequest() : base("/v1/payment-experience/web-profiles/?", HttpMethod.Get, typeof(List<WebProfile>))
        {
            
            this.ContentType =  "application/json";
        }
        
    }
}
