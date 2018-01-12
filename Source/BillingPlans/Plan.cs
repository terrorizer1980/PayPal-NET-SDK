// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// Plan.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// A billing plan. You can base one or more agreements on an active plan.
    /// </summary>
    [DataContract]
    public class Plan {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Plan() {}

        /// <summary>
        /// The date and time when the plan was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// REQUIRED
        /// The plan description. Maximum length is 127 single-byte alphanumeric characters.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the plan.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
        /// </summary>
        [DataMember(Name="merchant_preferences", EmitDefaultValue = false)]
        public MerchantPreferences MerchantPreferences { get; set; }

        /// <summary>
        /// REQUIRED
        /// The plan name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A payment definition, which determines how often and for how long the customer is charged. Includes the interval at which the customer is charged, the charge amount, and optional shipping fees and taxes.
        /// </summary>
        [DataMember(Name="payment_definitions", EmitDefaultValue = false)]
        public List<PaymentDefinition> PaymentDefinitions { get; set; }

        /// <summary>
        /// The plan status.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// An array of terms for this plan. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue = false)]
        public List<Terms> Terms { get; set; }

        /// <summary>
        /// REQUIRED
        /// The plan type. Indicates whether the payment definitions in the plan have a fixed number of or infinite payment cycles. Value is:<ul><li><code>FIXED</code>. The plan has a fixed number of payment cycles.</li><li><code>INFINITE</code>. The plan has infinite, or <code>0</code>, payment cycles.</li></ul>
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The date and time when the plan was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }
    }
}

