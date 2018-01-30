// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Currency.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/6TSUYsTMRAH8Hc/xZAnPdKuiiD0TRBBhLuihy/lkGny33YkTeJkVlzkvrtsde8sFeS4x50dJvn/Jj/d9VjhVi4MqshhdN59ZhXeJlzyYfrjvPuA8f7jLVpQqSYlu5W73oO23EDzACrbrwhGfVHilKiXzDkIJ/rOacBCkdgQqRek2Jb0rijhBx9qgqctJ84BniqPB2SjOMAT50itUMlL590bVR5/X/q5dx/B8Sqn0a16Tg1T4dsginhXWGupUBM0t9rcxW2mknfnYecUX0KJOEn+F9C5wMb2CizCnpWDQen9p6vFq5cvXt+zTANvnnaxhNZJNuyUpwFdFEWwTtGsm5sXU3Prni1pzeOaE8WCRrkYtaHWonaU/dMtaI91yUNKt/6/OMcFnqDMlXMRPpQhm6ehkhW6uLygKDuxRtxPPrYHRQQ5cKKGyspW1BM3iuglI5Jk2syKD3U7Pr7pCK5VS1Vhw+kmHiRmOvwL7Ob2yS8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
    /// </summary>
    [DataContract]
    public class Currency
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Currency() {}

        /// <summary>
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/). PayPal does not support all currencies.
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue = false)]
        public string CurrencyCode;

        /// <summary>
        /// REQUIRED
        /// The amount, up to *N* digits after the decimal separator, as defined in [ISO-4217](/docs/integration/direct/rest/currency-codes/) for the appropriate currency code.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value;
    }
}

