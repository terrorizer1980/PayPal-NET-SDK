// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Item.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/8yUQWvbQBCF7/0Vw54SsK0kFAK+BXopaRsTJ72EHKarsTV4tavMzhYvJf+9bFW7Vl3TlhaTk3hvZ4f3aTT6Yu5yR2ZqWKk1I/MRhfGTow/YFteMzDXlH+INRSvcKQdvpuauISj3oCZFdnFiRuZKBHPf82xkbgnrG++ymS7QRSrGU2KhemvMJHQkyhTN9GGbJqqwX+7nsUmEvM2DXDvmfr4HbYRobBsUtEoCb+c349cX55ewuQY21PR4UtXBxoq90lKwNKhqFrJaCUWtNsXjUhyr079CVUk/kfrk3PPot7j1Ds4u8dA/OJStPYF56rogSjUE7zIsgoA2BDPMM3TQYW7JK7SkTaj/dYx/COfLY5fqu3EAp5xO4D2uuU0tOPJLbYAjnF9cwna68Thz6YTtMPvGORDehqi/DH929OxPCb2yDldoxzxAsKl4IRRxlQYAvd7PHjXYFayIOvZLSJ4VTubX96fbDShwR/rgFdeDzL0+8L4V1y9ya5O4AUSv9yHub9+Bhp6F/SJIi/2f6OozsisNy3Gh6TCTAPtvQgV9RFtKoeGoQfJ/AXt8fvUVAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The item details.
    /// </summary>
    [DataContract]
    public class Item
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Item() {}

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue = false)]
        public string Currency;

        /// <summary>
        /// The item description. Supported only for the PayPal payment method.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The item name. Maximum length is 127 characters.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The item cost. Maximum length is 10 characters.
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue = false)]
        public string Price;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Maximum length is 10 characters.
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue = false)]
        public string Quantity;

        /// <summary>
        /// The stock keeping unit (SKU) for the item.
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue = false)]
        public string Sku;

        /// <summary>
        /// The item tax. Supported only for the PayPal payment method.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public string Tax;

        /// <summary>
        /// The URL to item information. Available to the payer in the transaction history.
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue = false)]
        public string Url;
    }
}

