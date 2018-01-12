// This class was generated on Wed, 13 Dec 2017 14:31:47 CST by version 0.1 of Braintree SDK Generator
// Order.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// An order transaction.
    /// </summary>
    [DataContract]
    public class Order {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Order() {}

        /// <summary>
        /// REQUIRED
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The date and time when the resource was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
        /// </summary>
        [DataMember(Name="fmf_details", EmitDefaultValue = false)]
        public FmfDetails FmfDetails { get; set; }

        /// <summary>
        /// The ID of the order transaction.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [DataMember(Name="parent_payment", EmitDefaultValue = false)]
        public string ParentPayment { get; set; }

        /// <summary>
        /// The transaction payment mode.
        /// </summary>
        [DataMember(Name="payment_mode", EmitDefaultValue = false)]
        public string PaymentMode { get; set; }

        /// <summary>
        /// [DEPRECATED] The reason code for the pending transaction state. Obsolete. Use `reason_code` instead.
        /// </summary>
        [DataMember(Name="pending_reason", EmitDefaultValue = false)]
        public string PendingReason { get; set; }

        /// <summary>
        /// The level of seller protection in effect for the transaction.
        /// </summary>
        [DataMember(Name="protection_eligibility", EmitDefaultValue = false)]
        public string ProtectionEligibility { get; set; }

        /// <summary>
        /// The kind of seller protection in effect for the transaction. Returned only when the `protection_eligibility` property is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported only when the `payment_method` is `paypal`. One or both of these values can be returned:<ul><li><code>ITEM_NOT_RECEIVED_ELIGIBLE</code>. Sellers are protected against claims for items not received.</li><li><code>UNAUTHORIZED_PAYMENT_ELIGIBLE</code>. Sellers are protected against claims for unauthorized payments.</li></ul>
        /// </summary>
        [DataMember(Name="protection_eligibility_type", EmitDefaultValue = false)]
        public string ProtectionEligibilityType { get; set; }

        /// <summary>
        /// The reason code that describes why the transaction state is pending or reversed. Eventually, this parameter will replace the `pending_reason` parameter. Supported only when the `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="reason_code", EmitDefaultValue = false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// The ID of the purchase unit that is associated with this object. Obsolete. Used only in `cart_base`.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The order transaction state. Value is:<ul><li><code>pending</code>. The order was created but no authorizations/captures were made against the order.</li><li><code>authorized</code>. The order has only been authorized. No capture was made against the order.</li><li><code>captured</code>. The order has at least one capture initiated.</li><li><code>completed</code>. The order is complete as a capture was made against the order with <code>is_final_capture</code> set to <code>TRUE</code>. No more authorizations/captures can be made against this order.</li><li><code>voided</code>. The order was voided. No more authorizations/captures can be made against this order.</li></ul>
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }
    }
}

