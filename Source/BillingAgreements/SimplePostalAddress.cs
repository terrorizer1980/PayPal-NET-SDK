// This class was generated on Wed, 13 Dec 2017 14:32:58 CST by version 0.1 of Braintree SDK Generator
// SimplePostalAddress.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yWQW/bRhOG79+vGPC7WABF2kmRg262gwZpkdiI7V5UoxntjsSpl7v07DAyU+S/F7tUZdV2UKsofDHA4TzDmdl3X+uP4nLoqJgVF9x2juA8REUHx9YKxViUxS8ojAtHH7FNaUVZvKVohDvl4ItZcQxxJLuRxJGENWsDJqBEmq4E2ZOFJZOzsYK3AXxQ6CPBMgigB/ZK4jHVvK9RwdUmY4HmZo1iwYS2Q+UFO9YBgndDqkYx1zPBK7KHrgmeqqIsjkVwGOc7LItPhPbMu6GYLdFFSoHbnoXsNnAuoSNRpljM5tvNRBX2q8erMKzDo3VcNgTpBXhs9+tBpX/Qgu+d+1b+cx+h9yrDbyZYerKfua7D1DQoaJQE3l+cweujN2+mR5CQ64PaBhPrdAQryUdQWxYyWgtFrTflpyk31hPQBhXYkldeMkXQNPGYA0FAaMXBV7/2h4evzcIFc3PbB6X8PP41USX41Rj5GJRmY7jejcPlTtn06ayDd0KocCKcz5kjjGR6P2LvTja17kOA3mZ5PMy9+vmJ3JhUaYF9nktDN3X0hRzY0KZPplONuZW8hk2Do1AT8Pn01efHbZ827BHWQZxd8yaWlSzpGKH3SbkSnCMLnbAhODi9Op9AS9oEW8IC/Q0YFFvmYYyEGKeLIJYEVNBHNOnY4mbr9cO1v4gMHXs6elJ/S5aokN5DWOY1bS/4j0GA7jAZSAm+bxckJUQVIh1njQGCr15sgFePBjjrRlOqsiIjmeDtM2aJPSuVgB2KtuR1O9y/G+oJg3rmVKMtf98cNrad3pewbtg06V6lwb5yN0o4zXXb8xd05LWCy6Fjg84NIJv+NoJOqk+OkK0fdyvD6PK7VS6IYH5+n3J90Kh2cVbX5Ks133BHlrEKsqrTU31+P8fkhVYXFfU7jvoc48z41jbzPzq4uoAchuwgtLORnBC0oZ1NVvBpd8O7Vx34b+pLZ8YewlaWke7LzGB+LKtk2B73afr/+Bc1KWF+IviV3V78IiMJPkWPdr+Pm4wk+L23vB/Licioohv2QxOR0J+wQ78X+nsiEvqB7tiEvdg2Iwm+bJAdersXrhtoUiZlza88K1m4SClxr0J9xEkFH/CO274FR36l2RB+OITIfuVouhiUYPtrIv4nd/H62//+BAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
    /// </summary>
    [DataContract]
    public class SimplePostalAddress {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SimplePostalAddress() {}

        /// <summary>
        /// REQUIRED
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
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [Postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The [code](/docs/integration/direct/rest/state-codes/) for a US state or the equivalent for other countries. Required for transactions if the address is in one of these countries: [Argentina](/docs/integration/direct/rest/state-codes/#argentina), [Brazil](/docs/integration/direct/rest/state-codes/#brazil), [Canada](/docs/integration/direct/rest/state-codes/#canada), [India](/docs/integration/direct/rest/state-codes/#india), [Italy](/docs/integration/direct/rest/state-codes/#italy), [Japan](/docs/integration/direct/rest/state-codes/#japan), [Mexico](/docs/integration/direct/rest/state-codes/#mexico), [Thailand](/docs/integration/direct/rest/state-codes/#thailand), or [United States](/docs/integration/direct/rest/state-codes/#usa). Maximum length is 40 single-byte characters.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }
    }
}

