// This class was generated on Mon, 11 Dec 2017 16:45:16 CST by version 0.1 of Braintree SDK Generator
// Currency.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zRTUszMRDA8fvzKYacHmEpvoGwN18uXlpR8SIeZpPZOjKbxMlEWKTfXbZiS+1BBK+TBP6/zLu7HzO51l1WVYp+dI17QGXshOY4TCeucVdUvHI2TtG17gILQepeyBv0SQFFoOeI0TMKvKFUAiVBowA9k4QC/zsUjJ4ayDgOFA1CpQbI/OzANe5cFcfPkMPG3RKGRZTRtT1KoWnwWlkpbAY3mjKpMRXXPm4IxZTjch/gt7RdyAkImZHC1w3wKRBggUA9RwrQjXB9t4DT46Oz2W86Teu3zFhFVs2Prevf2wvFIdVoUDNYgjkEXrIB9lO6PRME8jygFCiUUdGmnWwNHDeG9bqmF5izpqyMRrv4v1A+rf59AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Base object for all financial value related fields (balance, payment due, etc.)
    */
    [DataContract]
    public class Currency {

        // Required default constructor
        public Currency() {}

        /**
        * REQUIRED
        * 3 letter currency code as defined by ISO 4217.
        */
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /**
        * REQUIRED
        * amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code.
        */
        [DataMember(Name="value")]
        public string Value { get; set; }
    }
}

