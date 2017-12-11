// This class was generated on Mon, 11 Dec 2017 13:16:16 CST by version 0.1 of Braintree SDK Generator
// Authorization.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * An authorization.
    */
    [DataContract]
    public class Authorization {

        // Required default constructor
        public Authorization() {}

        /**
        * REQUIRED
        * The payment amount, with break-ups.
        */
        [DataMember(Name="amount")]
        public Amount Amount { get; set; }

        /**
        * The date and time when the authorization was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
        */
        [DataMember(Name="fmf_details")]
        public FmfDetails FmfDetails { get; set; }

        /**
        * The ID of the authorization.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The ID of the payment on which this transaction is based.
        */
        [DataMember(Name="parent_payment")]
        public string ParentPayment { get; set; }

        /**
        * The payment mode of the authorization.
        */
        [DataMember(Name="payment_mode")]
        public string PaymentMode { get; set; }

        /**
        * [DEPRECATED] The reason code for the pending transaction state. Obsolete. Use `reason_code` instead.
        */
        [DataMember(Name="pending_reason")]
        public string PendingReason { get; set; }

        /**
        * A collection of payment response-related fields returned from a payment request.
        */
        [DataMember(Name="processor_response")]
        public ProcessorResponse ProcessorResponse { get; set; }

        /**
        * The level of seller protection present for the transaction. Supported for the PayPal payment method only. Value is:<ul><li><code>ELIGIBLE</code>. Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.</li><li><code>PARTIALLY_ELIGIBLE</code>. Merchant is protected by PayPal's Seller Protection Policy for Item Not Received or Unauthorized Payments. For details, see `protection_eligibility_type`.</li><li><code>INELIGIBLE</code>. Merchant is not protected under the Seller Protection Policy.</li></ul>
        */
        [DataMember(Name="protection_eligibility")]
        public string ProtectionEligibility { get; set; }

        /**
        * The type of seller protection present for the transaction. Returned only when the `protection_eligibility` property is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported for the PayPal payment method only.<br/><br/>Returns one or both of the allowed values.<br/><br/>Value is:<ul><li><code>ITEM_NOT_RECEIVED_ELIGIBLE</code>. Sellers are protected against claims for items not received.</li><li><code>UNAUTHORIZED_PAYMENT_ELIGIBLE</code>. Sellers are protected against claims for unauthorized payments.</li></ul>
        */
        [DataMember(Name="protection_eligibility_type")]
        public string ProtectionEligibilityType { get; set; }

        /**
        * The reason code for the pending transaction state.
        */
        [DataMember(Name="reason_code")]
        public string ReasonCode { get; set; }

        /**
        * The receipt ID, which identifies the payment. Value is 16-digit numeric payment ID number that is returned for guest users.
        */
        [DataMember(Name="receipt_id")]
        public string ReceiptId { get; set; }

        /**
        * The ID of the purchase or transaction unit that corresponds to this authorization transaction.
        */
        [DataMember(Name="reference_id")]
        public string ReferenceId { get; set; }

        /**
        * The authorization state.
        */
        [DataMember(Name="state")]
        public string State { get; set; }

        /**
        * The date and time when the authorization was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }

        /**
        * The date and time when the authorization expires, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="valid_until")]
        public string ValidUntil { get; set; }
    }
}

