// This class was generated on Wed, 13 Dec 2017 14:32:28 CST by version 0.1 of Braintree SDK Generator
// InvoiceCancelRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7xVwW4bOQy971cQOgu2dxfYw9wCZ4u4QGy3DnppA0OW6IxSjTiROEkHgf+90GicxJ4EQdC0F8N+osnHxyfqXsxVhaIQ1t+S1TjSymt0QopTjDrYmi15UYhpB0dQENEz9NESNi3MTiUobyRQF6yca2WKMinaE9ut1SqdgNpQw8AlQq7iMszUYbVqMUioMOhSee6SwlQXgJWyLo6EFJ8aDO1SBVUhY4ii+HopxRkqg+EY/UChOsaWissD7F5ctHXqPnKw/kpI8UUFqzYOD1VZWzNQ5KJEmJ0CbTvyfWDqJfeW6J6EoNpcYSLFZ1Rm4V0riq1yERNw09iARhQcGpRiGajGwBajKHzj3O4yx2DknOSBbp4GzJ+IO+S+IdO+PEefZQUKsDpfHczpTdR74Cn312XVep2HOuB34kGl0klX8pjoVRQQptMHH8BsCy01QJVNZrIR6v1MYRuo6ubxcbWYQ8jiQVJCHpvRxmxlJlDOPRYAZUzAGDECl4pBhWTNwEeTHsGCSwx3NqKEWKO22/aYDRM4m1niMDnBXWl1+QKv0bdmMvlXbxzp7zcNMXa/86eOHMhfZWROjEWGx09xODHG5gs5qJ168sQQm7qmwGj6auPjcodO+O+tTuhcLF+1gyfGoRMSQzxYDr9qzCM6GyKH6pmbk5bXmmm9X0UDbjNv0rgwwl2JyQaJZvpXx/VgnD3/fao/3UKn2zvw/x36v2SH2GyuUfOzG7c/21/G91xbeeXuUlSsyUfMeRIsxZQ8o+/3sFB17fqq4+vYLd8z5vocuSQjCrFcrC5Efm9EIca3f4/z1rD+qv+GcXz/+Ljsxg/P7v8/atSMZsWKmzglg6L4ZzLZ/fUTAAD//w==
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
    /// Cancels a sent invoice, by ID, and, optionally, sends a notification about the cancellation to the payer, merchant, and Cc: emails.
    /// </summary>
    public class InvoiceCancelRequest : HttpRequest
    {
        public InvoiceCancelRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceCancelRequest RequestBody(CancelNotification Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
