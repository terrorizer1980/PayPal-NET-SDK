// This class was generated on Wed, 13 Dec 2017 14:32:17 CST by version 0.1 of Braintree SDK Generator
// Invoices.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6ySwWrbQBCG732KYc/C9NSDbqIttGDq0ppeSojGq7E18WpWmR2ZmOB3D5KNYlu+hOS6wzLf98//7Jb7llzufsousqfkMvcPlXEV6Bc2/cRl7hslr9waR3G5m3MyiGtoSH2NYsCnvzP4igIsPnQVgdUEFg3DOAcfOzFAqeBHsfy+KP5CYNkmWEcFwR1vsF8xc5krVHF/RPucuT+E1ULC3uVrDIn6h8eOlarx4bfGltSYksv/X0tNnfjV9tKtEMB+de83YmOCRKi+BqXUBbsC/PJWQOlCOGQj5ZxlC2cYsFg9kLcp9RDWBHlZ0404S6EnK4esy1Zpx7FL5VnIwDJc6GgEiT7aisVoQzq1GDpxP1ThpsuxM9I1K9KLM1iNBg2arwfy00m8spEyvrc1A/7d4dMLAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// List of merchant invoices. Can include the total invoices count and HATEOAS links for navigation.
    /// </summary>
    [DataContract]
    public class Invoices {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Invoices() {}

        /// <summary>
        /// An array of invoices as search result.
        /// </summary>
        [DataMember(Name="invoices", EmitDefaultValue = false)]
        public List<Invoice> InvoiceList { get; set; }

        /// <summary>
        /// The HATEOAS links for `next` and `previous` navigation in the result set.
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The total number of invoices that match the search criteria.
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }
    }
}

