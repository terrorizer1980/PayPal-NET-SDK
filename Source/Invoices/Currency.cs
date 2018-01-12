// This class was generated on Mon, 08 Jan 2018 16:45:03 CST by version 0.1 of Braintree SDK Generator
// Currency.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zRT0skMRAF8Pt+iiKnXWiG/QcLfdudvYgwIypexEN18nqMpJNYqQiNzHeXHp0ZWg8ieEwlgfd79WguxwzTmmUVQbSjacwVi+cuYMXDdGMac4rxePiPYsVn9Sma1vzjAkrdHaxSn4Q4BOp95Gg9B3rgUEGCwApHvUdwhb52HDhaNJR5HBCVXEVDULv4ZhrzV4TH51TfG3MOdusYRtP2HAqmwX31AncYnEnKEPUopr0+eIqKj5u3GvviXCaHmcweC5gLf1GAKoT2L8gmB+JCDr2PcNSNdHKxpt8/f/xZfASgUl/ljzWEbfMuYlfrLP1+Mo/OQ6pRqWbSRCtyfuOVuJ8wegtysH7gUKggs7BO6zuqfDyodpudfnDOkrJ4Vszr+Az3zfbLEwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Base object for all financial value related fields (balance, payment due, etc.)
    /// </summary>
    [DataContract]
    public class Currency {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Currency() {}

        /// <summary>
        /// REQUIRED
        /// 3 letter currency code as defined by ISO 4217.
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// REQUIRED
        /// amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public string Value { get; set; }
    }
}

