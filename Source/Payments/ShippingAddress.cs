// This class was generated on Wed, 13 Dec 2017 14:31:40 CST by version 0.1 of Braintree SDK Generator
// ShippingAddress.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xWTXPbRg++v78Cw/cSzVCk7LQ56Ja4ietmHHlsuT2oHgniQiLq5S69C0amO/nvnSVpSa6VqeV2dNGIAB4Qnw/4ZzSuS4qGkc+5LNksp6iUI++jOPoVHeNc0xcsgkUURz+RzxyXwtZEw2icE9C9kFGkoIPFsMo5y4E9VD6IPUhO8Oj90QzYAEKJdUFGkiiO3juHdRvKII4uCdXI6DoaLlB7CoK7ih2pteDC2ZKcMPloONkkIY7N8nnoGUu9M/ygAIMF/dsYTKX1t/ifA7GVEVdPM6toZ0ATWdl+lqPDTMjB2dUI3h69e9c/ggC5eZMqm/mUjdDSYcClih1lkjryknbu+8HWpz2QHAVYkRFeMLWt6GzAOnC0ZGuS36vB4G021za7vausUPPc/mZenDXLVvLFCg1bcboth/GW2/BqWFgHp45Q4INjQTZhHlpk0Lew0w+dr40I0CgwVp7ZXn/eYduNGJsmL7FlX9NX0qBsEV4Z2uqbUJoydAEmcO2pAcxOjmfPwz7J2SCsrNNqxZ0ss0WJLrQRKpNZI85qTQpKxxnBm5Prix4UJLlVMczR3EKGTsVNMpmz3vfn1ilyIA6Nxyy0zXdVT/9e9n3mUFz1ujHUbOho5/wt2HmBoAe7aMrUbWwCn6wDusei1BSDqYo5uRi8OCJpc/UWrEkOlsDxswRGzR/USTORnjJr1Aty8RULxYAlOgl8tE7udUm9nh2MdQVqfmgWe+oFpfI7u/TIok8A0AISuCSpnCEF1ui6GeASa3IeFs4W8MHhA+sDZVTm1uwmukazrjQbmHxMjo7fhnALlJs3uUjph2m6Wq0SliphEzguS8f9y48n/ca2fzwYHA2O+2cpmV4C53jPRVWAJrOU5gL9OIA1lfpDZWy9oP4+wbf6hm+2bmUYzgcuWxoKs3lX8VfU4TjCuC45Q61rcF18HSkF5gqsvmLJwzXdeA4u0DzxckUEk4uNyabCZJIV33JJijGxbpmGp/Rik0fvQKVzlHHJZGQaqHtn9YLicZnX5oACkrNfr/dhwg3r9p0j/pJb3cDXlzp0FOH6qlnipn8hxU0DGwMrOW01Pmz61kBsXxfgJ4QXRowN2DUTetq4GcLkvVuGbwSD+wT9f3xE9WKYtLSyF37eQAL4BA2q/V6eNZAAPjOK98NyQDRQQV3vBw2IAP0FSzR7Qf8IiAA9p3vO7F7YooEE8DhH1mjUXnDpQL04TNbk2rCQgqtg4vdyVHncybQ/DMCzWWrqz2uhw7PuC25ldx0PE48E9a5ogiLs4O4vkdnPo/OP09Hl9LfR5edZDLPTs0/j2X/9IXLz7X9/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The extended address, which is used as the shipping address in a payment.
    /// </summary>
    [DataContract]
    public class ShippingAddress {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public ShippingAddress() {}

        /// <summary>
        /// The city name.
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// REQUIRED
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// REQUIRED
        /// The first line of the address. For example, number, street, and so on.
        /// </summary>
        [DataMember(Name="line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Optional. The second line of the address. For example, suite, apartment number, and so on.
        /// </summary>
        [DataMember(Name="line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// The address normalization status. Returned only for payers from Brazil.
        /// </summary>
        [DataMember(Name="normalization_status", EmitDefaultValue = false)]
        public string NormalizationStatus { get; set; }

        /// <summary>
        /// The phone number, in [E.123 format](https://www.itu.int/rec/T-REC-E.123-200102-I/en). Maximum length is 50 characters.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [Postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The name of the recipient at this address.
        /// </summary>
        [DataMember(Name="recipient_name", EmitDefaultValue = false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// The [code](/docs/integration/direct/rest/state-codes/) for a US state or the equivalent for other countries. Required for transactions if the address is in one of these countries: [Argentina](/docs/integration/direct/rest/state-codes/#argentina), [Brazil](/docs/integration/direct/rest/state-codes/#brazil), [Canada](/docs/integration/direct/rest/state-codes/#canada), [India](/docs/integration/direct/rest/state-codes/#india), [Italy](/docs/integration/direct/rest/state-codes/#italy), [Japan](/docs/integration/direct/rest/state-codes/#japan), [Mexico](/docs/integration/direct/rest/state-codes/#mexico), [Thailand](/docs/integration/direct/rest/state-codes/#thailand), or [United States](/docs/integration/direct/rest/state-codes/#usa). Maximum length is 40 single-byte characters.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The address status.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of address. For example, `HOME_OR_WORK`, `GIFT`, and so on.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

