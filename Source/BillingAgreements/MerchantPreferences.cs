// This class was generated on Wed, 13 Dec 2017 14:32:57 CST by version 0.1 of Braintree SDK Generator
// MerchantPreferences.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8xX34/bNgx+319B+GUb4Ni3H8CAvBW9DsjQ5g5tWqDoihwj0bEwWXIlKjlj6P8+SLZzSc9Bd1172FMiWab48SM/0n9nq66lbJ69ICdqNAyto4ocGUE+y7M36BRuNC2xiaeyPLskL5xqWVmTzbNVTdBMvAqVdYDQajQFLIzQQZKH2u6hCaIGxSCsZw9swRNDaIFrAtw6ooYM52n5+uVzD/uaHKWlCJ5tQw4EGsC2dXZHYNNSkJ4y0OCtakIDJjQbcmArQK3tniRUqDRJaLGLpwGZqWnZ5/E6rsnBNXbXqAED2wZZCdS6g43S2ifLNrBnNFKZLWxQRw9AmfTI0C2nk/GZ6ISmHNDI3j8R4waqOgH0vQdlFCvUB4eif77I8uyJc9j1HF3k2UtCeWV0l80r1J7ixoegHMnDxrWzLTlW5LP5uwO7np0y2/t8ohDUMsn1cO+a4/kpkkfH4oEYAmRAFwH1BhLfXCt/R0EB0duZNbpL+B15crvhaBU4OILg6b+CNEHrj/nnkQa268jKGhsbDN8DuTBSCWTy3yQFClide6W3xpbjXcm3lKimi/W0UzZ43Y356kVNMhxlri/gDeoQzcz/DBcXv4ig0y/1K62OV8LK/h8tr/qd8m6rGAFLSx6M5Qnkp3V4JgoFXFKFQXPE9m8uHnZOfT3n+dtnr867fo6rz7o86cIYysfJ0F7G1sHpyQJ8/fJ5VMt9rUR9ikl5cCSVIxELsdeWblIVH1Rr7MIXAqnRrT3xJIz4EAWTS7r/f1cNJSdBLC5jifKZ3vdYvvUtYx2lYRC1dd9fJn1+YOv5Mll5erVcLZavn01U6Oo4EcFRg8r45NWODv3x07bcy2HMDylJxvw/qzmLKlX/bJRd5YFMDJfMv7KSH6nbzQj45mEi9vTJ8umz5/eiNDoqHKVOdFK8sAkci8aDYg+ekWPXgJZ6x4Nh1Zf7p4QKTeh8itD5x/3ANBo7upSEbWgk6qyRlDTnbCg/qBHJ6TCVj6u0Dd4OVTOMfdNj7UOHx9PMuLjJB7FOr8U6q2LU6OzrjwPeEQdnvlqb6QfAb9lmXlhDXZo7Ya+4BhFc1NkOYt3Ah4BaVYok7KJg3cfriUO7ruj+WPukN5q+VLSGShk0IiZ1sjRzpDFNtoq09AX8bh3QLTZtHOgHmcgPLMowjPnegjXffnIfozBJ4juuHdHsrtcuXl3Nfv35p99Og/f+h5q59fOylLQjHa8vWuxa1IWwTSmt8KUyTFuH0XjZk1868lyOhmbRkC9/fJzRYuR4Yq4YgaUjBbxQ2zqqF6CBhIFcYno4p8iDVn8R3Pxx/fbm7nsmjr3ctUOLqFzfNVFD+pztw9pqFASShGpQH85MW18tL4+s+7CRaqdiK1MmNTMbPBrJ9ZBfsYzcEKYj4RnvSjeP39YnVObgieDd4tUVRJ57Zudlud/vC+VtYd22VN6WtW2oTM0OnfQHFteJxaLm5qsQ+f7j+4/f/QMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
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
        /// The payment types that are accepted for this agreement. Read-only and reserved for future use.
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
        /// The URL to which the customer is redirected if they cancel the agreement.
        /// </summary>
        [DataMember(Name="cancel_url", EmitDefaultValue = false)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// The character set for this agreement. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="char_set", EmitDefaultValue = false)]
        public string CharSet { get; set; }

        /// <summary>
        /// The ID of the merchant preferences.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The action if the customer's initial payment fails. Value is:<ul><li><code>CONTINUE</code>. The agreement remains active and the failed payment amount is added to the outstanding balance. If auto-billing is enabled, PayPal automatically bills the outstanding balance in the next billing cycle. Default is `CONTINUE`.</li><li><code>CANCEL</code> PayPal creates the agreement but sets its state to pending until the initial payment clears. If the initial payment clears, the pending agreement becomes active. If the initial payment fails, the pending agreement is canceled.</li></ul>
        /// </summary>
        [DataMember(Name="initial_fail_amount_action", EmitDefaultValue = false)]
        public string InitialFailAmountAction { get; set; }

        /// <summary>
        /// The maximum number of allowed failed payment attempts. Default is `0`, which allows infinite failed payment attempts.
        /// </summary>
        [DataMember(Name="max_fail_attempts", EmitDefaultValue = false)]
        public string MaxFailAttempts { get; set; }

        /// <summary>
        /// REQUIRED
        /// The URL to which the customer is redirected if they accept the agreement.
        /// </summary>
        [DataMember(Name="return_url", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="setup_fee", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue SetupFee { get; set; }
    }
}

