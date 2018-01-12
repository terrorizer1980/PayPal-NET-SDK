// This class was generated on Wed, 13 Dec 2017 14:32:58 CST by version 0.1 of Braintree SDK Generator
// BankToken.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7ySQUsDMRCF7/6KIacWluJ5b6vtwYsW23oRWWY3s21odrJOktZF+t8lWy1iD0UEb+HNS96X5L2rZd+RytUN8haWbkusMvWEYrCydI9tmqlMTcnXYrpgHKtcFRCSExongFClrTWKnsAtMlQE0ZOG4KCJrAGhw74lDhOVqUIE+2PkdaYeCfUD217lDVpPSXiNRkifhLm4jiQY8ip/PsH6IIbX56CJpDT6jHe5IbibgmsgbAh2GG0g/Y37N2BB4g8ujtYesotw9BZIGG1ZRx9cS3KZ9MsJ+40Dt2c/qP/M3SJrDFQKNSTENZUc24rkArs2QnUATZUJ8HlG6sQOrUnrCSxi1zlJP+HY9kOZFobXlmAWxcH82BoPhRDCaDGbF+Pj3bGuXUwTw0NUsneEDCs2jmE0W43/2rXhbV4OVx8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A token for a bank card. Can be used to fund a payment.
    /// </summary>
    [DataContract]
    public class BankToken {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public BankToken() {}

        /// <summary>
        /// REQUIRED
        /// The ID of the vaulted bank card.
        /// </summary>
        [DataMember(Name="bank_id", EmitDefaultValue = false)]
        public string BankId { get; set; }

        /// <summary>
        /// REQUIRED
        /// The ID of the customer who owns the bank card.
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue = false)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// The ID of the direct debit mandate to validate. Supported only for Single Euro Payments Area (SEPA) bank accounts in the European Union (EU).
        /// </summary>
        [DataMember(Name="mandate_reference_number", EmitDefaultValue = false)]
        public string MandateReferenceNumber { get; set; }
    }
}

