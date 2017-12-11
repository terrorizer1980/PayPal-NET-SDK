// This class was generated on Mon, 11 Dec 2017 13:16:23 CST by version 0.1 of Braintree SDK Generator
// RedirectUrls.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8TRT0vzQBDH8fvzKoY5hjzFc24Fj6KlVC8iMk1+MQvb3TgzUYL0vctSGoQePCh4nf3D98N88G4ewQ0ruqBo/XnSaFzzg2iQfcStHMox13wNazWMHnLihtdkcMo9nR/S/fbGyAdxmvNEo+a30IH6rLSReSPx/14MHY0yH5DcVlzzWlXmU8BVzVtId5fizE0v0VAGr1NQdMtgo3mEeoBx87ikm2tIL5fNraQWsYAu6ncDSi+9D1CQDyhZUAq2eNCR9A6lAZSVbACdPrTz/cJYUVWdM79YSdo2T8kXbVX91JumGI/1t2iFT5p+ES1jWSX+Uv10/PcJAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * A set of redirect URLs that you provide for PayPal-based payments.
    */
    [DataContract]
    public class RedirectUrls {

        // Required default constructor
        public RedirectUrls() {}

        /**
        * The URL where the payer is redirected after he or she cancels the payment. **Required for PayPal account payments**.
        */
        [DataMember(Name="cancel_url")]
        public string CancelUrl { get; set; }

        /**
        * The URL where the payer is redirected after he or she approves the payment. **Required for PayPal account payments**.
        */
        [DataMember(Name="return_url")]
        public string ReturnUrl { get; set; }
    }
}

