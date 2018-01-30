// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// CreditCardToken.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/7yUwW7bMAyG73sKwsfAC9Zhp+xUoJdiwFYMbS/DUDMRExOVJZeUnLpD332QkrR2vB6KFb3ZlET9H/lTf4rLvqViUayEDIebFYq5Cf6WXFEW1yiMS0vfsUlbirL4Rv3zzxnpSrgN7F2xKE4hH+MHMrBLBikZhBrTl4MlQVQyEDysozOA0GLfkAvzoixORbDfSflUFj8JzQ9n+2KxRquUAneRhcxT4EJ8SxKYtFj8eoLQIOw2U+VDODYjjsnSmOqyJjg/A7+eMrGCBi9kgB2EmuAC+wu00GG0r2MKEo+QXLT2sXziYhdoQzIFo/uWhW4a70I9wjpamELlDZgCkDfBlkMNzoMlNOw28EDi53CNNlJCXYtvoDqpUvuqk8/V/zbtlYQ9ofwLcB+f8q19lI+GNxyGqGn7Gyt/yXMWNXwZST5EpmLTSlYMWbEmvyVH7f01tJ6LzZLei6HFnuR4YgbB4xcgOr6LeWDyhPQ+5slHVd44QGcgCK5uYVuTy6sZEHBEuJ+mPEbgJT0agLvfcS3mcFmzptvSJTXZNpkTO88mKXGBXFKGNqfwAg1r/hoNs47TLAnQ9dBl3yeJWx+tAcu3lLOr+hVjoN285CZhl3ShmBI0rmpABYSrq/OzMl0s4LChMt1PDbIFNEZIdQ6z2aFHzwV5ERZ4DQjVofgVbFHBC2/YobU9tOI7NsNUhyRJ47Bqs9n7mCek5aFx9oGp/UdPa9/S4NmpOlasSqga1ECStqQ/w7ryHUmV61phQ/fV/pQCCiUTWb9NB5S+gvHgfMjFDTUp7dqrsPZp4rS12L/JRP1+/PAXAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A tokenized credit card that can be used to fund a payment.
    /// </summary>
    [DataContract]
    public class CreditCardToken
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCardToken() {}

        /// <summary>
        /// REQUIRED
        /// The ID of credit card that is stored in the PayPal vault.
        /// </summary>
        [DataMember(Name="credit_card_id", EmitDefaultValue = false)]
        public string CreditCardId;

        /// <summary>
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth;

        /// <summary>
        /// The four-digit expiration year.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear;

        /// <summary>
        /// The last four digits of the stored credit card number.
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue = false)]
        public string Last4;

        /// <summary>
        /// A unique ID that you can assign and track when you store a credit card in the vault or use a vaulted credit card. This ID can help to avoid unintentional use or misuse of credit cards. This ID can be any value you would like to associate with the saved card, such as a UUID, user name, or email address. **Required when you use a vaulted credit card if a `payer_id` was originally provided when you vaulted the credit card.**
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId;

        /// <summary>
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`. Values are in lowercase; do not use these values for display.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type;
    }
}

