// This class was generated on Wed, 13 Dec 2017 14:32:56 CST by version 0.1 of Braintree SDK Generator
// AgreementStateDescriptor.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SOsU7EQAxEe77Ccr1C1OlOogYEJxpEYZJJstKeN3idIkL372jhEoRSXulne+Z98XGZwA0fBgNOUKcXFwfdo7QWJ8/GgV/FonwkPMip3nLgdR2z1mfq/mbKPfkIamezmld+8i5Q1ppbDnwwk+W3/y7wM6R71LRw00sqqOBzjoZuA0+WJ5hHFG7eNvPiFnXYW2p27EyPI8ggJSv12f4rXUzbUXTAtX46p3R+P998AwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A description of the current state of the agreement.
    /// </summary>
    [DataContract]
    public class AgreementStateDescriptor {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public AgreementStateDescriptor() {}

        /// <summary>
        /// The reason for the agreement state change.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }
    }
}

