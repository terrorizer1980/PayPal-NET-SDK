// This class was generated on Mon, 11 Dec 2017 17:19:29 CST by version 0.1 of Braintree SDK Generator
// ExtendedBankAccount.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * A bank account that can be used to fund a payment. Supports Single Euro Payments Area (SEPA) bank accounts.
    */
    [DataContract]
    public class ExtendedBankAccount {

        // Required default constructor
        public ExtendedBankAccount() {}

        /**
        * A customer-designated account name.
        */
        [DataMember(Name="account_name")]
        public string AccountName { get; set; }

        /**
        * REQUIRED
        * The account number in international bank account number (IBAN) format or basic bank account number (BBAN) format. The maximum length for the IBAN format is 34 characters. The maximum length for the BBAN format is 17 characters.
        */
        [DataMember(Name="account_number")]
        public string AccountNumber { get; set; }

        /**
        * REQUIRED
        * The type of bank account number. A valid value is basic bank account number (BBAN) or international bank account number (IBAN). For more information, see [International Bank Account Number](http://en.wikipedia.org/wiki/International_Bank_Account_Number).
        */
        [DataMember(Name="account_number_type")]
        public string AccountNumberType { get; set; }

        /**
        * The bank account type.
        */
        [DataMember(Name="account_type")]
        public string AccountType { get; set; }

        /**
        * The date and time when the authorization was captured, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Use this parameter if you must capture the user authorization due to any privacy requirements.
        */
        [DataMember(Name="auth_capture_timestamp")]
        public string AuthCaptureTimestamp { get; set; }

        /**
        * The authorization type, which indicates how the check was obtained from the customer if a check is the source of information.
        */
        [DataMember(Name="auth_type")]
        public string AuthType { get; set; }

        /**
        * The bank name.
        */
        [DataMember(Name="bank_name")]
        public string BankName { get; set; }

        /**
        * A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        */
        [DataMember(Name="billing_address")]
        public SimplePostalAddress BillingAddress { get; set; }

        /**
        * The account holder's birth date.
        */
        [DataMember(Name="birth_date")]
        public string BirthDate { get; set; }

        /**
        * The check type when the information was obtained from the facilitator or merchant.
        */
        [DataMember(Name="check_type")]
        public string CheckType { get; set; }

        /**
        * The confirmation status of a bank account.
        */
        [DataMember(Name="confirmation_status")]
        public string ConfirmationStatus { get; set; }

        /**
        * The two-letter country code of the bank.
        */
        [DataMember(Name="country_code")]
        public string CountryCode { get; set; }

        /**
        * The date and time when the bank account was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * The facilitator-generated ID for the customer who owns this bank account. Required when you create or use a vaulted funding instrument.
        */
        [DataMember(Name="external_customer_id")]
        public string ExternalCustomerId { get; set; }

        /**
        * The account holder's first name.
        */
        [DataMember(Name="first_name")]
        public string FirstName { get; set; }

        /**
        * The ID of the bank account that is being saved for later use.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * The account holder's last name.
        */
        [DataMember(Name="last_name")]
        public string LastName { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The ID of the direct debit mandate to validate. Currently supported for only Single Euro Payments Area (SEPA) bank accounts in the European Union (EU).
        */
        [DataMember(Name="mandate_reference_number")]
        public string MandateReferenceNumber { get; set; }

        /**
        * The facilitator-generated ID for the merchant for whom the bank account was vaulted. Can be used to restrict usage of the bank account to the merchant.
        */
        [DataMember(Name="merchant_id")]
        public string MerchantId { get; set; }

        /**
        * Deprecated. Instead, use the `external_customer_id` parameter.
        */
        [DataMember(Name="payer_id")]
        public string PayerId { get; set; }

        /**
        * The routing transit number, or bank code, of the bank. Typically, you specify this value for domestic use only. International bank account numbers (IBAN) include the bank code. For more information, see [Bank code](http://en.wikipedia.org/wiki/Bank_code).
        */
        [DataMember(Name="routing_number")]
        public string RoutingNumber { get; set; }

        /**
        * The state of this funding instrument.
        */
        [DataMember(Name="state")]
        public string State { get; set; }

        /**
        * The date and time when the bank account was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }

        /**
        * The date and time after which the bank account can no longer be used to fund a payment, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="valid_until")]
        public string ValidUntil { get; set; }
    }
}

