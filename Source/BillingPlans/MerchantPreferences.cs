// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// MerchantPreferences.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8xY3W7cNhO9/55ioJuvBdYr9wco4LvASQEXiW0kToAgDdaz5GjFhiIVznA3QpF3L0hJ+xNrkTpNjFzZpMjhmTkzh8P9u7jpWirOimcUVI1O4DpQRYGcIi5mxSsMBpeWLrFJq4pZ8ZhYBdOK8a44K25qgmbc2u62QuUDILQW3RwunLJRE0PtN9BEVYMRUJ6FQTwwCcQWpCbAVSBqyMksD18+f8qwqSlQHqrI4hsKoNABtm3wawKfh4rslIEGP5gmNuBis6QAvgK01m9IQ4XGkoYWu7QaUISaVniWjpOaAlxjd40WMIpvUIxCaztYGms5W/ZRWNBp41awRJsQgHH5k6MPklemb6pTlmaATvf4VIobmOrAof8zGGfEoN0CSvh4XsyKRyFg13N0OiueE+orZ7virELLlCbeRxNIbyeug28piCEuzt5s2WUJxq3u8olKUSukF8O5C0nrp0gegaUFKQQogCE51BvIfEtteKA8AT3xznbZ9UBMYT2sqqLEQBCZ/qt/Llr7cfZ5J6P4RSJkgY2PTu74d+G0USjE34T9Odwc29JbEy/prIwt56jrUimtjY9suzFVWdWk417S8hxeoY3JzNmf8fT0FxVt/kv9yJr9kfK6/48ur/qZcjc1Hx3WnhiclwnPD0vwSBTm8JgqjFaSb//m4GHmEOsx5K+fvDgO/RhXn4U8CWEM5cNkaK9gixjsZO29fP70mAxOad+9ykpC/ELMNYYFk0wiTh9RCYWs7t+xNgy6u0hFNsjDohfpSb/uqd9fVqDnV5c3F5cvn0zk+s0+zxCoQeM4o1rT9pL59G7rhcUwoNak05V7tHovqlxHJ6OAGQZyKVx69pU1cU8nbkeHb+8nB+ePLs+fPL0TpRGoCpQ1/aA2YBkl5SSDEQYWlKS/0FIPPDoxfTV9SqiyhIFzhI5/7ruO0djeoaR8QyNRR43kpDlmw/BQ7KSnw1QeZtfSevXuffRC+7MswbvVoMdeaEjMcn8eXvuYxSVyrzi3TBLbRUV0C+uc0cgHDgwpljIrmNVqENvb48W1ZfpTlA9T9Q1+GEANfd90X3vf7vEwq09vUzdpVN1vSxpRpYjQ0e0P47zzYqruvpeNyX2BqUxSkNT9HZbVBnkoOP19CXwgicF9ydU6vjC+4d16HkN6LnV3YW8rbhL1EpnAL/8i1V+uaC1UxqFTqRpziZ4Espgbc0NW8ww4vbuQR22ebdNPx+GBwh68+/ZvDrVz+q5nb6QORCe7/uHixdXJrz//9BuM2yAp/dsfapGWz8pS05psOn7eYteinSvflNorLo0TWgVMxkttAikpA7GUo6GTZIjLHx+mXcqkTPdKo2N5yRyemVWdrgxAB9kHCpnkYZ0hBmveEfxx/Xr3Dks9u3TtcCtXoZdZtJCf4ZqUadBu5yft3Vw+3tnjuNRmbVK/YFzuGHxkdFpqnsPvvhf4MIRlTyHHk1qLu18BDqibARPBm4sXV5B43TG52Wzmhv3ch1Vp2Je1b6jMLQUGzVvaFpm2eS3NV2Hu7ce3H//3DwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
    /// </summary>
    [DataContract]
    public class MerchantPreferences {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public MerchantPreferences() {}

        /// <summary>
        /// The payment types that are accepted for this plan. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="accepted_payment_type", EmitDefaultValue = false)]
        public string AcceptedPaymentType { get; set; }

        /// <summary>
        /// Indicates whether PayPal automatically bills the outstanding balance in the next billing cycle. The outstanding balance is the total amount of any previously failed scheduled payments. Value is:<ul><li><code>NO</code>. PayPal does not automatically bill the customer the outstanding balance. Default is <code>NO</code>.</li><li><code>YES</code>. PayPal automatically bills the customer the outstanding balance.</li><ul>
        /// </summary>
        [DataMember(Name="auto_bill_amount", EmitDefaultValue = false)]
        public string AutoBillAmount { get; set; }

        /// <summary>
        /// REQUIRED
        /// The URL where the customer can cancel the agreement.
        /// </summary>
        [DataMember(Name="cancel_url", EmitDefaultValue = false)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// The character set for this plan. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="char_set", EmitDefaultValue = false)]
        public string CharSet { get; set; }

        /// <summary>
        /// The action if the customer's initial payment fails. Value is:<ul><li><code>CONTINUE</code>. The agreement remains active and the failed payment amount is added to the outstanding balance. If auto-billing is enabled, PayPal automatically bills the outstanding balance in the next billing cycle. Default is `CONTINUE`.</li><li><code>CANCEL</code> PayPal creates the agreement but sets its state to pending until the initial payment clears. If the initial payment clears, the pending agreement becomes active. If the initial payment fails, the pending agreement is canceled.</li></ul><blockquote><strong>Note:</strong> You can use the `setup_fee` value as the initial amount to trigger the `initial_fail_amount_action`.</blockquote>
        /// </summary>
        [DataMember(Name="initial_fail_amount_action", EmitDefaultValue = false)]
        public string InitialFailAmountAction { get; set; }

        /// <summary>
        /// The maximum number of allowed failed payment attempts. Default is `0`, which allows infinite failed payment attempts.
        /// </summary>
        [DataMember(Name="max_fail_attempts", EmitDefaultValue = false)]
        public string MaxFailAttempts { get; set; }

        /// <summary>
        /// The URL where the customer is notified that the agreement was created. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// REQUIRED
        /// The URL where the customer can approve the agreement.
        /// </summary>
        [DataMember(Name="return_url", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="setup_fee", EmitDefaultValue = false)]
        public Currency SetupFee { get; set; }
    }
}

