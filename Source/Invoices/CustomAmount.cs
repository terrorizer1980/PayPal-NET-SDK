// This class was generated on Mon, 11 Dec 2017 16:45:16 CST by version 0.1 of Braintree SDK Generator
// CustomAmount.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTS4sVMRCF9/6KIiuFcPEFQu9G3cxmRnRwIy6qk+qZkuokVioDQfzv0j3P9i68MnfX1KM536mTX+6iF3KD+9Cq5RlO5tySOe++ojKOQmc4L23n3UeqQbkY5+QGd3FFEG52cN0By4ClSF8/EnC6zhxoB6cT9NyAU5AWCRAERxK/FudW7VFn88Od8+5EFfuNwpfefSaM50m6GyaUSkvhZ2OleF/4pLmQGlN1w7dHbKqUQt/HwjvcLdx7rAR5/EHBYMoKKAITJ0yBUeAapREoCRpFmJgkVng+omAK5KFgnykZxEYeyMLuxdFAqimny32M8AC4BXkDQmakcDcBIS9OV4g0caIIY4fTL+fw9vWrd/9luGn7S2ZqIr/9P7Wu7u0Jvc1QK0t6ziDyJRvgtEi3K4JIgWeUCpUKKtpykwcGTvcM67mWDSxFc1FGoy38MSi/H8C5pvyAZ7POPTXrt6qe/QEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
    */
    [DataContract]
    public class CustomAmount {

        // Required default constructor
        public CustomAmount() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="amount")]
        public Currency Amount { get; set; }

        /**
        * The custom amount label.
        */
        [DataMember(Name="label")]
        public string Label { get; set; }
    }
}

