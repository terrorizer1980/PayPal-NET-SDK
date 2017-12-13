// This class was generated on Wed, 13 Dec 2017 12:24:28 CST by version 0.1 of Braintree SDK Generator
// InvoiceRemindRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6xVTW/jRgy991cQcxZstwV60C1wWsQFYrt1sJfdwKE1VDTZ0VCZoZIVAv/3xWjkxB8JgmBzMSyK4Ht8fKSe1BxrUrky7oFNQSNPtXFaZeqcQuFNI4adytWKnA6AkF6TB2GQiqDBjjzghlsBdDBUyWDTwex8BDPXZ/27WszB031LQWDDusvAuMK2mgDhxrGY0hQYoW6AN3dUCEiFAppK4yj0NUKbXnDZPz4TQaeBpSIPmgSNDSOVqf9a8t0SPdYk5IPKv15n6oJQkz+O/sO+Po4tUaqD2JO66pooUxBv3K3K1Bf0BjeWDuVbm1PpriqC2fmO95AIJXt4rExRRSUDOb0nbuzgzHvsEugkU/8T6oWzncpLtIFi4L41nrTKxbeUqaXnhrwYCip3rbXb65RDQVKR5w7me2qf9hGH82oHVKOxwB5WlyvYn9iHyA6Bfbbva1sU6x49nBA7c4AROorLjiK9mj3BdJonwmEEsxI6boFrE01lAjS7wULpuX7Ln3jQJJgQhyRxWGjtCwCg1p5C6E2KAujjTng5GvcIFtGijyZQBqGhwpTdMRthsCaxpNPiPLhln1Xo4SKv0bd2Mvmz2Fguvt+3LNQ/p98iiGd3myJzFspTeLwfhzOtTayJ9gQ7gjgWCG3TsBfSA9r4GO7QCX991Am9b7N37eBY6NQJkSEdXKVfNeYRnQ2zJXxlZeLyroXXNfmiQicn3GZOx4FRgMeK+kv1svIFN93OK0n3oYVdtU/u4i1Rh+v66uofXd7PXP50qrYxKzTsAqU6MZypKTshN9wvhU1jB9TxXehv14VIc0lSsVa5Wi5WVyqdbpWr8cPv47R7xt0O/yiMn17u9Hb8/Kn7+0dDhZBeCUobpqxJ5X9MJtvffgIAAP//
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
     * Sends a reminder to the payer about an invoice, by ID. In the JSON request body, include a `notification` object that defines the subject of the reminder and other details.
     */
    public class InvoiceRemindRequest : HttpRequest
    {
        public InvoiceRemindRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/remind?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceRemindRequest RequestBody(Notification Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
