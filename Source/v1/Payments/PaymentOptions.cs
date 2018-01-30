// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// PaymentOptions.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/6SQMUsEMRCFe3/FMPUi1tsJdoKKLDYix7h56waySW4yiwS5/y7xzhOVw8IyLx+P980bDzWDe85SF0TbpGw+xcIdP4h6eQ64kaUB3PE16tfjCmVU/0Fzz8MMOlTQoYIU2xXF4GhKSjb7QqYSi4zt/5w7vlSVuh9w0fE9xN3GULmfJBS0YLt6hTsGd5oy1DwK94/H6cXUx5ffiyWE9Aq3+VRbYHNy3zxOIqft9shfcjS0ZPIIjlxCoZiMJOdQyRLZDBoVzhuNou5H938vE9cQdk+7s3cAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payment options requested for this transaction.
    /// </summary>
    [DataContract]
    public class PaymentOptions
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentOptions() {}

        /// <summary>
        /// The payment method requested for this transaction. This field does not apply to the credit card payment method.
        /// </summary>
        [DataMember(Name="allowed_payment_method", EmitDefaultValue = false)]
        public string AllowedPaymentMethod;
    }
}

