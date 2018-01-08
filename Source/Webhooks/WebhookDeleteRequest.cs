// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// WebhookDeleteRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2SQzU7rMBSE9/cprFlbTS9i5R1qglqJnwIVG1Qhtz4lhtQ29gkQVX13ZBIELdtPY59vZocrvSUovNOq9v5lZKghJkiUlNbRBrbeQaH8wkloMQSlWHViVo4gcdNS7OY66i0xxQT1sJSYkjYUj+m5j9tjNtdcH7AdFl3ITomjdU+QuNfR6lVDh66P1vzxXNQkZqXwG8E1fbsK9qLvlXXPYtRdf2EscUvaXLumg9roJlEGr62NZKA4tiQxjz5QZEsJyrVNs1/2GUrcf5JhRil4l+g3m3jH5IYYdAiNXessWjwn7yAxZQ6XxLU3eeLqolpU6AeBQvH2v3Ce7WZ4lIqhTip2PwvsIVF9BFozmTvW3KaJNwR1Mj7d//sEAAD//w==
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
    /// Deletes a webhook, by ID.
    /// </summary>
    public class WebhookDeleteRequest : HttpRequest
    {
        public WebhookDeleteRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
