// This class was generated on Wed, 13 Dec 2017 14:32:32 CST by version 0.1 of Braintree SDK Generator
// InvoiceSendRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/5STQW/aThDF7/9PMZqzhfm3N9+i0CocGmhBvbRRGOwBb7veMbuzaS3Ed68WOykEWqkXy/s8nvm9N/Ye76lhLNC4JzEljwK7CjOccCi9adWIwwIX7KoA5GCoymDdwXSSgQoQlDGoNOxHX+N4/LZcWym/76IoH8/9tQzqxW175V6Ui17OT3W42Sh76CRCwjgbmMSSnBMFz8enRoeB+fWJa5/3x9nRBlnbZRBYQWuGlRM1m+6xYV/W5HQFu8i+g5Y8NZwokjUbpCdJrzyXnmBBbCtShmMzU1KaM4IJbyhaBRNgpT7yaoQZfkzt58/dAxZf9rjs2hT9WsQyOczwM3lDa8vDTl4xXqxl6qo0lAP8qFnrHvqF9y+Mqe7U0h+Yb7ynroccZ/iJqZo522GxIRs4CbtoPFcvwtxLy14NByxctPbwkOEdU8X+zPhDhu/FN6+1OWl9PaCg3rjtZT6Dw0dz+cUua4bpBGRzFsUQzz95S2lct5ZqOGjfJIlJCq24wKfarThlN5Qhta0dtpB/C5K2fqfafmCtpcIC57PFEvswsMD86f+8hzduO9xxyPe/nR/y4Y9997PlUrlaKGkMt1IxFm/G48N/vwAAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Invoices
{
    /// <summary>
    /// Sends an invoice, by ID, to a customer.<blockquote><strong>Note:</strong> After you send an invoice, you cannot resend it.</blockquote><br/>Optionally, set the `notify_merchant` query parameter to also send the merchant an invoice update notification. Default is `true`.
    /// </summary>
    public class InvoiceSendRequest : HttpRequest
    {
        public InvoiceSendRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/send?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }

        public InvoiceSendRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
