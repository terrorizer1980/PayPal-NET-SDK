// This class was generated on Mon, 08 Jan 2018 16:45:19 CST by version 0.1 of Braintree SDK Generator
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
