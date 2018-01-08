// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// WebhookListEventSubscriptionsRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/5SST4/TMBDF73wKa85mUzhw8G21LWwl/hSouFRV5SQTYkht45m0RFW+O3KSFtJUQj36aWz/3pt3go96j6DgiGnp3M+HyhDv8ICWd1SnlAXj2ThLIGGOlyMoeG+ISXSTYjQpCheEFsODUqSNWM4fQMLnGkOz0kHvkTEQqM1WwjPqHMO1+taF/bW20lyOtBOsGx/ZiYOx30HCNx2MTisce9qZfEK/LlEs58IVgks8s3bkx9JkpWAnYhJjZ9HEYwi66f+dSfiCOv9kqwZUoSvCKPyqTcAcFIcaJayC8xjYIIGydVW1234GiftHohgl8s4S9trF2KJLNx5EjHvq8OZWoquzo24/94EPwr/kmxtEU5i+Ndx4nLbl0QodAf7L9uZetj7VVsKTs4x2iBW095XJdPw++UHOgoRnZv8BuXQ5KHi3WEPfKVCQHF4l1rEphhuUDIyUnP6WqE064pdnh4vfHjPG/CtrrunJ5Qjq9WzWvvgDAAD//w==
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
    public class WebhookListEventSubscriptionsRequest : HttpRequest
    {
        public WebhookListEventSubscriptionsRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}/event-types?", HttpMethod.Get, typeof(EventTypeList))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
