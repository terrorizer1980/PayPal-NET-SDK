// This class was generated on Mon, 11 Dec 2017 17:19:28 CST by version 0.1 of Braintree SDK Generator
// AgreementStateDescriptor.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SOsU7EQAxEe77Ccr1C1OlOogYEJxpEYZJJstKeN3idIkL372jhEoRSXulne+Z98XGZwA0fBgNOUKcXFwfdo7QWJ8/GgV/FonwkPMip3nLgdR2z1mfq/mbKPfkIamezmld+8i5Q1ppbDnwwk+W3/y7wM6R71LRw00sqqOBzjoZuA0+WJ5hHFG7eNvPiFnXYW2p27EyPI8ggJSv12f4rXUzbUXTAtX46p3R+P998AwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * A description of the current state of the agreement.
    */
    [DataContract]
    public class AgreementStateDescriptor {

        // Required default constructor
        public AgreementStateDescriptor() {}

        /**
        * The reason for the agreement state change.
        */
        [DataMember(Name="note")]
        public string Note { get; set; }
    }
}

