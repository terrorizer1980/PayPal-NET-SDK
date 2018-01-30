// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Address.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/7xWTXPbRgy991dg2Es8Q5Gy0+agW+ImqZtJ7LHl9qBmLIgLiWiWu8wuGJnp5L93dkV9leo0Sju6aEQAD8R7iwX4ZzJua0pGCSrlyPskTX5FxzjT9A6r4EjS5A2124efyBeOa2FrklEyLglmrDWbBXQpgA0g1NhWZCSDSzQwI6BHIaNIwdw68CXX9Q4kS9LkuXPYrooZpsktobo2uk1Gc9SeguFjw47UxnDjbE1OmHwymmxoeHFsFn0WBUu7x6Qz9NkEBxis6L8WZRqtv6T/XpltjLj2obCK9ivcd/QrncjSDooSHRZCDq7uruHp+bNng3MIkPdPcmULn7MRWjgMuFyxo0JyR17yLv0gxPr8DKREAVZkhOdMHiRosYoB68DRgq3Jfm+Gw6fFTNviw8fGCsXn1W/hxVmzWFneWaHRypzv2mG8kza8OvbDa0co8MKxIBtgDytk8K9gr190ubYmQKPAWOnF3r85EOuh8aRCawZeYuuBpk+kQdkqvDKct4+lRBm6AjO49xQB08uLab/sy5INwtI6rZbc2Qpb1ejC+UJjCmvEWa1JQe24IHhyeX9zBhVJaVUKMzQfoECn0kimcNb7wcw6RQ7EofFYhGPzner532U/pkHFNd/Wn5oNne815trS78g5Oy8Q/GDnUbj1BYdX1gE9YlVrSsE01YxcCl4ckazYewvWZCejdNGjdNGjdB3/oM5i13oqrFFfwc43LJQC1ugkzMAN3W+j+e2jxVhXoebP8fI/eEFp/B7tfwjoH+x6tO8BYAXI4JakcYYUWKPbeAtqbMl5mDtbwQuHn1mfiHJdWrM/RteWPqno2RwOG5i8zM4vngYCFcr7J6VI7Ud5vlwuM5YmYxNGZ5GPB7cvLwcxdnAxHJ4PLwZXOZmzDN7iI1dNBZrMQsowyH4cwmZC+1NpYL2g7i+UffsBPaI/jrcUliUXkUHo889cr6ZeaPOPDX9CHXf7uK25QK1bcF3d3QwMgzIskSVLGT4GtplDCjR7We6IYHKzDdkqTyZb8geuSTFm1i3y8JTfbHmcnUjS0On7Yq4tB9by12zfCN/s3iAawv1dvFFRoqD6VqMYYKWkHW3DtdvRfHdfAO+Np3CKbMBu5panbZoRTJ67Rdj6Bo8p+ntco85SmKzu+FH4WYQE8CUaVMe9vIiQAL4yio/DckBEqKBuj4MGRID+gjWao6B/BESAvqVHLuxR2CpCAnhcIms06ii4dKCzNHTW5N6wkIK7EOKPStR4PDjkfhiCZ7PQNJi1QqcfeAc221fssm57naZECe7dAjtDv7zgCPf08LfF9Ofrty8frm8ffru+fTNNYfr66tV4+n9/Wrz/8t1fAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The billing address in a payment. Can be extended for shipping address.
    /// </summary>
    [DataContract]
    public class Address
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Address() {}

        /// <summary>
        /// The city name.
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue = false)]
        public string City;

        /// <summary>
        /// REQUIRED
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        /// <summary>
        /// REQUIRED
        /// The first line of the address. For example, number, street, and so on.
        /// </summary>
        [DataMember(Name="line1", EmitDefaultValue = false)]
        public string Line1;

        /// <summary>
        /// Optional. The second line of the address. For example, suite, apartment number, and so on.
        /// </summary>
        [DataMember(Name="line2", EmitDefaultValue = false)]
        public string Line2;

        /// <summary>
        /// The address normalization status. Returned only for payers from Brazil.
        /// </summary>
        [DataMember(Name="normalization_status", EmitDefaultValue = false)]
        public string NormalizationStatus;

        /// <summary>
        /// The phone number, in [E.123 format](https://www.itu.int/rec/T-REC-E.123-200102-I/en). Maximum length is 50 characters.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public string Phone;

        /// <summary>
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [Postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode;

        /// <summary>
        /// The [code](/docs/integration/direct/rest/state-codes/) for a US state or the equivalent for other countries. Required for transactions if the address is in one of these countries: [Argentina](/docs/integration/direct/rest/state-codes/#argentina), [Brazil](/docs/integration/direct/rest/state-codes/#brazil), [Canada](/docs/integration/direct/rest/state-codes/#canada), [India](/docs/integration/direct/rest/state-codes/#india), [Italy](/docs/integration/direct/rest/state-codes/#italy), [Japan](/docs/integration/direct/rest/state-codes/#japan), [Mexico](/docs/integration/direct/rest/state-codes/#mexico), [Thailand](/docs/integration/direct/rest/state-codes/#thailand), or [United States](/docs/integration/direct/rest/state-codes/#usa). Maximum length is 40 single-byte characters.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;

        /// <summary>
        /// The address status.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status;

        /// <summary>
        /// The type of address. For example, `HOME_OR_WORK`, `GIFT`, and so on.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type;
    }
}

