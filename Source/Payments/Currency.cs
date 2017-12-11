// This class was generated on Mon, 11 Dec 2017 13:16:19 CST by version 0.1 of Braintree SDK Generator
// Currency.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6ySTYsUMRCG7/6KIiddMtMqgjA3QQQvu4MuXoY91CRvz5Skk1ipiI3sf5cenfVjBVnw+ubNx/OkvrrrucJtXOiqyGF23n1gFd4nXPK0rDjvXqMFlWpSstu46yNozw103kNl/xHBaCxKnBKNkjkH4USfOXWsFIkNkUZBim1Nb4oSvvBUEzztOXEO8FR5npCNYocnzpFaoZLXzrtXqjx/f+dT796B41VOs9uMnBqW4FMXRbwLtloq1ATNbXZ3hM1U8uE+3y/k9zl3dlRgFY6sHAxKb99frV48f/byJ3woETePh1hCGyQbDsrLAUMURbBB0Ww4l1dLuQ1P1rTlecuJYkGjXIxar7Wonfz9aAvag+hN+x/wuad06/9p4PRLf8XnqfRsnnolK3RxeUFRDmKNeFxk2BEUEWTiRA2Vla2oJ24UMUpGJMm0Oyt7qKTTPC1XcK1aqgobftf+P/Tc3D76BgAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
    */
    [DataContract]
    public class Currency {

        // Required default constructor
        public Currency() {}

        /**
        * REQUIRED
        * The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/). PayPal does not support all currencies.
        */
        [DataMember(Name="currency")]
        public string CurrencyCode { get; set; }

        /**
        * REQUIRED
        * The amount, up to *N* digits after the decimal separator, as defined in [ISO-4217](/docs/integration/direct/rest/currency-codes/) for the appropriate currency code.
        */
        [DataMember(Name="value")]
        public string Value { get; set; }
    }
}

