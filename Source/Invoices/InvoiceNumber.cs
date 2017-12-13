// This class was generated on Wed, 13 Dec 2017 14:32:25 CST by version 0.1 of Braintree SDK Generator
// InvoiceNumber.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SPMUvEQBCFe3/FMPV5WKcTbGxUJNiIxVzyzgzszsbZyWGQ++8SgoHT0vbb9/Z788XtPIIbvrdT0Q5kUz7Aeccv4iqHhAfJyzvv+A61cx1Di63g1l3mtX+z42dI/2hp5uYoqWIBH5M6+g08eRnhoajcvG7mGq72/te4Lbn0tgPI8BmkF4spBgnSSnISTcs3FIViAGV4N4jFntpB6098SU5RrtU6R4YFejp6yWul1CBHB/ut2f/zbJtSOr+dr74BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    [DataContract]
    public class InvoiceNumber {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceNumber() {}

        /// <summary>
        /// The next invoice number that is available to the merchant. This number is auto-incremented from the most recent invoice number.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }
    }
}

