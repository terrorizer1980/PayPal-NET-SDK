// This class was generated on Wed, 13 Dec 2017 14:31:40 CST by version 0.1 of Braintree SDK Generator
// RedirectUrls.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8TRT0vzQBDH8fvzKoY5hjzFc24Fj6KlVC8iMk1+MQvb3TgzUYL0vctSGoQePCh4nf3D98N88G4ewQ0ruqBo/XnSaFzzg2iQfcStHMox13wNazWMHnLihtdkcMo9nR/S/fbGyAdxmvNEo+a30IH6rLSReSPx/14MHY0yH5DcVlzzWlXmU8BVzVtId5fizE0v0VAGr1NQdMtgo3mEeoBx87ikm2tIL5fNraQWsYAu6ncDSi+9D1CQDyhZUAq2eNCR9A6lAZSVbACdPrTz/cJYUVWdM79YSdo2T8kXbVX91JumGI/1t2iFT5p+ES1jWSX+Uv10/PcJAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A set of redirect URLs that you provide for PayPal-based payments.
    /// </summary>
    [DataContract]
    public class RedirectUrls {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public RedirectUrls() {}

        /// <summary>
        /// The URL where the payer is redirected after he or she cancels the payment. **Required for PayPal account payments**.
        /// </summary>
        [DataMember(Name="cancel_url", EmitDefaultValue = false)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// The URL where the payer is redirected after he or she approves the payment. **Required for PayPal account payments**.
        /// </summary>
        [DataMember(Name="return_url", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }
    }
}

