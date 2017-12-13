// This class was generated on Wed, 13 Dec 2017 14:32:41 CST by version 0.1 of Braintree SDK Generator
// UserAddress.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7zTwUoDMRAG4LtPMczFyyKe9yZ6VpHiRaSkyb9tIE3iZCKs0neXdNsitOJB6W13Zv7hIySfPBszuOdaIHPjnKAU7vjZiDeLgHuzbl3u+A7Fis/qU+SeZysQoqMWuyyUBQNE4Gi34oo7vhEx47T+uuMnGPcQw8j9YEJBK7xVL3CHwqOkDFGPwv3LAVZUfFwek2yqUWU8Kdv1/oqINYRN96skJGuC1x8oXkdKQvuhM5lyKmrC3CaHk6wPn6k1G22a3f6eSSdYNsopWFGj6ChLevfRbr8wwGoVdA07Rc/kLCqAfnsWx96hhkDT3OHu062J5KMN1YF0BVqlWkCxrhcQMtHtA9Gs/+fIXzcXXwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Identity
{
    /// <summary>
    /// The end user's preferred address.
    /// </summary>
    [DataContract]
    public class UserAddress {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public UserAddress() {}

        /// <summary>
        /// The country.
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The city or locality.
        /// </summary>
        [DataMember(Name="locality", EmitDefaultValue = false)]
        public string Locality { get; set; }

        /// <summary>
        /// The zip code or postal code.
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state, province, prefecture, or region.
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// The full street address. Can include the house number and street name.
        /// </summary>
        [DataMember(Name="street_address", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }
    }
}

