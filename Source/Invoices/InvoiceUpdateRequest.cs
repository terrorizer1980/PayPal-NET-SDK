// This class was generated on Mon, 08 Jan 2018 16:45:18 CST by version 0.1 of Braintree SDK Generator
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
    /// <summary>
    /// Fully updates an invoice, by ID. In the JSON request body, include a complete `invoice` object. This call does not support partial updates.
    /// </summary>
    public class InvoiceUpdateRequest : HttpRequest
    {
        public InvoiceUpdateRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Put, typeof(Invoice))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }

        public InvoiceUpdateRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        

        public InvoiceUpdateRequest RequestBody(Invoice Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
