// This class was generated on Mon, 11 Dec 2017 13:16:17 CST by version 0.1 of Braintree SDK Generator
// AmountDetails.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yWz6sTMRDH7/4VQ45l6at4603w4kEtWryolOlmthnIJnnJxHaR979Luj/g8RafohQPe1om35nMd/NhsvtD7btAaquw9dnJQZMg26Qq9Rkj49HSe2yLrir1hlIdOQh7p7ZqbwhQay4hWhgKAY8+C4ghCNi15AT6ndeqUq9jxK7vt6nUR0L9wdlObRu0icrCfeZIelrYRR8oClNS2y+T0ySR3empwxM3cjhHDLNWiwpFhYZoDe/wwm1uwZI7iQFO8HIDtcGItVBMFZwN1wbY1TZrStuvebN5VWd7fVIfWe6jT/SdHGg+sSQ4UuMjXQ9AU80tWgienaz7mrux6PEW+z9MP/uxHzZC8Xfb3Y0v8JcwXLb2oXqWiEGnLbvToSGahTImLEyK5RyCj0IaGt9X77DbleJhkFoS4zV4Z7v1bQCySzmiq+fpTeqC7xG+AujXDG+ELxkOoVee0hvFBd7N7sPxyA+aU10+is+CgTFzGa//73ZM+She0M5THMTh92dyzUJtWsPb5hpFus+UZKIGlt2QU4EYThB6X10BvlrFwfZqtYzsTRgLXmbxCl4WAv+AwLeHFz8BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The additional details about the payment amount.
    */
    [DataContract]
    public class AmountDetails {

        // Required default constructor
        public AmountDetails() {}

        /**
        * The gift wrap fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        */
        [DataMember(Name="gift_wrap")]
        public string GiftWrap { get; set; }

        /**
        * The handling fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported for the PayPal payment method only.
        */
        [DataMember(Name="handling_fee")]
        public string HandlingFee { get; set; }

        /**
        * The insurance fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported only for the PayPal payment method.
        */
        [DataMember(Name="insurance")]
        public string Insurance { get; set; }

        /**
        * The shipping fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        */
        [DataMember(Name="shipping")]
        public string Shipping { get; set; }

        /**
        * The shipping fee discount. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported for the PayPal payment method only.
        */
        [DataMember(Name="shipping_discount")]
        public string ShippingDiscount { get; set; }

        /**
        * The subtotal amount for the items. If the request includes line items, this property is **required**. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        */
        [DataMember(Name="subtotal")]
        public string Subtotal { get; set; }

        /**
        * The tax. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        */
        [DataMember(Name="tax")]
        public string Tax { get; set; }
    }
}

