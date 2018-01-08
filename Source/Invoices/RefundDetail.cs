// This class was generated on Mon, 08 Jan 2018 16:45:02 CST by version 0.1 of Braintree SDK Generator
// RefundDetail.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yV0W/bNhDG3/dXHNSXxJCtNOlWzG9Z0wHG1tRIjWFDEDRn8mTdRpEceaqnDf3fB0qyPdkD1qFBH306nr7fx/usv7JV6ymbZ3dUNlbDDQmyyfLsJwyMa0O3WKfHWZ79QO3hxw1FFdgLO5vNs4X94Fix3UDox+huTJxleXYdArb9Sy7y7I5Qv7WmzeYlmkip8HvDgfS+sAzOUxCmmM3v9/JeNSGQVe2pMqxdY2Wkb18aq/wOI4Fb/0pKoHQB0Bgo2aJVjAY+oGkIAhkU0lAyGR3hbI0GraIcPLY1WQHdUA4kanb+ZGxRAtvNKZkamF85TSM+dTBjTHgFhkQowK4DlNMEGEFTyZY0rFtYvHsLLy6fv/xflyOhOdJvG2M+5v8J0dk6Ur+rjKX3dwaNB3FwC5o3LIBlgpGKQJPiGk2ESB4DSrq+AxXbPVV3s+kEeh+cD4xCYzuegvvhE8g1yhh8KIy5VwkuadxWZDvh3IWJYItxiBPpGez7ShdqFOAIk7Zt28l08ubNZDrRegKTPyf5kS33CysULAncoFCx4prg+27Cw1kl4udFIc6ZOGOScubCpqikNkUo1dXV1bfPIqmkc/r17JvzWToI9AfW3lAOj5cXz19MLy6nly9h+W71+LlZ/8R9su7I1aEwdvUaUhkwRqe4C/SWpers7S39QmoloI3Yefie9Uj3yaPTvVjcgCs70Utsl2h2/67/ODqDncwD4ePy+pfl9Y+P+/bW05fiTY9HlH3hlO2IKEmEhdWsUCimMEg1RH9oSXHwyBqkCq7ZVLsJ3U6mHUdj2rTyvP8YlcZt++TcB1Iu6GHWw1mhnYoFei723cWzIXjxfd887ZvPoSapnIbYeO+CxN7j1z+vXt/dHrvcvezf/E95HQakr4sLsEb12xaDBuVqj8JrNiztk9zTw8ev/gYAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Invoicing refund details.
    /// </summary>
    [DataContract]
    public class RefundDetail {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RefundDetail() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The date when the invoice was refunded. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6). For example, `2014-02-27 PST`.
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// A note associated with the refund.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The ID of the PayPal refund transaction. Required with the `PAYPAL` refund type.
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The PayPal refund type. Indicates whether the refund was paid through PayPal or externally in invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

