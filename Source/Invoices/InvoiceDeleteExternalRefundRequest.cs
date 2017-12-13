// This class was generated on Wed, 13 Dec 2017 12:24:26 CST by version 0.1 of Braintree SDK Generator
// InvoiceDeleteExternalRefundRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6ySTW/UMBCG7/wKa86mWTj6hrqLWomPBVZcULWaxpPGyLHNeFIaRfnvyOuF7raHXrhFj95M3mcmM3zCgcCAC/fRtXRhyZPQnh6EOKDfM3VjsKBhTblll8TFAAbWh1hWGNTfqKpRrW4ndZymrtcKg1XCGDK25V11vb4ADV9G4mmLjAMJcQbz40bDFaElfkrfRx6esi1Kf8Zm2E2peGRhF+5Aw3dkh7eezv327rnLrj8UjZ2Snv5V7zgO6nfv2l5JVHUth0DVPHUqQu+YcaodVhq+EtrPwU9gOvSZCvg1OiYLRngkDVuOiVgcZTBh9H7RLxqcfPBli+clHy3+R92bmqEsdUiBBeUUQ6ZTdhmDUDjGAFPyrsVSqPmZYwANVyLpI0kfbfmvNh82uw3UC4OB5v5NUy/iwt3xiXIzP55zaarra6Y2ss3NfL6oBTRsHhK1QvaboIz5MloC83a1Wl79AQAA//8=
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
     * Deletes an external refund, by invoice ID and transaction ID.
     */
    public class InvoiceDeleteExternalRefundRequest : HttpRequest
    {
        public InvoiceDeleteExternalRefundRequest(string InvoiceId, string TransactionId) : base("/v1/invoicing/invoices/{invoice_id}/refund-records/{transaction_id}?", HttpMethod.Delete, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            try {
                this.Path = this.Path.Replace("{transaction_id}", Uri.EscapeDataString(Convert.ToString(TransactionId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
