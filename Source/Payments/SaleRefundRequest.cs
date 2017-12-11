// This class was generated on Mon, 11 Dec 2017 13:16:36 CST by version 0.1 of Braintree SDK Generator
// SaleRefundRequest.cs
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

namespace PayPal.Payments
{
    /**
     * Refunds a sale, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an `amount` object in the JSON request body.
     */
    public class SaleRefundRequest : HttpRequest
    {
        public SaleRefundRequest(string SaleId) : base("/v1/payments/sale/{sale_id}/refund?", HttpMethod.Post, typeof(DetailedRefund))
        {
            try {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public SaleRefundRequest RequestBody(RefundRequest RefundRequest) 
        {
            this.Body = RefundRequest;
            return this;
        }
    }
}
