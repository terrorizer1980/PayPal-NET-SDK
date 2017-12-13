// This class was generated on Wed, 13 Dec 2017 14:32:19 CST by version 0.1 of Braintree SDK Generator
// Phone.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8RQQUvzQBC9f79imFPLF4oF9ZBbSb3WosWLSNlkp+nAZjbubMAg/e+yJuagFQ8ePM6bN2/ee6+461vCHLdHL4QZPpjApnS0MU2CMcM1aRW4jewFc9wdCdrEBemaksICM1yFYPpB5yLDOzL2VlyP+cE4pQQ8dxzITsA2+JZCZFLMHycHGgNL/dVC5TuJod9X3tJZOyMBKuMcSw2JCLOimGdgFCwdWMhC2cPNYnl9uYB005gXbroGKt+U72tHUscj+AMUxX8xSd44YIXlFViuOepvk0rn3Cn7Me7H7/3Q79nEk7+B803O1WceVF6UNWqKOe0saeRhGqvbrIs5GLGgXZlep9NRYXa/mf9tg0+nf28AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The phone number.
    /// </summary>
    [DataContract]
    public class Phone {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Phone() {}

        /// <summary>
        /// The country calling code (CC), as defined by E.164. The maximum combined length of CC+national is 15 digits.
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The national number, as defined by E.164. A national number consists of national destination code (NDC) and subscriber number (SN). The maximum combined length of CC+national is 15 digits.
        /// </summary>
        [DataMember(Name="national_number", EmitDefaultValue = false)]
        public string NationalNumber { get; set; }
    }
}

