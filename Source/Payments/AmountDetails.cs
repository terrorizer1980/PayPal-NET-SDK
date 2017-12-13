// This class was generated on Wed, 13 Dec 2017 14:31:42 CST by version 0.1 of Braintree SDK Generator
// AmountDetails.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yWz6sTMRDH7/4VQ45l6at4603w4kEtWryolOlmthnIJnnJxHaR979Luj/g8RafohQPe1om35nMd/NhsvtD7btAaquw9dnJQZMg26Qq9Rkj49HSe2yLrir1hlIdOQh7p7ZqbwhQay4hWhgKAY8+C4ghCNi15AT6ndeqUq9jxK7vt6nUR0L9wdlObRu0icrCfeZIelrYRR8oClNS2y+T0ySR3empwxM3cjhHDLNWiwpFhYZoDe/wwm1uwZI7iQFO8HIDtcGItVBMFZwN1wbY1TZrStuvebN5VWd7fVIfWe6jT/SdHGg+sSQ4UuMjXQ9AU80tWgienaz7mrux6PEW+z9MP/uxHzZC8Xfb3Y0v8JcwXLb2oXqWiEGnLbvToSGahTImLEyK5RyCj0IaGt9X77DbleJhkFoS4zV4Z7v1bQCySzmiq+fpTeqC7xG+AujXDG+ELxkOoVee0hvFBd7N7sPxyA+aU10+is+CgTFzGa//73ZM+She0M5THMTh92dyzUJtWsPb5hpFus+UZKIGlt2QU4EYThB6X10BvlrFwfZqtYzsTRgLXmbxCl4WAv+AwLeHFz8BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The additional details about the payment amount.
    /// </summary>
    [DataContract]
    public class AmountDetails {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AmountDetails() {}

        /// <summary>
        /// The gift wrap fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [DataMember(Name="gift_wrap", EmitDefaultValue = false)]
        public string GiftWrap { get; set; }

        /// <summary>
        /// The handling fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="handling_fee", EmitDefaultValue = false)]
        public string HandlingFee { get; set; }

        /// <summary>
        /// The insurance fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported only for the PayPal payment method.
        /// </summary>
        [DataMember(Name="insurance", EmitDefaultValue = false)]
        public string Insurance { get; set; }

        /// <summary>
        /// The shipping fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue = false)]
        public string Shipping { get; set; }

        /// <summary>
        /// The shipping fee discount. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="shipping_discount", EmitDefaultValue = false)]
        public string ShippingDiscount { get; set; }

        /// <summary>
        /// The subtotal amount for the items. If the request includes line items, this property is **required**. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue = false)]
        public string Subtotal { get; set; }

        /// <summary>
        /// The tax. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public string Tax { get; set; }
    }
}

