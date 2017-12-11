// This class was generated on Mon, 11 Dec 2017 17:19:30 CST by version 0.1 of Braintree SDK Generator
// PaymentCardToken.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUTYvbMBCG7/0Vg85uaEpPvoXm0ksbSgiYUuxJNI5FZckdjZqaJf99kfOxLPGyXyE3o3mRn+eVrTu17DtSuVpg35IT+IqsYen/kFOZWiEbXFv6jm3KqEzNKWzYdGK8U7magaQk1J4BoTtusUlbSIPpycGaIAbSIB7q6PRDbqIyNWPG/kDwKVM/CfUPZ3uV12gDpYW/0TDp88KCfUcshoLKf53ZjRPaEl8C0//OMJWtd9JcwC8bgiHQwxCAmn0L0hD8w2iF9CAygRXaSGDCYV5Nq6RSTT9X7xVw0dp99mKLnpBHJWof+aM2WyMnnxQd18nAOKiKoiiqdGotypUtgrBx2zEJIXZoy00M4lvi0uhRm29z8PXAfUrCrvHgdy6ANCY8+sxeBS8c38ZuMciXUdg0GfqHof9wRk+/gIvtmp44hxu1fuyqTK98vvAT4O0bljQegzvcJX1H1+D4vf9wDwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * A token for a payment card that can be used to fund a payment.
    */
    [DataContract]
    public class PaymentCardToken {

        // Required default constructor
        public PaymentCardToken() {}

        /**
        * The expiry month from the vaulted card. Value is from `1` to `12`.
        */
        [DataMember(Name="expire_month")]
        public int ExpireMonth { get; set; }

        /**
        * The four-digit expiry year from the vaulted card, in `YYYY` format.
        */
        [DataMember(Name="expire_year")]
        public int ExpireYear { get; set; }

        /**
        * REQUIRED
        * The ID of the customer who owns this payment card.
        */
        [DataMember(Name="external_customer_id")]
        public string ExternalCustomerId { get; set; }

        /**
        * The last four digits of the card number from the vaulted card.
        */
        [DataMember(Name="last4")]
        public string Last4 { get; set; }

        /**
        * REQUIRED
        * The ID of the vaulted payment card.
        */
        [DataMember(Name="payment_card_id")]
        public string PaymentCardId { get; set; }

        /**
        * REQUIRED
        * The card type.
        */
        [DataMember(Name="type")]
        public string Type { get; set; }
    }
}

