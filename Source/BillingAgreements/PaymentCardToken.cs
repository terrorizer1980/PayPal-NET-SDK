// This class was generated on Wed, 13 Dec 2017 14:32:59 CST by version 0.1 of Braintree SDK Generator
// PaymentCardToken.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUTYvbMBCG7/0Vg85uaEpPvoXm0ksbSgiYUuxJNI5FZckdjZqaJf99kfOxLPGyXyE3o3mRn+eVrTu17DtSuVpg35IT+IqsYen/kFOZWiEbXFv6jm3KqEzNKWzYdGK8U7magaQk1J4BoTtusUlbSIPpycGaIAbSIB7q6PRDbqIyNWPG/kDwKVM/CfUPZ3uV12gDpYW/0TDp88KCfUcshoLKf53ZjRPaEl8C0//OMJWtd9JcwC8bgiHQwxCAmn0L0hD8w2iF9CAygRXaSGDCYV5Nq6RSTT9X7xVw0dp99mKLnpBHJWof+aM2WyMnnxQd18nAOKiKoiiqdGotypUtgrBx2zEJIXZoy00M4lvi0uhRm29z8PXAfUrCrvHgdy6ANCY8+sxeBS8c38ZuMciXUdg0GfqHof9wRk+/gIvtmp44hxu1fuyqTK98vvAT4O0bljQegzvcJX1H1+D4vf9wDwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A token for a payment card that can be used to fund a payment.
    /// </summary>
    [DataContract]
    public class PaymentCardToken {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentCardToken() {}

        /// <summary>
        /// The expiry month from the vaulted card. Value is from `1` to `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int ExpireMonth { get; set; }

        /// <summary>
        /// The four-digit expiry year from the vaulted card, in `YYYY` format.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int ExpireYear { get; set; }

        /// <summary>
        /// REQUIRED
        /// The ID of the customer who owns this payment card.
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue = false)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// The last four digits of the card number from the vaulted card.
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// REQUIRED
        /// The ID of the vaulted payment card.
        /// </summary>
        [DataMember(Name="payment_card_id", EmitDefaultValue = false)]
        public string PaymentCardId { get; set; }

        /// <summary>
        /// REQUIRED
        /// The card type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

