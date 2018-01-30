// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// ShippingAddress.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/7xWTXPbRgy991dg2Es8Q5Gy0+agW+ImqZtJ7LHl9qBmbIgLi2iWu8wuGJnp5L93dkV9sFSnUdrRxWMBeEs8APuwfybTtqZkkviS65rN4g6VcuR9kia/omOca3qHVYhI0uQNtdsfP5EvHNfC1iSTZFoS0KOQUaSgOyOFZclFCeyh8cHsQUqC9afWYcAGEGpsKzKSJWny3DlsV3mN0+SaUF0a3SaTB9SeguFjw47UxnDlbE1OmHwymW0ZiWOzGPIoWNoel84w5BMcYLCi/5qUabT+kv57ZrYx4tq7wirqZ9h3DDOdydKOihIdFkIOLm4u4enps2ejUwiQ909yZQufsxFaOAy4XLGjQnJHXvLu+FGI9fkJSIkCrMgIPzCtmtbFgHXgaMHWZL834/HTYq5t8eFjY4Xi79XfwouzZrGyvLNCk5U537XDdOfY8Gl4sA5eO0KBF44F2YTJWSGDfwV7/aI7a2sCNAqMlUHs7Zs9sd0wsom8xNYjTZ9Ig7JV+GTot4+pxDJ0CWZw6ykC7s/P7odpn5dsEJbWabXkzlbYqkYX+guNKawRZ7UmBbXjguDJ+e3VCVQkpVUpzNF8gAKdSiOZwlnvR3PrFDkQh8ZjEdrmu6rnfy/7IQMqrvm2+dRs6LQ3mGvLcCIf2HmB4Af7EAvX3fYMXlkH9IhVrSkF01Rzcil4cUSyYu8tWJMdjdLZgNLZgNJl/Ad1FqfWU2GN+gp2vmGhFLBGJ0HdNnS/jea3S4uxrkLNn+Plv/OC0vge7X8IGDZ2Ldo9AKwAGVyTNM6QAmt0G29BjS05Dw/OVvDC4WfWR6Jcl9b0ZXRtGZKKnk1z2MDsZXZ69jQQqFDePylFaj/J8+VymbE0GZsgnUU+HV2/PB/F2NHZeHw6Phtd5GROMniLj1w1FWgyC4kr8McxbBTaH6sG1gvq4ULp2/fUI/qjvO0s8TDnn7leqV4Y848Nf0IdtjZM25oL1LoF1+XdaWAQyrBElixlWPPbk8MRaHqn3BDB7Gobsq08mWzJH7gmxZhZt8jDr/xqy+PkSCV1VHDNZOQubIpeVQeuYWGDYy0Zm3BAASnZb0TkOEzCne0TWFv2PDC+5h0R4ZtXRGg/wu1N1IbY7EB62+0YYKWknSkJArIzPbubD7gntGEe2YDdKLCn7TETmD13i/B+MXhI0t/jGnWSwmylVgfh5xESwOdoUB328SJCAvjCKD4MywERoYK6PQwaEAH6C9ZoDoL+ERAB+pYeubAHYasICeBpiazRqIPg0oFO0jBZs1vDQgpuQog/6KDG4165/mEMns1C02jeCh1fuvfs6K/Yyt0ePk6KEty7CXaGYXrBEe7p/lfS/c+Xb1/eXV7f/XZ5/eY+hfvXF6+m9//3I+n9l+/+AgAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The extended address, which is used as the shipping address in a payment.
    /// </summary>
    [DataContract]
    public class ShippingAddress
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingAddress() {}

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
        /// The name of the recipient at this address.
        /// </summary>
        [DataMember(Name="recipient_name", EmitDefaultValue = false)]
        public string RecipientName;

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

