// This class was generated on Thu, 25 Jan 2018 18:07:25 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// RedirectUrls.cs
// @version 0.1.0-dev+27d306
// @type object
// @data H4sIAAAAAAAC/6zQMU/DMBAF4J1fcbo5qpizIbFRQRW1LAihI36tLbm2OTsgC/W/oxAoVBkY6JgX+3zfe+d1TeCWOxin6AttumXmhu9FnTx73Mp+/M0N36D+fFwj9+pScTFwy2sL0t8DFtThZXAKQzH4StuoVCxoJXUlnpLUPUKhPYqNZkHj/TykFLXAUEYpLuwyiY5jy6CBJBjqJfTw03xu+EpV6rT9ZcMdxNwFX7ndis8Yg2mBY7DSmKDFIXP7cHTnoi7s5uDpsadB/Qn9JJ6XsOmW9Gah+NQmqVBy+dgNDMm2QMmColK2+ELl7/NjLf/FhcH7Q/OncGp2JjyJzyGUlDS+4vzEx8PFBwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Orders
{
    /// <summary>
    /// The redirect URLs. Required only for the PayPal payment method. The supported settings are return and cancel URLs.
    /// </summary>
    [DataContract]
    public class RedirectUrls
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RedirectUrls() {}

        /// <summary>
        /// The URL where the payer is redirected after he or she cancels the payment.
        /// </summary>
        [DataMember(Name="cancel_url", EmitDefaultValue = false)]
        public string CancelUrl;

        /// <summary>
        /// The URL where the payer is redirected after he or she approves the payment.
        /// </summary>
        [DataMember(Name="return_url", EmitDefaultValue = false)]
        public string ReturnUrl;
    }
}

