// This class was generated on Wed, 13 Dec 2017 14:31:38 CST by version 0.1 of Braintree SDK Generator
// Payer.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A payer who funds a payment.
    /// </summary>
    [DataContract]
    public class Payer {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Payer() {}

        /// <summary>
        /// An array of a single funding instrument for the current payment. Valid only and required for the credit card payment method. The array must include either a `credit_card` or `credit_card_token` object. If the array contains more than one instrument, the payment is declined.
        /// </summary>
        [DataMember(Name="funding_instruments", EmitDefaultValue = false)]
        public List<FundingInstrument> FundingInstruments { get; set; }

        /// <summary>
        /// The payer information.
        /// </summary>
        [DataMember(Name="payer_info", EmitDefaultValue = false)]
        public PayerInformation PayerInfo { get; set; }

        /// <summary>
        /// The payment method. Value is PayPal Wallet payment, bank direct debit, or direct credit card.
        /// </summary>
        [DataMember(Name="payment_method", EmitDefaultValue = false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The status of payer's PayPal account.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }
    }
}

