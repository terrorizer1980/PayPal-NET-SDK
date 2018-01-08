// This class was generated on Mon, 08 Jan 2018 16:22:15 CST by version 0.1 of Braintree SDK Generator
// WebProfileListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2SRy87TMBBG9zyFNeu0KSxYeFeVQhdcAlSwQCwmyRfVlWOb8YQ2qvruKKT/Rf1Xlo5lzzmaC33mHmTphHqRJHbOY+ldViroHXIjLqmLgSx9dFmzYe/NCbXBOUEcQgNze5VNF8Ww6SHNgYOaKCYP9RGNLqmgrwNkrFi4h0Iy2V+/C9qBW8g9fR+lv2cV6+GefcOfAVn3YwLZMHg/oZxiyJjZheaTfqI21axJBf1gcVx73MpflK6DYREeTez+tz4EThnr6WL+9e00jtsvwY9kO/YZs5ITtI+gkpgg6pBnxWtBmxgU4aZNnJJ3DU+jy2OOgQraqaZP0ENsydKH7Z7mfLJU/n1dJh57BF08baB8trtcUkHbc0KjaL8r65A3sQXZN6vV9dU/AAAA//8=
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
    public class WebProfileListRequest : HttpRequest
    {
        public WebProfileListRequest() : base("/v1/payment-experience/web-profiles/?", HttpMethod.Get, typeof(List<WebProfile>))
        {
            
            this.ContentType =  "application/json";
        }
        
    }
}
