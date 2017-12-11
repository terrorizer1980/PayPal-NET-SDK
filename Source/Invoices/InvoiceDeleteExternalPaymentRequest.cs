// This class was generated on Mon, 11 Dec 2017 16:45:23 CST by version 0.1 of Braintree SDK Generator
// InvoiceDeleteExternalPaymentRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6ySTW/UMBCG7/wKa86mWTj6hpqgVuJjgRUXVK2m8Wxj5NhmPCmNovx35CaluwWpl96iR28m7zOTCT5hT2DAhdvoWjqz5EloT3dCHNDvE449BQENNeWWXRIXAxio73NZYVAPWbVmtboe1TpPXdYKg1XCGDK25WV1WZ+Bhi8D8bhFxp6EOIP5caXhgtASP6XvI/dP2RalO2ET7MZUTLKwCzeg4Tuyw2tPp4Z7Z/+R2XX3ReNBSUd/qx849up359pOSVTLYhQ+WB4rFZ93zDguFTYavhLaz8GPYA7oMxXwa3BMFozwQBq2HBOxOMpgwuD9rJ8VOPrg8xL/aflo8RJ9r5YMZVmGFFhQTjFkOmbnMQiFNQaYknctlkLVzxwDaLgQSR9JumjLj9V8aHYNLBcGA9Xtm2q5iAs36xPlano851ytsq+Z2sg2V9PpqmbQ0NwlaoXsN0EZ8nm0BObtZjO/+gMAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Invoices
{
    /**
     * Deletes an external payment, by invoice ID and transaction ID.
     */
    public class InvoiceDeleteExternalPaymentRequest : HttpRequest
    {
        public InvoiceDeleteExternalPaymentRequest(string InvoiceId, string TransactionId) : base("/v1/invoicing/invoices/{invoice_id}/payment-records/{transaction_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            try {
                this.Path = this.Path.Replace("{transaction_id}", Uri.EscapeDataString(Convert.ToString(TransactionId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
