// This class was generated on Wed, 13 Dec 2017 14:33:09 CST by version 0.1 of Braintree SDK Generator
// WebhooksGetAllRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6SRQW8TMRCF7/wKa84mCRw4+BalLa1U2gUiOFQVmWRnuwbHNjOzwKrKf0fupgE2iAM9+sl+73vP93CFWwIH32ndpvRFJnekzzEEsHBCsmGf1acIDi69qBgMwTxeNU1ig9FgzhOw8LYj7itk3JISC7ibe1j2uZiLso93YOEDssd1oH0oxk2b+JOWW+O8Mx+KjdGWfiX6+HBmkpyikFn3D+fV3sjXK0NRvfameE7MCTXYBTVezGpeVZcXi/ny4vpqVXjnzNgPgDML7wjr6xh6cA0GoSJ87TxTfRAqTplYPQm42IWwu7VwTlgT/1H61sJZ4u1Yq1DbsVYiSHRgKJZFGpoN2mHAj8MAJnjR4xn/+lcmNYfdnlr3ZgxyzPAYdcQyjwZL9D94Xv3f/DsLixSV4n5BwJyD32AJnn6WFMHCuWp+Q9qmGhy8Pl3C8BPgYPrtxTQm9c3+hUx/q3D6I9NGqX6vqJ0sUk3gXs5mu2c/AQAA//8=
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
    public class WebhooksGetAllRequest : HttpRequest
    {
        public WebhooksGetAllRequest() : base("/v1/notifications/webhooks?", HttpMethod.Get, typeof(WebhookList))
        {
            
            this.ContentType =  "application/json";
        }

        public WebhooksGetAllRequest AnchorType(string AnchorType)
        {
            var strParams = Convert.ToString(AnchorType);
            try {
                this.Path = $"{this.Path}anchor_type={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
