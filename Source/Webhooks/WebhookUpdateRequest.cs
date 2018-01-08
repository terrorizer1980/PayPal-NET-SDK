// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// WebhookUpdateRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6xVUVMjNwx+76/QuC9ws2RpH/qQtwxHh3aul5Sk7QPDsMpaYX04tmtpSTMM/72j3eWAhHK9OR4tW/In6fukO/MR12TGZkPLJsabUZssCpnCvCeus0viYjBjc07JY00MwztYOfKWYeOkgUAbuEXfEo9g3qYUszDE4LcgDUGVe98KYqKMGnAEM2QGhOoTx3CVUOqmgrj8RLX0IV9wAgwWqoTSVAVsGlc34Biqss2+glXMgPDH+QeIGaqSbinIlWwTcX/XGXgECwXUYa3Um5w0lDuYgy+CdywQVw8upjC/t5S3M8y4JqHMZnxxWZgzQkt51/pzzOtd2wyleWa7M4tt0qKzZBeuTWH+xOxw6el5M66c3WuEJvDLe8WnoB+6IRH6xincSc647X84Lsw5oZ0GvzXjFXomNfzdukzWjCW3VJhZ1hKLIzbj0Hp/f9m/IZY+yGe4v86nH2GmzdqH3PXwKvd+e6gnAVBRKe4uSvd86DgrfEzJbyFhFod+SKa7yMSxzTXxTmo/vZraYNjLTd9wioFpJ7e/+kruJ7aXyzSQEmUd82P9h0S+qvovQHxkxqmSD7rDHqIn5H610G3S+gmFgcp66nUjEbhdqt+SYBvb/JDICBZPr7Qv3j+4u1D71rpw3Ql+MCIrEbeAmQCtJVsAJ6rdqhc/slB2fAMH1bvqEDbOW6gx2+6jQeP9lHgm2S6H55Gqd9WOeydUxcf9zCE7gCrgor+7Ree1cIP98uD7z6ajznSk/4308eFX0es/lFN8Udn/V9HfyqQdOB9cuIEn38K0I+w+Pu/CzeusGiR+lMmjlvzibLI4nU7m0LleHpQ21lxicmWDQhH5qLsoD99Gv1+scJv9iyXW+S4Nio79OoaVu24zWaW4tp8CxACVjzX6JrL0W8OFOq6V8NVsOl9UEKK4lav7dbQmZrzWIaVR6xgE3SA1cGEV87rfdW8xke8LcxKDUBhGstFxOQApdYeawpyJpN9ImmjN2Mwmi5Mz0+8eMzbl7Q/lU/BcDjzj8u5x2dybwpz+k6gWsnNBafkkWjLjH4+P77/7FwAA//8=
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
    /// Replaces webhook fields with new values. Supports only the `replace` operation. Pass a `json_patch` object with `replace` operation and `path`, which is `/url` for a URL or `/event_types` for events. The `value` is either the URL or a list of events.
    /// </summary>
    public class WebhookUpdateRequest<T> : HttpRequest
    {
        public WebhookUpdateRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", new HttpMethod("PATCH"), typeof(Webhook))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public WebhookUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest) 
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
