// This class was generated on Mon, 11 Dec 2017 17:19:28 CST by version 0.1 of Braintree SDK Generator
// MoneyTypeWithCurrencyCodeQualifiedValue.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yS32vUQBDH3/0rhn1SyGVVBCFvhSJU6A9sEaQUO7c7uR3c7Kazk55B+r9LLnfBeoIIvi6z35nPfOaHuRl7Mo05z4lG0LEn2LIGcIMIJTeCy57gYcDILZOHR4wDmcp8RmFcR7rAbvpuKnNKxQn3yjmZxpzMWW0WwBih5YTJMcY5YCUUUclDyxR9qeFDFqDv2PWRKlhjxOSogh7HjpKCH6gCTB5KhpxqU5kTERzn0V9X5hOhv0xxNE2LsdD08DCwkF8eriT3JMpUTHO7QBcVTptjmgP8EdVNILjVIEQrF1DQKQmcXV+u3r198/75zu5eBtW+NNZ6eqQ4ta97HHuMtcud9dkVy0lpIziFW89CTq1QUXsIWk1Bxb76J2KV4TfgNMT4VP2V+qD2GHkB25XUcM6boLAmwAQ7BpKd6X0dU4HI3wjuP159uQcNqIBCkLJOV8EOYxyhndbHOWGE6UhgXmsf0RF4ctxhXGr+nH5zcfpLehnWnh/Zk59myqAhDwWT17C/Lw0Esl8TpKFbk0Bul167zmW+2OcqKyhEcHt2fQmT59lsY+12u6255DrLxnLJNuSObFFMHsWXxeLXncU6aPdfRN49vfgJAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * A type for all financial value-related fields. For example, balance, payment due, and so on.
    */
    [DataContract]
    public class MoneyTypeWithCurrencyCodeQualifiedValue {

        // Required default constructor
        public MoneyTypeWithCurrencyCodeQualifiedValue() {}

        /**
        * REQUIRED
        * The [three-character ISO-4217 currency code](https://developer.paypal.com/docs/integration/direct/rest/currency-codes/).
        */
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /**
        * REQUIRED
        * The currency value. Might be an integer for currencies like `JPY` that are not typically fractional or a three-place decimal fraction for currencies like `TND` that are subdivided into thousandths. For the required number of decimal places for a currency code, see [ISO 4217](http://www.iso.org/iso/home/standards/currency_codes.htm).
        */
        [DataMember(Name="value")]
        public string Value { get; set; }
    }
}

