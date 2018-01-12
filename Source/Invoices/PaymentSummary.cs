// This class was generated on Mon, 08 Jan 2018 16:45:11 CST by version 0.1 of Braintree SDK Generator
// PaymentSummary.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+ySTWsVMRSG9/6KQ1YKQ/ELhNlp3YjQFlvcSBdnknd6I5kknpwIQfrfZdreucYPRKi7LuclkzzPOe83c9EyzGjOuC2ISud1WViaGcxHFs9TwAkv6wEzmPdoh4+3KFZ8Vp+iGc3FDpTvruDoSDDX6Kjc3nZkBvNahNvtY08H8wHsTmNoZpw5FKzBl+oFbgvOJGWIehQzftowj6sIov0NX9IdpIPcJz3pGy6gNH2GVZqTEIdAs48credAXzlUkCCwwtHsEVyhxxMHjhbDpugqBoLaoyf3ZlZUfLz61cveGR8nh07PHkbRG76gAFUI7U+QTQ7EhRxmH+FoavTu/JRePn/26p9Wo1J/4o81hOvhrxI3Y+3o90mPzkuqUalm0kQn5PyVV+J5ldEdyMH6hUOhgszCuq7vYOXjZnWz2fUPzllSFs+Kfhz34X35g/mfi5m5ZQ6d/BY9VPOhmv+pmpfXj74DAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The payment and refund summary.
    /// </summary>
    [DataContract]
    public class PaymentSummary {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentSummary() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue = false)]
        public Currency Other { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="paypal", EmitDefaultValue = false)]
        public Currency Paypal { get; set; }
    }
}

