// This class was generated on Wed, 13 Dec 2017 14:32:34 CST by version 0.1 of Braintree SDK Generator
// TemplateUpdateRequest.cs
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
    /// Updates a template, by ID. In the JSON request body, specify a complete `template` object. The update method does not support partial updates.
    /// </summary>
    public class TemplateUpdateRequest : HttpRequest
    {
        public TemplateUpdateRequest(string TemplateId) : base("/v1/invoicing/templates/{template_id}?", HttpMethod.Put, typeof(Template))
        {
            try {
                this.Path = this.Path.Replace("{template_id}", Uri.EscapeDataString(Convert.ToString(TemplateId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public TemplateUpdateRequest RequestBody(Template Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
