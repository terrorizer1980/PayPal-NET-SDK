// This class was generated on Mon, 11 Dec 2017 13:16:27 CST by version 0.1 of Braintree SDK Generator
// Sale.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The sale transaction details.
    */
    [DataContract]
    public class Sale {

        // Required default constructor
        public Sale() {}

        /**
        * REQUIRED
        * The payment amount, with break-ups.
        */
        [DataMember(Name="amount")]
        public Amount Amount { get; set; }

        /**
        * The ID of the billing agreement. Used as reference to execute this transaction.
        */
        [DataMember(Name="billing_agreement_id")]
        public string BillingAgreementId { get; set; }

        /**
        * The date and time when the eCheck transaction is expected to clear, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Returned for eCheck payments. Supported only when the `payment_method` is `paypal`.
        */
        [DataMember(Name="clearing_time")]
        public string ClearingTime { get; set; }

        /**
        * REQUIRED
        * The date and time of the sale, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * The exchange rate for this transaction. Returned only in cross-currency use cases where a merchant bills a buyer in a non-primary currency for that buyer.
        */
        [DataMember(Name="exchange_rate")]
        public string ExchangeRate { get; set; }

        /**
        * The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
        */
        [DataMember(Name="fmf_details")]
        public FmfDetails FmfDetails { get; set; }

        /**
        * REQUIRED
        * The ID of the sale transaction.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * REQUIRED
        * The ID of the payment on which this transaction is based.
        */
        [DataMember(Name="parent_payment")]
        public string ParentPayment { get; set; }

        /**
        * An array of reasons that PayPal holds the recipient fund. Set only if the payment hold status is `HELD`.
        */
        [DataMember(Name="payment_hold_reasons")]
        public List<string> PaymentHoldReasons { get; set; }

        /**
        * The recipient fund status. Returned only when the fund status is `held`.
        */
        [DataMember(Name="payment_hold_status")]
        public string PaymentHoldStatus { get; set; }

        /**
        * The transaction payment mode. Supported only when `payment_method` is `paypal`.
        */
        [DataMember(Name="payment_mode")]
        public string PaymentMode { get; set; }

        /**
        * A collection of payment response-related fields returned from a payment request.
        */
        [DataMember(Name="processor_response")]
        public ProcessorResponse ProcessorResponse { get; set; }

        /**
        * The seller protection level in effect for the transaction. Supported only when the `payment_method` is `paypal`.
        */
        [DataMember(Name="protection_eligibility")]
        public string ProtectionEligibility { get; set; }

        /**
        * The seller protection type in effect for the transaction. Returned only when `protection_eligibility` is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported only when the `payment_method` is `paypal`.
        */
        [DataMember(Name="protection_eligibility_type")]
        public string ProtectionEligibilityType { get; set; }

        /**
        * The ID of the transaction that corresponds to this sale transaction.
        */
        [DataMember(Name="purchase_unit_reference_id")]
        public string PurchaseUnitReferenceId { get; set; }

        /**
        * A reason code that describes why the transaction state is pending or reversed. Supported only when the `payment_method` is `paypal`.
        */
        [DataMember(Name="reason_code")]
        public string ReasonCode { get; set; }

        /**
        * The receipt ID, which is a payment ID number that is returned for guest users to identify the payment.
        */
        [DataMember(Name="receipt_id")]
        public string ReceiptId { get; set; }

        /**
        * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="receivable_amount")]
        public Currency ReceivableAmount { get; set; }

        /**
        * REQUIRED
        * The sale transaction state.
        */
        [DataMember(Name="state")]
        public string State { get; set; }

        /**
        * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="transaction_fee")]
        public Currency TransactionFee { get; set; }

        /**
        * The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }
    }
}

