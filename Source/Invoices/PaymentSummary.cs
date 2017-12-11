// This class was generated on Mon, 11 Dec 2017 16:45:18 CST by version 0.1 of Braintree SDK Generator
// PaymentSummary.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+ySTUszQQzH78+nCHN6hKX4BsLefLl4aYstXqSH7Ey2HZmdGTMZYZF+d9lWt9YqUuix15CE3y/5v6lpG0mVaoxtQ15gkpsGuVWFekS2WDkaYtM1qELdUdJso9jgVammC4L4MYXeAFOdvYG0XjBQhbpmxna9/7RQD4Rm5F2ryhpdoq7wki2T6QtjDpFYLCVVPvVkt5mZvP4BKciCeIfrBhNBqJ5JC9SBAZ2D2nr02qKDV3SZgMmhkIHakjMJ/lfo0GsqeiGTqQASPTg5mEcStn6+a6E3ftsiF+BIhBg+O0AHQ4AJDNXWk4GqhfvJCC7Pz672urdw/obps3PL4k/W1fV2QLEJ2QvkCBJgCMbOrQDWHbosCAxp26BLkCgio3Q/2ThY3zus3tVNYIwcIlsU2pY/hOXsi+fv2YrYRnTHcB3DtWe4Zst/7wAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The payment and refund summary.
    */
    [DataContract]
    public class PaymentSummary {

        // Required default constructor
        public PaymentSummary() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="other")]
        public Currency Other { get; set; }

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="paypal")]
        public Currency Paypal { get; set; }
    }
}

