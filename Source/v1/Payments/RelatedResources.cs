// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// RelatedResources.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payment-related financial transactions, which include sales, authorizations, captures, and refunds. To show resource details, use the resource ID. For example, to [show details for a related authorization](/docs/api/payments/#authorization_get), use the ID returned in the `authorization` object. You can also use the [HATEOAS links](/docs/api/hateoas-links/) for a resource to complete operations for that resource. For example, a `sale` object provides a `refund` link that enables you to refund the sale.
    /// </summary>
    [DataContract]
    public class RelatedResources
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RelatedResources() {}

        /// <summary>
        /// An authorization.
        /// </summary>
        [DataMember(Name="authorization", EmitDefaultValue = false)]
        public Authorization Authorization;

        /// <summary>
        /// A capture transaction.
        /// </summary>
        [DataMember(Name="capture", EmitDefaultValue = false)]
        public Capture Capture;

        /// <summary>
        /// An order transaction.
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue = false)]
        public Order Order;

        /// <summary>
        /// A refund transaction.
        /// </summary>
        [DataMember(Name="refund", EmitDefaultValue = false)]
        public Refund Refund;

        /// <summary>
        /// The sale transaction details.
        /// </summary>
        [DataMember(Name="sale", EmitDefaultValue = false)]
        public Sale Sale;
    }
}

