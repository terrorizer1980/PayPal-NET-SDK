// This class was generated on Mon, 11 Dec 2017 15:04:23 CST by version 0.1 of Braintree SDK Generator
// CreditCard.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Vault
{
    /**
    * A vaulted credit card. To fund a payment, use the ID of the vaulted card.
    */
    [DataContract]
    public class CreditCard {

        // Required default constructor
        public CreditCard() {}

        /**
        * A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        */
        [DataMember(Name="billing_address")]
        public SimplePostalAddress BillingAddress { get; set; }

        /**
        * The date and time when the vaulted credit card was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-11-05T13:15:30Z`.
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * REQUIRED
        * The one- to two-digit month when the card expires, with no leading zero. For example, `1` or `12`.
        */
        [DataMember(Name="expire_month")]
        public int ExpireMonth { get; set; }

        /**
        * REQUIRED
        * The four-digit year when the card expires. For example, `2017`.
        */
        [DataMember(Name="expire_year")]
        public int ExpireYear { get; set; }

        /**
        * The externally-provided ID of the credit card.
        */
        [DataMember(Name="external_card_id")]
        public string ExternalCardId { get; set; }

        /**
        * The externally-provided ID of the customer for whom to list credit cards.
        */
        [DataMember(Name="external_customer_id")]
        public string ExternalCustomerId { get; set; }

        /**
        * The first name of the credit card holder. Maximum length is 25 characters.
        */
        [DataMember(Name="first_name")]
        public string FirstName { get; set; }

        /**
        * The ID of the vaulted credit card, which you can use to fund a payment.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * The last name of the credit card holder.
        */
        [DataMember(Name="last_name")]
        public string LastName { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The ID of the merchant for whom to list credit cards.
        */
        [DataMember(Name="merchant_id")]
        public string MerchantId { get; set; }

        /**
        * REQUIRED
        * The credit card number. Valid value is a string of numeric characters with no spaces or punctuation. Must conform to modulo and the length required by its credit card type. *Redacted in responses.*
        */
        [DataMember(Name="number")]
        public string Number { get; set; }

        /**
        * A unique ID that you can assign and track when you vault a credit card or use a vaulted credit card to make a payment. This ID can help to avoid unintentional use or misuse of credit cards. Can be any value, such as a UUID, user name, or email address. **This is being deprecated in favor of the `external_customer_id` property.**
        */
        [DataMember(Name="payer_id")]
        public string PayerId { get; set; }

        /**
        * The state of the credit card funding instrument.
        */
        [DataMember(Name="state")]
        public string State { get; set; }

        /**
        * REQUIRED
        * The credit card type.
        */
        [DataMember(Name="type")]
        public string Type { get; set; }

        /**
        * The date and time when the vaulted credit card was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-11-05T13:15:30Z`.
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }

        /**
        * The date and time when the credit card becomes unusable from the vault, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The `valid_until` parameter is not the same as the expiration month and year. The expiration month and year might be later than the `valid_until` date. For example, the card expires in November 2019 but the `valid_until` date is October 17th, 2019.
        */
        [DataMember(Name="valid_until")]
        public string ValidUntil { get; set; }
    }
}

