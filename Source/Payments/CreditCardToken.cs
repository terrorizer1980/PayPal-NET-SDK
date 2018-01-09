// This class was generated on Wed, 13 Dec 2017 14:31:39 CST by version 0.1 of Braintree SDK Generator
// CreditCardToken.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUQU8bSwzH7+9TWHOM9kWPp57SExIXLi2qgEtVsU7GyVrMziz2TMJS8d0rT4AmTTigIm67Ox7797f/3p/uchzIzdxCyHO+WaD4m5xuKbrGXaMwzgN9wd5CXOPOSBfCQ+YU3cydQo3kB/KwvQ92H3KH9hRhTlCUPOQEyxI9IAw49hTz1DXuVATHbfX/GveN0H+NYXSzJQYl+3BXWMi/fLiQNJBkJnWz7y/cmoXj6hB2Vw/7A/TLjuD8DNLyEJwVNCchDxwhdwQXOF5ggDWW8DbwLOUP7lhCeGxe4DlmWpEc0tP9wEI3fYq5O8peA9A+QA2CDecOYoJA6Dmu4IEkTeEaQyFTtJTUQ3vS2ijak//bvx3AG4WMhHJUxzIV+dfzivOuJAt/Z8LXfBJQ86ejaHZS+aDyqZnF7PBkjl3fxNLP6aOIBxxJjnn6FErku1KNXZ08plLXEFV5FQGjhyy4uIVNR7GeVi2Ae2KeXF/tDklsgwG3r/uyp3DZsVo1K9JRGMxduE7sjSRmikaGoaZIAj1rfdpbOt1PMyfAOMK6GtcQN6kED4FvqWZXTQvGTFvD13ng2rhQfANaFh2gAsLV1flZY4UFIvbUWH3qkQOg90KqU5hMnsfxuyGvigVeAkL73PwWNqiQhFccMYQRBklr9rupnpMY427XJpOP8Um242PG3vvjjQPt/CbaNSu2DbQ9aiaxEHvzrIu0JmlrG1vs6b59uqWAQuaZkDZ2Qekz+AQx5drL3JHSdpoKy2S7pEPA8V125cfjP78AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A tokenized credit card that can be used to fund a payment.
    /// </summary>
    [DataContract]
    public class CreditCardToken {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCardToken() {}

        /// <summary>
        /// REQUIRED
        /// The ID of credit card that is stored in the PayPal vault.
        /// </summary>
        [DataMember(Name="credit_card_id", EmitDefaultValue = false)]
        public string CreditCardId { get; set; }

        /// <summary>
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth { get; set; }

        /// <summary>
        /// The four-digit expiration year.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear { get; set; }

        /// <summary>
        /// The last four digits of the stored credit card number.
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// A unique ID that you can assign and track when you store a credit card in the vault or use a vaulted credit card. This ID can help to avoid unintentional use or misuse of credit cards. This ID can be any value you would like to associate with the saved card, such as a UUID, user name, or email address. **Required when you use a vaulted credit card if a `payer_id` was originally provided when you vaulted the credit card.**
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId { get; set; }

        /// <summary>
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`. Values are in lowercase; do not use these values for display.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

