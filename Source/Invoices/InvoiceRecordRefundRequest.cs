// This class was generated on Wed, 13 Dec 2017 12:24:28 CST by version 0.1 of Braintree SDK Generator
// InvoiceRecordRefundRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7xW3W7jNhO9/55iwL1JDNnKz35dVHdpksW6aBI3MYoWQbAZi6OIG4rkkqN41SDvXlCS7dhOsQEa7O1oODrnzBlyHsU5ViQyocyDVTmNPOXWy6GnojZSJOKEQu6VY2WNyMQZ+vsAXBIERq4D2ALQQH84gVkD45MEMEBXgOQIxqY98OvVxTl4+lpTYJhZ2SSgTK5rSYDgsKnIMEhiVBrs7AvlDFxiDBXKUPfTRVpFXFoJaCRYLsn358JIJOL3mnwzQY8VMfkgsuubRHwilOQ3ox+trzZjE+RyLfYopo2LCgX2ytyJRPyBXuFM07pyn9W2XNOSYHwSRYro+0RgCxX6+zWVRCKOvMem+9deIi4J5YXRjcgK1IFi4GutPEmRsa8pERNvHXlWFERmaq2fbrocCtwVWQK/bH8CJ61G2/hjL7aQj1usytz1EJ8r/GqgfeA50pWcx7X3ZPJmGxBWtja8BekXDLRwRmE9oNZQKIMmV6jhAXVN4Ekjk4RCkZYBdmao0URjLg1WUwLE+Wj3zYj8my/yFcF1IoegiZk8LDIgt3EKQu912Y7R1QW8P9j/8BbOSL6LtVVvC2jXCKhdtOw5SHWnGLCI0KOfJeWqQh0gkEOPHHuy4qDMkkPbrngCnfPWeYVM6+TfxP+v4CmR6cUpjR9gXpJZm9T52kW2zCusr5BBBRg0TdMMhoOzs8FwIOUABn8Pkg0VrseGyRtiOEGmdKoqgo9thZudktllacrW6jBSxMXI+ru05EqnvsgPDw9/fhcojziH/x/9tDuKB4G+YeU0JXB7sLf/frh3MDz4AJOr6e1/Hc5XmsXYF0Q8ghgGDMHmqp3BueKyVbNT8AeBY48mYCvZ92/kCTYT1Isr7tnRESywrGjcTo7+mhz9drtMbxz9KFLx80tUNghERDA2UuXIFKKf29dx1YTW0Q6VBC69re/KRYXWVtGmqHUTXauWD0Ch7bwz/3W3HPS1bnZSafOQolPpMjt9189O+Ly2Sewu3uxQO2c9d+/57emf09PL801R25+9JHccub5AvOSthxnm93P0EnJbOWQ1U1px8yZtuXmKWcFZE6irE8OJOLaGyfSPrEDndJRbWZN+CdaIRHxidmctW5GJycXVVHRrhchE+rD/TKuFVOnjaod4Sjc3sNNvjnImedVuXMdWksgO9vae/vcPAAAA//8=
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
     * Marks the status of an invoice, by ID, as refunded. In the JSON request body, include a payment detail object that defines the payment method and other details.
     */
    public class InvoiceRecordRefundRequest : HttpRequest
    {
        public InvoiceRecordRefundRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/record-refund?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceRecordRefundRequest RequestBody(RefundDetail Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
