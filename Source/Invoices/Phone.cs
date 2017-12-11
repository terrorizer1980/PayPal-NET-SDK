// This class was generated on Mon, 11 Dec 2017 16:45:15 CST by version 0.1 of Braintree SDK Generator
// Phone.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8RQQUvzQBC9f79imFPLF4oF9ZBbSb3WosWLSNlkp+nAZjbubMAg/e+yJuagFQ8ePM6bN2/ee6+461vCHLdHL4QZPpjApnS0MU2CMcM1aRW4jewFc9wdCdrEBemaksICM1yFYPpB5yLDOzL2VlyP+cE4pQQ8dxzITsA2+JZCZFLMHycHGgNL/dVC5TuJod9X3tJZOyMBKuMcSw2JCLOimGdgFCwdWMhC2cPNYnl9uYB005gXbroGKt+U72tHUscj+AMUxX8xSd44YIXlFViuOepvk0rn3Cn7Me7H7/3Q79nEk7+B803O1WceVF6UNWqKOe0saeRhGqvbrIs5GLGgXZlep9NRYXa/mf9tg0+nf28AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The phone number.
    */
    [DataContract]
    public class Phone {

        // Required default constructor
        public Phone() {}

        /**
        * The country calling code (CC), as defined by E.164. The maximum combined length of CC+national is 15 digits.
        */
        [DataMember(Name="country_code")]
        public string CountryCode { get; set; }

        /**
        * The national number, as defined by E.164. A national number consists of national destination code (NDC) and subscriber number (SN). The maximum combined length of CC+national is 15 digits.
        */
        [DataMember(Name="national_number")]
        public string NationalNumber { get; set; }
    }
}

