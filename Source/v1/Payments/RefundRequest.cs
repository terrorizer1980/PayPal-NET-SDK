// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// RefundRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/+yYUYvcNhDH3/spBj+1h3f30hYK+xYohVDaHM2RlzQss9LYHiJLzkjKnSn97sUr22uv78KFXJc87NOhmb/k0fxmtNL9k922DWXbTKiIVu+EPkbyIcuztyiMe0N/Yt35szz7ndrj4FfySrgJ7Gy2zV5Cmg/9/HWWZy9FsE2rX+fZX4T6tTVtti3QeOoMHyML6dFwI64hCUw+274b48LaRftAPKP9GNVomsd2WxE02NZkAyRJDnccKtgL4YdVbPzzReuDsC2X0aooQla1s3gnxmXE70IlRCtVoaAKJPDqzevVzz+++AWGaaCcpvffb7RTfsM2UCnYLbDRLKTCRsiHzSBedWK/+WENN9jeoAHtyIN1AXxsGicB0JhhaaYvS0mQeJIRG435Nz+BuNMUkI1fpufoOGbnaFsmB7XmbtjtI8kA9y4GCAvW/z/bkouwuxNsZuFPrcsNdF7ovFAQreEPvOc61mDIlqEC9vDiGkb0Poe7ilUFbJWJmvz273h9/ZOK5vCX0shwGr2hT2RBc8nBw54KJ3RIiybFNRpoHNuwTnM2w6T5ErdfKL9zw/ew6Er1iZ/bDBv4SkQnxfYYpwqtNmzLXUE0Q3XiWNIaBBdYXcjpvCANhUuz+xNl6LuaQuU0OGva9XnIsvVR0Ko51ql1yXT0XqDOoHbYPk/2TFB9xU2TPEemE+MS6eC8ED3bmTqkfKfZq8WF7CHv57HBoLx05Ld3zPq4Dy6gmTM+Gh9A2zv7u9i4FQ5U+zW8Kg6j/s0wogTDttfkECr20KRg264Krq6k38vV1aXLzwI+4P2MeRovcQe8vxB5BiLvn8Jk0YmPt+GsBzsUJWkIbngtEcG+HQeyht+c9O95n4NQI+TJBn+Q9KuECsNkfq8eFnXCJdt0WHULXmria9/STykJPQE/f0lP7cvy6P91M5Gt4S2aSB0ohPQ5cAV4tqWh1b4NBGiaCm2sSVhNUJ7txv/JsaKdjfWe5OTaf+J66O5/kECSpFpmD9H3bSGoPvQ/POnH9pvPhxD6E+qj6VHgSTHj/jyn13f/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A refund request.
    /// </summary>
    [DataContract]
    public class RefundRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RefundRequest() {}

        /// <summary>
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount;

        /// <summary>
        /// The refund description. Value is a string of single-byte alphanumeric characters.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The invoice number that is used to track this payment. Value is a string of single-byte alphanumeric characters.
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber;

        /// <summary>
        /// The refund reason description.
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue = false)]
        public string Reason;
    }
}

