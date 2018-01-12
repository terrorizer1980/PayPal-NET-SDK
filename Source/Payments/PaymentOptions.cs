// This class was generated on Wed, 13 Dec 2017 14:31:44 CST by version 0.1 of Braintree SDK Generator
// PaymentOptions.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SPMUvEQBCFe3/FMHUQ63SCtYoEG5FjzL6Yhc3u3swEWeT+u8Q7r1DQwvbt93a+985Dq+Ceq7QF2XeleizZuONH0SgvCbeybAB3fAMbNX4C3PMwg04tOrVIsV9hjkBTUfI5GrlKNhm390vu+FpV2vHmVccPkHCXU+N+kmTYgv0aFeEc3GupUI8w7p/OtuYa8+tPSUmpvCHsvtYs8LmEX9WPyF/mNGzJFJEChQKjXJyk1tTIC/kMGhUhOo2i4dvf/52d15QOz4eLDwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The payment options requested for this transaction.
    /// </summary>
    [DataContract]
    public class PaymentOptions {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentOptions() {}

        /// <summary>
        /// The payment method requested for this transaction. This field does not apply to the credit card payment method.
        /// </summary>
        [DataMember(Name="allowed_payment_method", EmitDefaultValue = false)]
        public string AllowedPaymentMethod { get; set; }
    }
}

