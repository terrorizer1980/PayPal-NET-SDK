// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// SimplePostalAddress.cs
// @version 0.1.0-dev+27d306
// @type object
// @data H4sIAAAAAAAC/7xWwW4bRwy99yuI7cUCVlrbKXLQzXbQIA0SG7Hdi2o01AylZT2aWXO4kTdF/r2YWVmWLAO1isIXAcvh45KPb9/o7+Kqa6gYF5e8aBzBRYiKDk6sFYqxKIvfURinjj7jIqUVZfGRuseHdxSNcKMcfDEuTiD2ZZq+DPZlYMlagwkokYZzQfZkYcbkbBzBuwA+KLSRYBYE0AN7JfGYaj7WGMH1KmOK5naJYsGERYPKU3asHQTvulSNYq5ngldkD00dPI2KsjgRwa4f9rAsvhDac++6YjxDFykF7loWsuvAhYSGRJliMZ6saYoq7Oe7vBjWboubVWCbn6uaIB2Ax8V+Tam0T3ryrXM/yn9vLLRepfvTBEvbDW4f7DY60WUYmhoFjZLAh8tzeHP09u3wCBLk5qCywcQqLWsueVmVZSGjlVDUalV+mHJjNQCtUYEteeUZUwRNVPQ5EASE5hz86I/28PCNmbpgbu/aoJSf+18TVYKf95HPQWnch6vNOFxtlE2vzop5L4QKp8JZERyhR6bzHvb+dFXrMQTobRbS09zrj8/kxqRfC+zzXBqaoaNv5MCGRXplWnfMrWQaVg32kk6Ar2fHX3fbPqvZIyyDOLvkVSxrXtJ+ofVJ4xKcIwuNsCE4OLu+GMCCtA62hCn6WzAotszDGAkxDqdBLAmooI9o0triivXqKe2vok/Hno62hPkQ2VXkjCUqpHMIs0zc2hx+DQJ0j8l8SvDtYkpSQlQh0n76GCD40auNdLwz0vHOSOdNb3GjrNpIJnj7guliy0olYIOiC/K6Hve/jfmM3b1wzt7kd51lO767xtXlkM5LWNZs6vRNpoG/c9PLP8171/I3dOR1BFddwwad60BWfa8+hvTFJDfJFwxuVob+LtmsckkEk42Um4NatYnjqiI/WvItN2QZR0HmVXqqLh7nGLwSpVFRt8l8iDzjzy+x4Qxfm3C+YOH6EnIYsh/RBkc5IWhNG9yO4Msm55vGAbyl07RF9hDWAo70WGYMkxOZJ/v3uE/TP+MDalDC5FTwO7u98NMMSeAz9Gj3e7nJkAT+4C3vh+WEyFBF1+0HTYgE/Q0b9HtB/0qIBP1E92zCXthFhiTwVY3s0Nu94LoCDcqkrMm1ZyULlykl7lWojTgYwSe850W7AEd+rtkifjmEyH7uaDjtlGD93yT+L1/nzY+f/gEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
    /// </summary>
    [DataContract]
    public class SimplePostalAddress
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SimplePostalAddress() {}

        /// <summary>
        /// REQUIRED
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
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode;

        /// <summary>
        /// The [code](/docs/integration/direct/rest/state-codes/) for a US state or the equivalent for other countries. Required for transactions if the address is in one of these countries: [Argentina](/docs/integration/direct/rest/state-codes/#argentina), [Brazil](/docs/integration/direct/rest/state-codes/#brazil), [Canada](/docs/integration/direct/rest/state-codes/#canada), [India](/docs/integration/direct/rest/state-codes/#india), [Italy](/docs/integration/direct/rest/state-codes/#italy), [Japan](/docs/integration/direct/rest/state-codes/#japan), [Mexico](/docs/integration/direct/rest/state-codes/#mexico), [Thailand](/docs/integration/direct/rest/state-codes/#thailand), or [United States](/docs/integration/direct/rest/state-codes/#usa). Maximum length is 40 single-byte characters.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;
    }
}

