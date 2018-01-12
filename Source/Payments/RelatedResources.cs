// This class was generated on Wed, 13 Dec 2017 14:31:45 CST by version 0.1 of Braintree SDK Generator
// RelatedResources.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The payment-related financial transactions, which include sales, authorizations, captures, and refunds. To show resource details, use the resource ID. For example, to [show details for a related authorization](/docs/api/payments/#authorization_get), use the ID returned in the `authorization` object. You can also use the [HATEOAS links](/docs/api/hateoas-links/) for a resource to complete operations for that resource. For example, a `sale` object provides a `refund` link that enables you to refund the sale.
    /// </summary>
    [DataContract]
    public class RelatedResources {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public RelatedResources() {}

        /// <summary>
        /// An authorization.
        /// </summary>
        [DataMember(Name="authorization", EmitDefaultValue = false)]
        public Authorization Authorization { get; set; }

        /// <summary>
        /// A capture transaction.
        /// </summary>
        [DataMember(Name="capture", EmitDefaultValue = false)]
        public Capture Capture { get; set; }

        /// <summary>
        /// An order transaction.
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue = false)]
        public Order Order { get; set; }

        /// <summary>
        /// A refund transaction.
        /// </summary>
        [DataMember(Name="refund", EmitDefaultValue = false)]
        public Refund Refund { get; set; }

        /// <summary>
        /// The sale transaction details.
        /// </summary>
        [DataMember(Name="sale", EmitDefaultValue = false)]
        public Sale Sale { get; set; }
    }
}

