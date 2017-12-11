// This class was generated on Mon, 11 Dec 2017 17:22:29 CST by version 0.1 of Braintree SDK Generator
// WebhooksDeleteRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2SRT08CMRDF736K5p0bFo2n3gy7BhL/oBIvhphCB7e6tLWdVTeE727qQhS8/vLa+c2bDW70mqDwSYva+7c0MNQQEyRKSstoA1vvoFD+4CS02CWlWHRiUg4gcddS7KY66jUxxQT1NJcYkzYUj+mlj+tjNtVcH7ANZl3IUomjdS+QeNTR6kVDh7LP1vzznNUkJqXwK8E17V0Fe9HvlXUvYtRdP2EocU/a3Lqmg1rpJlEG762NZKA4tiQxjT5QZEsJyrVNs533GUrcf5JhRil4l+gvG3nH5HYx6BAau9RZtHhN3kFizByuiWtvcsXVVTWr0BcCheLjtHCe7Wr3KBX7IxWb3wa2kKi+Ai2ZzANrbtPIG4I6G55vT74BAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Webhooks
{
    /**
     * Deletes a webhook, by ID.
     */
    public class WebhooksDeleteRequest : HttpRequest
    {
        public WebhooksDeleteRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
