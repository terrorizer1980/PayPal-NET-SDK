// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// TransactionDetails.cs
// @version 0.1.0-dev+27d306
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// The transaction details.
    /// </summary>
    [DataContract]
    public class TransactionDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TransactionDetails() {}

        /// <summary>
        /// The auction information.
        /// </summary>
        [DataMember(Name="auction_info", EmitDefaultValue = false)]
        public AuctionInformation AuctionInfo;

        /// <summary>
        /// The cart information.
        /// </summary>
        [DataMember(Name="cart_info", EmitDefaultValue = false)]
        public CartInformation CartInfo;

        /// <summary>
        /// The incentive details.
        /// </summary>
        [DataMember(Name="incentive_info", EmitDefaultValue = false)]
        public IncentiveInformation IncentiveInfo;

        /// <summary>
        /// The payer information.
        /// </summary>
        [DataMember(Name="payer_info", EmitDefaultValue = false)]
        public PayerInformation PayerInfo;

        /// <summary>
        /// The shipping information.
        /// </summary>
        [DataMember(Name="shipping_info", EmitDefaultValue = false)]
        public ShippingInformation ShippingInfo;

        /// <summary>
        /// The store information.
        /// </summary>
        [DataMember(Name="store_info", EmitDefaultValue = false)]
        public StoreInformation StoreInfo;

        /// <summary>
        /// The transaction information.
        /// </summary>
        [DataMember(Name="transaction_info", EmitDefaultValue = false)]
        public TransactionInformation TransactionInfo;
    }
}

