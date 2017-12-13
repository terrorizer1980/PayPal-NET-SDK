// This class was generated on Wed, 13 Dec 2017 12:24:20 CST by version 0.1 of Braintree SDK Generator
// RefundDetail.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xVYW/bNhD9vl9xUL8kgiylSbdi/pYtHWBgTY3UGDYEQX0mT9ZtFMmRp3ra0P8+ULKd1TawDgvylXx3eu/dO+qvbNF7yqbZHdWd1XBDgmyyIvsJA+PK0C226TorshuKKrAXdjabZjP70bFiu4YwVuqhMpZZkV2HgP3Y96LI7gj1O2v6bFqjiZQOfu84kN4fzIPzFIQpZtP7PaPvuxDIqv6YDLaus3JE6TuMBG71KymB2gVAY6Bmi1YxGviIpiMIZFBIQ81kdISzFRq0igrw2LdkBXRHBZCo8vzJhEQJbNfHMtSjwM+FXIEhEQqwQ4BymgAjaKrZkoZVD7P37+DV5cvX/8lwCd0BTdsZ86n4V66De0dEx0FA50Ec3ILmNQtgnahLQ6BJcYsmQiSPASXN5FED272GYVypAr0PzgdGoc/FP4XKhy/QqVGOZS6SlkRp05AdePKQfoINxm3+SZewx9UutCjAEfK+7/t8kr99m09yrXPI/8yLAxfuZ1YoWBK4QaFqwS3BD0OHh7NGxE+rSpwzsWSSunRhXTXSmirU6urq6tsXkVTiOfm6/Oa8TIVAf2DrDRWwvLx4+WpycTm5fA3z94vl/13OLwyLdSdMvIZ0DBijUzzs4IalGdwcHXwmchLQRhws+8D65KxnN+Dqgdkc+zma3RP3j9ISdlweZSzn17/Mr39c7uG9p+cSla5PSTkQkBjBzGpWKBRTnqXZLusWkhLtkTVIE1y3bnYdhlilmKIxfUot738AtXGbMfz3gZQLetvr4azSTsUKPVd7dPViuzvxwwiejOBzaEkapyF23rsgcbT0zc+LN3e3h6YOHztld1q5bYP0yLsAK1S/bTBoUK71KLxiw9I/yVgePn31NwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Invoicing refund details.
    */
    [DataContract]
    public class RefundDetail {

        // Required default constructor
        public RefundDetail() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /**
        * The date when the invoice was refunded. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6). For example, `2014-02-27 PST`.
        */
        [DataMember(Name="date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /**
        * A note associated with the refund.
        */
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /**
        * The ID of the PayPal refund transaction. Required with the `PAYPAL` refund type.
        */
        [DataMember(Name="transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /**
        * The PayPal refund type. Indicates whether the refund was paid through PayPal or externally in invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        */
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

