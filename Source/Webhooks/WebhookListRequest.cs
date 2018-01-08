// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// WebhookListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6SRQW8TMRCF7/wKa85WEjhw8C1KW1qptAtEcKgqMsnOsgbHNjOzwKrKf0fuLgE2iAMc/TR+75s3D3CDewIHX2nbpvRpFrwoWDgj2bHP6lMEB9deVAyGYMYxMU1ig9FgzjOw8Koj7itk3JMSC7i7B1j3uRiLso8fwMJbZI/bQGMgxl2b+L2WqWnehQ/FxmhLPxN9fHwzSU5RyGz7x/dmNPL1xlBUr70pnjNzRg12QY0Xs1lW1fXVarm+ur3ZFN4lM/YD4MLCa8L6NoYeXINBqAifO89UH4WKUyZWTwIudiEc7i1cEtbEvy19b+Ei8X6qVajtVCsRJDowFMsiDZsN2rHAd0MBZrzMpMY/3sqk5tjb/657NwU5ZfgRdcKyjAZL9F94nv9b/QcLqxSV4tggYM7B77AEzz9KimDhUjW/JG1TDQ5enK9huAQ4mH95Oo9JfTP+kPkvK5x/y7RTqt8oaierVBO4Z4vF4cl3AAAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Webhooks
{
    /// <summary>
    /// Lists all webhooks for an app.
    /// </summary>
    public class WebhookListRequest : HttpRequest
    {
        public WebhookListRequest() : base("/v1/notifications/webhooks?", HttpMethod.Get, typeof(WebhookList))
        {
            
            this.ContentType =  "application/json";
        }

        public WebhookListRequest AnchorType(string AnchorType)
        {
            var strParams = Convert.ToString(AnchorType);
            try {
                this.Path = $"{this.Path}anchor_type={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
