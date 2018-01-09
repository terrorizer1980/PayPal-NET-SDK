// This class was generated on Wed, 13 Dec 2017 14:34:03 CST by version 0.1 of Braintree SDK Generator
// CreditCard.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Vault
{
    /// <summary>
    /// A vaulted credit card. To fund a payment, use the ID of the vaulted card.
    /// </summary>
    [DataContract]
    public class CreditCard {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCard() {}

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public SimplePostalAddress BillingAddress { get; set; }

        /// <summary>
        /// The date and time when the vaulted credit card was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-11-05T13:15:30Z`.
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// REQUIRED
        /// The one- to two-digit month when the card expires, with no leading zero. For example, `1` or `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth { get; set; }

        /// <summary>
        /// REQUIRED
        /// The four-digit year when the card expires. For example, `2017`.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear { get; set; }

        /// <summary>
        /// The externally-provided ID of the credit card.
        /// </summary>
        [DataMember(Name="external_card_id", EmitDefaultValue = false)]
        public string ExternalCardId { get; set; }

        /// <summary>
        /// The externally-provided ID of the customer for whom to list credit cards.
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue = false)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// The first name of the credit card holder. Maximum length is 25 characters.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The ID of the vaulted credit card, which you can use to fund a payment.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The last name of the credit card holder.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The ID of the merchant for whom to list credit cards.
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// REQUIRED
        /// The credit card number. Valid value is a string of numeric characters with no spaces or punctuation. Must conform to modulo and the length required by its credit card type. *Redacted in responses.*
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// A unique ID that you can assign and track when you vault a credit card or use a vaulted credit card to make a payment. This ID can help to avoid unintentional use or misuse of credit cards. Can be any value, such as a UUID, user name, or email address. **This is being deprecated in favor of the `external_customer_id` property.**
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId { get; set; }

        /// <summary>
        /// The state of the credit card funding instrument.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// REQUIRED
        /// The credit card type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The date and time when the vaulted credit card was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-11-05T13:15:30Z`.
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The date and time when the credit card becomes unusable from the vault, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The `valid_until` parameter is not the same as the expiration month and year. The expiration month and year might be later than the `valid_until` date. For example, the card expires in November 2019 but the `valid_until` date is October 17th, 2019.
        /// </summary>
        [DataMember(Name="valid_until", EmitDefaultValue = false)]
        public string ValidUntil { get; set; }
    }
}

