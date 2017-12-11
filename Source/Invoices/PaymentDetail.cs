// This class was generated on Mon, 11 Dec 2017 16:45:18 CST by version 0.1 of Braintree SDK Generator
// PaymentDetail.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xVXW/bOBB8v1+xUF4SQZbuzveB+s2tUyBAkxipUbQIjGRNrmy2FMmSqxhqkf9eSLJlJ3bRFDHyJpCz5Mwsd/Q9mlSOokE0xqogwzAiRqWjJPqAXuFM0wUW9X6URCMKwivHypqtAtkUhDRKoqH3WLXn/ZlEV4Ty0ugqGuSoA9ULX0vlSXYLY28deVYUosF1x+RN6T0ZUe1ywMKWhneYvMZAYGefSTDk1gNqDbkyaIRCDXeoSwJPGpkk5Iq0DHA8Q41GUAJuLaOkBIhFenIwIYG9MvNdGWIj8KGQPmhiJg9rBAgrCTCApFwZkjCr4Oz9Jfzz91///5bh7MtHNE2p9X3yS66NeztE20ZA6YAtXIBUc8WAeU2dFwSShCpQBwjk0CPXPdloUKbT0LSrrkDnvHVeIdND8YdQOX2CTom8K3NSa6kpLRdkGp7K3FklCJYYwKGSKXSY3PoCGVSAuKqqKu7F5+dxL5YyhvhbnDxy4PrMMHlDDCNkyiaqIHjbnDA9XjC7QZaxtTqkijhPrZ9nCy505nPR7/dfHQUSNcfev+l/J8+dvCe+hIJ4YeVej9YzVNSv1XpooSmsr4Wl4kXj3+3px8np1cXw3W1XxJWjl3nLxu7p8WXzgTqFIdQAwBCsUE1YdLRXXF/IafZoAjYNvlH7HT8btUkHY6zGqDdmbkr32j8efho/y/zDqKqv3atrC/Si3H7GZ9unemzRrCJAmTnk2i7bALj2JKyX4CkvjZweZ9KKkKFTWYfOjlbZEW5acK8Fn6ymBULpnPUcHs9JC2vdaC7rmri1U8fO6oD6J2c9zFB8WaKXIGzhkNVMacXVQfyc3v/xAwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Payment details.
    */
    [DataContract]
    public class PaymentDetail {

        // Required default constructor
        public PaymentDetail() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="amount")]
        public Currency Amount { get; set; }

        /**
        * The date when the invoice was paid. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="date")]
        public string Date { get; set; }

        /**
        * REQUIRED
        * The payment mode or method. Required with the `EXTERNAL` payment type.
        */
        [DataMember(Name="method")]
        public string Method { get; set; }

        /**
        * Optional. A note associated with the payment.
        */
        [DataMember(Name="note")]
        public string Note { get; set; }

        /**
        * The ID for a PayPal payment transaction. Required with the `PAYPAL` payment type.
        */
        [DataMember(Name="transaction_id")]
        public string TransactionId { get; set; }

        /**
        * The transaction type.
        */
        [DataMember(Name="transaction_type")]
        public string TransactionType { get; set; }

        /**
        * The payment type in an invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        */
        [DataMember(Name="type")]
        public string Type { get; set; }
    }
}

