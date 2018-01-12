// This class was generated on Wed, 13 Dec 2017 14:31:43 CST by version 0.1 of Braintree SDK Generator
// Payee.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xVTWvbQBC991cMe0kDlmSnJQXfSpODD21DGtpDCGa8O7IWVrPq7CquKPnvZSXb+bBDAjU5eubt05s3H/6rrrqG1FQ12BGpkfqJYnHh6BvWKaxG6oyCFttE61lN1VVF0GNhVXkQ0mRvKUCsCMqWTQBkA2XrSuvcEPZiSHI1Up9FsBs+Nx6pS0LznV2npiW6QCnwu7VCZhu4EN+QREtBTa+3QkMUy8tdpVSjdXvl9hlAY4RCAAzBa4uRDKxsrHqJfUFHAS6wu0AHqLVvOeYwK4e0+FtryDxhsgHYxx1C5O4J0ej+I6CRwbPrNtZtoL/QOYoJVBPHkMOZFdIRtJCxETSK2SYBhcAQWzJgWoLoh7z2deMssiaQwcyB6z+959a5u9GLDahJdIUc59bsbwNr6Zpk02N3YHYGpZd7jw6st+ecGxsah928pogGI+7qfxa3W8oalPWN3CAPW8TLA78QZDPn9OO5JZWjAIs2WE7jmpAHtnZjVlN53nM8nqafuSRHAXoEcFsv3uJU9GMn3Vx7s1/WdVz5TFcoqCMJzH6Msw+T09NsAuunkJ7evK9ibMK0KAzdkksK8ga7Bl2ufV0Yr0NhOdJSMHEXpt/oQijEYs2TJZ5QHIMvHx2idfqNNnfwfa8TlrNNyQ97NALLcH2eT04/riOWl9A45LQFNcZ7b1arVW5jm1tOpeviKrs8/5L1T7OT8WQ8mWSz44MUevOKUl/7L/FwlyWHr/jH1m0NjngZq3T5JyefYDsh4UD6b+7e/QMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The payee who receives the funds and fulfills the order.
    /// </summary>
    [DataContract]
    public class Payee {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Payee() {}

        /// <summary>
        /// The email address associated with the payee's PayPal account. If the provided email address is not associated with any PayPal account, the payee can only receive PayPal Wallet payments. Direct credit card payments are denied due to card compliance requirements.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The encrypted PayPal account ID for the payee.
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The display-only metadata for the payee.
        /// </summary>
        [DataMember(Name="payee_display_metadata", EmitDefaultValue = false)]
        public PayeeDisplayMetadata PayeeDisplayMetadata { get; set; }
    }
}

