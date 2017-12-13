// This class was generated on Wed, 13 Dec 2017 14:31:39 CST by version 0.1 of Braintree SDK Generator
// Address.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yVwXLbRg/H799TYPhdohmKlJ02B90SNUndTCKPLbcHNWNBXEhEs9yld8HIdCfv3tmlLMm1MrXcji4ea4EfCGCxf/yZTNqakmGCSjnyPkmTX9ExzjV9wioYkjT5iXzhuBa2Jhkmk5JgzlqzWcKaAjaAUGNbkZEMRmhgTkC3QkaRgoV14Euu6x0kS9LktXPYdt8fpMkFoRob3SbDBWpP4eCmYUdqc3DubE1OmHwynG4y9+LYLB8nXrC0e5MPBjBY0b/NwTRaf0v/ORHbGHHtdWEV7U1oKivbL0p0WAg5OLscw8uTV6/6JxCQzy9yZQufsxFaOgxcrthRIbkjL/k6fD/4+rwHUqIAKzLCCyYPEkrufMA6cLRka7Lfm8HgZTHXtvhy01ih+Lv7W3hx1iy7k09WaNgd57vnMNkJGz4db/m9IxR441iQDbCHjgz2Dnv/Zh1rewRoFBgrj3yvPuzx9dB4UmHgQl1i676mr6RB2Sp8Mlyrj6nENqwTzODKUwRmo9PZ47RHJRuElXVarXh9VtiqRheuERpTWCPOak0KascFwYvR1XkPKpLSqhTmaL5AgU6lsZjCWe/7c+sUORCHxmMRrs2vu57/ve2HzKG45nljqNnQyd75W7DzAsEOdhHbdP9I4Z11QLdY1ZpSME01J5eCF0ckXa3egjXZ0Qo4fVTAOP6DOosT6amwRj2hFt+wUApYo5OgWpvinlfU89XBWFeh5rv4sK+9oDR+7y3da+0DADoggwuSxhlSYI1u4wDX2JLzsHC2gjcO71gfqaK6tGa/0EXLptNsYPo2Ozl9GdKtUD6/KEVqP8zz1WqVsTQZm6BxRT7pX7wd9aNv/3QwOBmc9s9yMr0MPuItV00FmsxSyqA4Pw5gI6X+WBVbL6i/L/CdPepNCquSi5hpGM47rjsZCrN50/BX1HGFTtqaC9S6BbfOby1KQbmCqq9YyrBzt5FDCDQPolwSwfR867LtMJlsxV+4JsWYWbfMw6/8fFtH70itC/P7na34lOUX8c3qCy1CuLqMryI2JPR425HoYKWknU6Gp7PT4V25Bn6gIOHO2IDdSIunbZghTF+7ZVi6Bg9J+v94T/VSmHbv9CB+HpEAj9CgOuzjRUQCfGYUH8ZyICIqqNvD0EAE9Bes0RyE/hGIgH6kWy7sQWwVkQBPSmSNRh2EyxrqpWGypleGhRRcBhd/UKDG417p+mEAns1SU3/eCh1fxp6wfNbr5jj5SDDvyyYYwhvcv9pnP48/vr0eX1z/Nr74MEth9v7s3WT2X2/2z9/+9xcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The billing address in a payment. Can be extended for shipping address.
    /// </summary>
    [DataContract]
    public class Address {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Address() {}

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

