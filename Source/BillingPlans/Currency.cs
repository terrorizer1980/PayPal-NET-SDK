// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// Currency.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6ySUWvUQBDH3/0Uwz4p5LIqgnBvYhEq2Cv2EOQoMtmd3K5uduPM5I4g/e6StM2hLYjQ18nmP/Ob3/wy27EnszbvB2bKbjSV+YIcsUl0gd30xVTmjMRx7DWWbNZmGwgaFILSfCen0BYGTAnamDG7iAkOmAZaMSVU8tBGSl4qkMEFQIEGE2ZHFfQ4dpQV/EAVYPYgBUquTWXeMeN4O9nLynwm9JucRrNuMQlNhZ9DZPJL4ZJLT6yRxKx3C5Mox7x/SOROrA/JdhqYaOUCMjolhvOrzerN61dv4f43cMXT9fOg2svaWk8HSlP7usexx1S70llfnNiYlfaMU7j1kcmpZRK190GrKUjsi/8iVh7+As5DSjfVP6lnKY8iL2Dzkxo+xX1QaAgww8xAPEu+exdJIMUfBB8vv4IGVEAmyEVBxz46TGmEdlpeLBkTTNcBnlzsMC31R/O2F2enPBkaHw/Rk59mKKChDILZa5AaPhQGDQR8txbIQ9cQQ2mXTn1CR3J7nH+qq0CIYHd+tYHJ68nk8Xiso5S68N5GKTaUjqwoZo/sZdH2bdZWB+2exNz1zbPfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// The base object for all financial value-related fields, such as balance, payment due, and so on.
    /// </summary>
    [DataContract]
    public class Currency {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Currency() {}

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](https://developer.paypal.com/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// REQUIRED
        /// The currency value. Might be an integer for currencies like JPY that are not typically fractional or a decimal fraction for currencies like TND that are subdivided into thousandths. For the required number of decimal places for a currency code, see [ISO 4217](https://www.iso.org/iso/home/standards/currency_codes.htm).
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value { get; set; }
    }
}

