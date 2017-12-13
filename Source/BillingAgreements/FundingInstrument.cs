// This class was generated on Wed, 13 Dec 2017 14:32:58 CST by version 0.1 of Braintree SDK Generator
// FundingInstrument.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// Information about a customer's funding instrument.
    /// </summary>
    [DataContract]
    public class FundingInstrument {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FundingInstrument() {}

        /// <summary>
        /// A bank account that can be used to fund a payment. Supports Single Euro Payments Area (SEPA) bank accounts.
        /// </summary>
        [DataMember(Name="bank_account", EmitDefaultValue = false)]
        public ExtendedBankAccount BankAccount { get; set; }

        /// <summary>
        /// A token for a bank card. Can be used to fund a payment.
        /// </summary>
        [DataMember(Name="bank_account_token", EmitDefaultValue = false)]
        public BankToken BankAccountToken { get; set; }

        /// <summary>
        /// A payment card that can be used to fund a payment.
        /// </summary>
        [DataMember(Name="payment_card", EmitDefaultValue = false)]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// A token for a payment card that can be used to fund a payment.
        /// </summary>
        [DataMember(Name="payment_card_token", EmitDefaultValue = false)]
        public PaymentCardToken PaymentCardToken { get; set; }
    }
}

