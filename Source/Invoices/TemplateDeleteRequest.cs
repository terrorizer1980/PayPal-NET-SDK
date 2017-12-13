// This class was generated on Wed, 13 Dec 2017 12:24:30 CST by version 0.1 of Braintree SDK Generator
// TemplateDeleteRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/2SQzWrrMBCF9/cpxKxFnHuX2l1ilwT6k7ahmxLKxJrEKrKkjsahJuTdi+umpOn24zDznXOAW2wJDAi1yaPQxJInIdBQUq7ZJXExgIHyE2eF6pTUatOrRTkBDfcdcb9ExpaEOIN5XmuYE1riS3oVub1kS5TmBzvAqk+DVRZ2YQcanpAdbjxd2L44+8t01ZBalCpulTT0baskqrHaIPyfGfvxx1TDA6G9C74Hs0WfaQBvnWOyYIQ70rDkmIjFUQYTOu+P6zFDWcYjAxxQTjFkOmezGITCVwwwJe9qHEyL1xwDaJiLpBuSJtph5eq6WlUwTgIGiv3fwoV9dLULu+LUJReHswGOoKF6T1QL2UdB6fIsWgLzbzo9/vkAAAD//w==
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
     * Deletes a template, by ID.
     */
    public class TemplateDeleteRequest : HttpRequest
    {
        public TemplateDeleteRequest(string TemplateId) : base("/v1/invoicing/templates/{template_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{template_id}", Uri.EscapeDataString(Convert.ToString(TemplateId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
