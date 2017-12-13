// This class was generated on Wed, 13 Dec 2017 14:31:38 CST by version 0.1 of Braintree SDK Generator
// FundingInstrument.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A payer's funding instrument. An instance of this schema is valid if and only if it is valid against exactly one of these supported properties.
    /// </summary>
    [DataContract]
    public class FundingInstrument {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FundingInstrument() {}

        /// <summary>
        /// [DEPRECATED] A credit card. Can be used to fund a payment. Use a payment card instead.
        /// </summary>
        [DataMember(Name="credit_card", EmitDefaultValue = false)]
        public CreditCard CreditCard { get; set; }

        /// <summary>
        /// A tokenized credit card that can be used to fund a payment.
        /// </summary>
        [DataMember(Name="credit_card_token", EmitDefaultValue = false)]
        public CreditCardToken CreditCardToken { get; set; }
    }
}

