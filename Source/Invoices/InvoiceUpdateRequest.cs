// This class was generated on Wed, 13 Dec 2017 12:24:29 CST by version 0.1 of Braintree SDK Generator
// InvoiceUpdateRequest.cs
// @version 0.1
// @type request
// @data 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
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
     * Fully updates an invoice, by ID. In the JSON request body, include a complete `invoice` object. This call does not support partial updates.
     */
    public class InvoiceUpdateRequest : HttpRequest
    {
        public InvoiceUpdateRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Put, typeof(Invoice))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }

        public InvoiceUpdateRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        
        

        public InvoiceUpdateRequest RequestBody(Invoice Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
