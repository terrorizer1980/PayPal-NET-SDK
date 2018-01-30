// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// CreditCard.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// [DEPRECATED] A credit card. Can be used to fund a payment. Use a payment card instead.
    /// </summary>
    [DataContract]
    public class CreditCard
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCard() {}

        /// <summary>
        /// The billing address in a payment. Can be extended for shipping address.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public Address BillingAddress;

        /// <summary>
        /// The three- to four-digit card validation code.
        /// </summary>
        [DataMember(Name="cvv2", EmitDefaultValue = false)]
        public string Cvv2;

        /// <summary>
        /// REQUIRED
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth;

        /// <summary>
        /// REQUIRED
        /// The four-digit expiration year.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear;

        /// <summary>
        /// The card holder's first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName;

        /// <summary>
        /// The card holder's last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// REQUIRED
        /// The credit card number. Value is numeric characters only with no spaces or punctuation. Must conform to the modulo and length required by each credit card type. *Redacted in responses.*
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number;

        /// <summary>
        /// REQUIRED
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type;
    }
}

