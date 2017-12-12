// This class was generated on Tue, 12 Dec 2017 12:38:03 CST by version 0.1 of Braintree SDK Generator
// UserAddress.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7zTwUoDMRAG4LtPMczFyyKe9yZ6VpHiRaSkyb9tIE3iZCKs0neXdNsitOJB6W13Zv7hIySfPBszuOdaIHPjnKAU7vjZiDeLgHuzbl3u+A7Fis/qU+SeZysQoqMWuyyUBQNE4Gi34oo7vhEx47T+uuMnGPcQw8j9YEJBK7xVL3CHwqOkDFGPwv3LAVZUfFwek2yqUWU8Kdv1/oqINYRN96skJGuC1x8oXkdKQvuhM5lyKmrC3CaHk6wPn6k1G22a3f6eSSdYNsopWFGj6ChLevfRbr8wwGoVdA07Rc/kLCqAfnsWx96hhkDT3OHu062J5KMN1YF0BVqlWkCxrhcQMtHtA9Gs/+fIXzcXXwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Identity
{
    /**
    * The end user's preferred address.
    */
    [DataContract]
    public class UserAddress {

        // Required default constructor
        public UserAddress() {}

        /**
        * The country.
        */
        [DataMember(Name="country")]
        public string Country { get; set; }

        /**
        * The city or locality.
        */
        [DataMember(Name="locality")]
        public string Locality { get; set; }

        /**
        * The zip code or postal code.
        */
        [DataMember(Name="postal_code")]
        public string PostalCode { get; set; }

        /**
        * The state, province, prefecture, or region.
        */
        [DataMember(Name="region")]
        public string Region { get; set; }

        /**
        * The full street address. Can include the house number and street name.
        */
        [DataMember(Name="street_address")]
        public string StreetAddress { get; set; }
    }
}

