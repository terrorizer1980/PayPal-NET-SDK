// This class was generated on Wed, 13 Dec 2017 14:33:09 CST by version 0.1 of Braintree SDK Generator
// WebhookSubscribedEventTypesListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/5STTY/TMBCG7/wKa87epnDg4NtqW9iVFihQcVlVlRNPiCG1jWfSElX578hJCv2SUI95PR/POzPZw0e9QVCww7zy/ueEmpyKaHM0d7hFx3fcBqRJbYlBwgzTY2DrHSh4tsQk+jAx5vVPJEofhRZjTSnyVjzNJiDhc4OxXeioN8gYCdTLSsIjaoPxXH3n4+ZcW2iuTrQ9LNuQ8Imjdd9Bwjcdrc5rPLW1tuaCflmheJoJXwqu8MDak+8qW1SCvUiuT50lE/cx6nboO5XwBbX55OoWVKlrwiT8amxEA4pjgxIW0QeMbJFAuaauu9UQg8RDkSQmiYJ3hIP219i8n276EM/DDs4cXt1KcnVw1O/nNvBROCZ/uUJ0CdP3Wvcnc8F174ROAP9le3sr2zDVTsKDd4xuHCvoEGpb6NQ++0HegYRH5vABufIGFLyfL2G4KVCQbV9nzrMtxwzKRkbK9v+OqMuOfgqQMP8dsGA0X1lzQw/eIKg302n36g8AAAD//w==
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
    /// Lists event subscriptions for a webhook, by ID.
    /// </summary>
    public class WebhookSubscribedEventTypesListRequest : HttpRequest
    {
        public WebhookSubscribedEventTypesListRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}/event-types?", HttpMethod.Get, typeof(EventTypeList))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
