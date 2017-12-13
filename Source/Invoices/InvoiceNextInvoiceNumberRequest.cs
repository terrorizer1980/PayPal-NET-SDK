// This class was generated on Wed, 13 Dec 2017 12:24:27 CST by version 0.1 of Braintree SDK Generator
// InvoiceNextInvoiceNumberRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6RRy27UQBC88xWjPnsfcJwbCo9wgCxkxQVFUceuxIPsnqGnvcoq2n9Hw5iVcMQFTnaXuqaqq57oE48gT0EOMbRYCx7tdh5uZRrvoNTQG+RWQ7IQhTy9h0DZkJ31cIXhZoarDGc9mwvZ8YHDwHcDnMVfyyO07VlsTQ19nqDHHSuPMGgm/+2moUtwB12i76KOS2zH1i+xL/gxIdv+mEBepmEoUE5RMir2RPVLH/4wTA19ZQ3F6ZzHs6OpodeqfKz8bXmYuysZjuTvecio4kHRnYGdxgS1gOLurJxNgzw8V/xL2Pt/jtjt+5B/r5fNyeIqSKsYIYbO3WscKyVmc4oWspRZ/+fZpYPTzamhiygGmZshTmkILZcTN99zFGro0ix9hPWxI0+7q+s91YrJ0+bwclNtBXmY/5A3JZXVPK3O6b19TGgN3bWxTfkidiD/ars9vfgJAAD//w==
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
     * Generates the next invoice number that is available to the merchant.
     */
    public class InvoiceNextInvoiceNumberRequest : HttpRequest
    {
        public InvoiceNextInvoiceNumberRequest() : base("/v1/invoicing/invoices/next-invoice-number?", HttpMethod.Post, typeof(InvoiceNumber))
        {
            
            this.ContentType =  "application/json";
        }
        
    }
}
