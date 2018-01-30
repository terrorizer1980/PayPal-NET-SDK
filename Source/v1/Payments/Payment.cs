// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Payment.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A payment. Use this object to create, process, and manage payments.
    /// </summary>
    [DataContract]
    public class Payment
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payment() {}

        /// <summary>
        /// The date and time when the payment was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime;

        /// <summary>
        /// The PayPal-generated ID for the merchant's payment experience profile. For information, see [create web experience profile](/docs/api/payment-experience/#web-profiles_create).
        /// </summary>
        [DataMember(Name="experience_profile_id", EmitDefaultValue = false)]
        public string ExperienceProfileId;

        /// <summary>
        /// The reason code for a payment failure.
        /// </summary>
        [DataMember(Name="failure_reason", EmitDefaultValue = false)]
        public string FailureReason;

        /// <summary>
        /// The ID of the payment.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The payment intent. Value is:<ul><li><code>sale</code>. Makes an immediate payment.</li><li><code>authorize</code>. [Authorizes a payment for capture later](/docs/integration/direct/payments/capture-payment/).</li><li><code>order</code>. [Creates an order](/docs/integration/direct/payments/orders/).</li></ul>
        /// </summary>
        [DataMember(Name="intent", EmitDefaultValue = false)]
        public string Intent;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// A free-form field that clients can use to send a note to the payer.
        /// </summary>
        [DataMember(Name="note_to_payer", EmitDefaultValue = false)]
        public string NoteToPayer;

        /// <summary>
        /// REQUIRED
        /// A payer who funds a payment.
        /// </summary>
        [DataMember(Name="payer", EmitDefaultValue = false)]
        public Payer Payer;

        /// <summary>
        /// A set of redirect URLs that you provide for PayPal-based payments.
        /// </summary>
        [DataMember(Name="redirect_urls", EmitDefaultValue = false)]
        public RedirectUrls RedirectUrls;

        /// <summary>
        /// The state of the payment, authorization, or order transaction. Value is:<ul><li><code>created</code>. The transaction was successfully created.</li><li><code>approved</code>. The buyer approved the transaction.</li><li><code>failed</code>. The transaction request failed.</li></ul>
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;

        /// <summary>
        /// An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment. For update and execute payment calls, the **`transactions`** object accepts the **`amount`** object only.
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue = false)]
        public List<Transaction> Transactions;

        /// <summary>
        /// The date and time when the payment was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime;
    }
}

