// This class was generated on Wed, 13 Dec 2017 14:31:37 CST by version 0.1 of Braintree SDK Generator
// Payment.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A payment. Use this object to create, process, and manage payments.
    /// </summary>
    [DataContract]
    public class Payment {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Payment() {}

        /// <summary>
        /// The date and time when the payment was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The PayPal-generated ID for the merchant's payment experience profile. For information, see [create web experience profile](/docs/api/payment-experience/#web-profiles_create).
        /// </summary>
        [DataMember(Name="experience_profile_id", EmitDefaultValue = false)]
        public string ExperienceProfileId { get; set; }

        /// <summary>
        /// The reason code for a payment failure.
        /// </summary>
        [DataMember(Name="failure_reason", EmitDefaultValue = false)]
        public string FailureReason { get; set; }

        /// <summary>
        /// The ID of the payment.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// REQUIRED
        /// The payment intent. Value is:<ul><li><code>sale</code>. Makes an immediate payment.</li><li><code>authorize</code>. [Authorizes a payment for capture later](/docs/integration/direct/payments/capture-payment/).</li><li><code>order</code>. [Creates an order](/docs/integration/direct/payments/orders/).</li></ul>
        /// </summary>
        [DataMember(Name="intent", EmitDefaultValue = false)]
        public string Intent { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// A free-form field that clients can use to send a note to the payer.
        /// </summary>
        [DataMember(Name="note_to_payer", EmitDefaultValue = false)]
        public string NoteToPayer { get; set; }

        /// <summary>
        /// REQUIRED
        /// A payer who funds a payment.
        /// </summary>
        [DataMember(Name="payer", EmitDefaultValue = false)]
        public Payer Payer { get; set; }

        /// <summary>
        /// A set of redirect URLs that you provide for PayPal-based payments.
        /// </summary>
        [DataMember(Name="redirect_urls", EmitDefaultValue = false)]
        public RedirectUrls RedirectUrls { get; set; }

        /// <summary>
        /// The state of the payment, authorization, or order transaction. Value is:<ul><li><code>created</code>. The transaction was successfully created.</li><li><code>approved</code>. The buyer approved the transaction.</li><li><code>failed</code>. The transaction request failed.</li></ul>
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment. For update and execute payment calls, the **`transactions`** object accepts the **`amount`** object only.
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue = false)]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// The date and time when the payment was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }
    }
}

