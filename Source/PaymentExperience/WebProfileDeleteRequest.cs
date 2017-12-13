// This class was generated on Wed, 13 Dec 2017 12:10:42 CST by version 0.1 of Braintree SDK Generator
// WebProfileDeleteRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2SRT4/TMBBH73wKa87eTeHoG9oE7Ur8KVBxQSvkxL8SI8c24wltVPW7o5CIlnJ9GtvPb0703g4gQwe0d5nT3gfcOwQISFON0rHP4lMkQ/UfXJRVB7QKxwz2iB3Uek6rdlJP9T1p+jiCp61lO0DAhczXZ02PsA58S98kHm7Z1kr/DzvRbsqzZhH28Ttp+mLZ2zZg1V8Vvnn3n/auh3qqVdor6f+6Kklq+eas+5rZTssLG02fYN2HGCYyexsKZvBz9AxHRniEpi2nDBaPQiaOIZyflxkUWS6Z4YxKTrHgmj2kKIjrGNmcg+/sLFr9KCmSpkeR/A7SJzcXb942u4aWIGSo+vWyynYaEOXu0r+62l2pTpcUZ9LUHDM6gfssVsbykBzIvNpszi9+AwAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.PaymentExperience
{
    /**
     * Deletes a web experience profile, by ID.
     */
    public class WebProfileDeleteRequest : HttpRequest
    {
        public WebProfileDeleteRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
