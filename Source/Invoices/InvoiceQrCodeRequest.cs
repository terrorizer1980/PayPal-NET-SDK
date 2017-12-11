// This class was generated on Mon, 11 Dec 2017 16:45:25 CST by version 0.1 of Braintree SDK Generator
// InvoiceQrCodeRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/8yWS2/bRhDH7/0Ug+0lBhhSaZsedGpj52GgTeVHUhSuYY3IobjBcne9O7RCGP7uxSwpWbIVJEGKojfua3Z+/3ksb9VbbElNlbY3TpeUX4er0lWkMnVEsQzas3ZWTdVrshSQKQLCySnIHqhdALQwHs1g0cPxUf53N5n8WC5CkT7owfC8oc15LcZmb1+DbnFJoC1cvMBIP//0lKxsqC6fNMw+TotitVrli7Q2LOUuLIsD8aBFBm6QoXQhUPTOVhHYATe09ky8gr9cByVaWI4gn+QAtBVgVYFmsYPg0VMAF2B29Gq9KYc/G7KAUHaRXUsBukhRLtUBWrfQhqCiGzHHDqJczPfkGTQkBmOTRAhU6UAlU7V2fIb9DM3akMe+JctQG7eCVUOBts6LaY89OGu0JVhpbtbHBQtKsc5QYqg+E5oXVLtA0LsOlsT3+mRpqu0iT4cTzmyfN3p75IfBxWGgJPJG1ssn349f8apMiwc5nHkqdd3D/DqMi7947D2avHTtHDApCoFK7bUoQC1qI8EJFKMkjCzPF9oYbZdX2tZuDm7xgUrO4V2k7fjsHnXW9KDrRLZCmyI97NjKm1Gvwm8DFru8++nPSHJoL3skWx3Ida27oZ0srYNrAaEKWCd/PPa4MASRkSmH48Hb+C2SZTsX6gjWjTuo+hLaYh16lamTjkI/w4AtMYWophe36rz30kwiB22XKlPvMWhhGJsMlqmbPOwt0hO49wSuhnenv6V6XDW6bESFx/WawxHV2BkWgLnHfp5KVg/kKbKx894FKagbNB3lKlO/hoD94N8kU6eE1R/W9Gpao4kkE9edDlRtJmbBeQqsKaqp7Yy5yzZ42jItKTzma0gvG97LNyxlkrNefyQTM6Hl7W4oTTCH92j06LYgpaR49nwiUjyfTHbYZfwfka10xc1esLTy/+S6zNQbworCTpZeZuqVC+3DuRly83XZPJbRla72CnN8tFZiU+CfyeuvYebQfQJZ9lDkwYhMypS8i5GGuQ3YySkcDm/9A7JHPMPTC+OzPL7XQidVm0aFTxJ9S8y+QHG56ZFz/0qq3GXq0FkmOwqn0HujS5Q7ig8xda03zP534sZV8kP08lwNWaOmqrh5VgxR1nZZrHt9cXufInfFdXg6/lm9/OjTa3/GyF1MIZj+MJncffcPAAAA//8=
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
     * Generates a QR code for an invoice, by ID.<br/><br/>The QR code is a PNG image in [Base64-encoded](https://www.base64encode.org/) format that corresponds to the invoice ID. You can generate a QR code for an invoice and add it to a paper or PDF invoice. When a customer uses their mobile device to scan the QR code, he or she is redirected to the PayPal mobile payment flow where he or she can pay online with PayPal or a credit card.<br/><br/>Before you get a QR code, you must:<ol><li><p>[Create an invoice](#invoices_create). Specify `qrinvoice@paypal.com` as the recipient email address in the `billing_info` object. Use a customer email address only if you want to email the invoice.</p></li><li><p>[Send an invoice](#invoices_send) to move the invoice from a draft to payable state. If you specify `qrinvoice@paypal.com` as the recipient email address, the invoice is not emailed.</p></li></ol>
     */
    public class InvoiceQrCodeRequest : HttpRequest
    {
        public InvoiceQrCodeRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/qr-code?", HttpMethod.Get, typeof(QrCode))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }

        public InvoiceQrCodeRequest Action(string Action)
        {
            var strParams = Convert.ToString(Action);
            try {
                this.Path = $"{this.Path}action={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public InvoiceQrCodeRequest Height(int Height)
        {
            var strParams = Convert.ToString(Height);
            try {
                this.Path = $"{this.Path}height={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public InvoiceQrCodeRequest Width(int Width)
        {
            var strParams = Convert.ToString(Width);
            try {
                this.Path = $"{this.Path}width={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        
        
    }
}
