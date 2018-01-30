// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Authorization.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// An authorization.
    /// </summary>
    [DataContract]
    public class Authorization
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Authorization() {}

        /// <summary>
        /// REQUIRED
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount;

        /// <summary>
        /// The date and time when the authorization was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime;

        /// <summary>
        /// The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
        /// </summary>
        [DataMember(Name="fmf_details", EmitDefaultValue = false)]
        public FmfDetails FmfDetails;

        /// <summary>
        /// The ID of the authorization.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [DataMember(Name="parent_payment", EmitDefaultValue = false)]
        public string ParentPayment;

        /// <summary>
        /// The payment mode of the authorization.
        /// </summary>
        [DataMember(Name="payment_mode", EmitDefaultValue = false)]
        public string PaymentMode;

        /// <summary>
        /// [DEPRECATED] The reason code for the pending transaction state. Obsolete. Use `reason_code` instead.
        /// </summary>
        [DataMember(Name="pending_reason", EmitDefaultValue = false)]
        public string PendingReason;

        /// <summary>
        /// A collection of payment response-related fields returned from a payment request.
        /// </summary>
        [DataMember(Name="processor_response", EmitDefaultValue = false)]
        public ProcessorResponse ProcessorResponse;

        /// <summary>
        /// The level of seller protection present for the transaction. Supported for the PayPal payment method only. Value is:<ul><li><code>ELIGIBLE</code>. Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.</li><li><code>PARTIALLY_ELIGIBLE</code>. Merchant is protected by PayPal's Seller Protection Policy for Item Not Received or Unauthorized Payments. For details, see `protection_eligibility_type`.</li><li><code>INELIGIBLE</code>. Merchant is not protected under the Seller Protection Policy.</li></ul>
        /// </summary>
        [DataMember(Name="protection_eligibility", EmitDefaultValue = false)]
        public string ProtectionEligibility;

        /// <summary>
        /// The type of seller protection present for the transaction. Returned only when the `protection_eligibility` property is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported for the PayPal payment method only.<br/><br/>Returns one or both of the allowed values.<br/><br/>Value is:<ul><li><code>ITEM_NOT_RECEIVED_ELIGIBLE</code>. Sellers are protected against claims for items not received.</li><li><code>UNAUTHORIZED_PAYMENT_ELIGIBLE</code>. Sellers are protected against claims for unauthorized payments.</li></ul>
        /// </summary>
        [DataMember(Name="protection_eligibility_type", EmitDefaultValue = false)]
        public string ProtectionEligibilityType;

        /// <summary>
        /// The reason code for the pending transaction state.
        /// </summary>
        [DataMember(Name="reason_code", EmitDefaultValue = false)]
        public string ReasonCode;

        /// <summary>
        /// The receipt ID, which identifies the payment. Value is 16-digit numeric payment ID number that is returned for guest users.
        /// </summary>
        [DataMember(Name="receipt_id", EmitDefaultValue = false)]
        public string ReceiptId;

        /// <summary>
        /// The ID of the purchase or transaction unit that corresponds to this authorization transaction.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId;

        /// <summary>
        /// The authorization state.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;

        /// <summary>
        /// The date and time when the authorization was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime;

        /// <summary>
        /// The date and time when the authorization expires, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="valid_until", EmitDefaultValue = false)]
        public string ValidUntil;
    }
}

