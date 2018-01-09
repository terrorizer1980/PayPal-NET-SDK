// This class was generated on Wed, 13 Dec 2017 14:34:03 CST by version 0.1 of Braintree SDK Generator
// CreditCardList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zSz04yMRAA8Pv3FJP5LposricPe9ugiQciRokXQszQHWCktOu0YIjh3U1rQgjrQSLX+dP5TdtPHG1bxgr7yo3EPmkzkBCxwBdSoanlB1qlPBZ4y8GotFG8wwprsBIi+BmY3AqGtAlXWGCtStvvY68LfGJqhs5usZqRDZwC72tRbvaBR/UtaxQOWI2PQJBEXY1EXoUuyQGl2Uco8NM3NvHYdnOqza2t3RV74EDcEg4AMMxjulgrbtnFjhZ8iOyFlo3MxMD4vh7dDetnyH2Ti7LxJpTUSuk3rBvhj/L/giJ7Cr1ccnnmxcRFnrN2F4k+kn39+e7TOjkPbr2asqY3yJV//RGn4Vqa8+9wufIsuMnu3xcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Vault
{
    /// <summary>
    /// A list of credit cards.
    /// </summary>
    [DataContract]
    public class CreditCardList {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCardList() {}

        /// <summary>
        /// An array of credit card objects.
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue = false)]
        public List<CreditCard> Items { get; set; }

        /// <summary>
        /// The credit card-specific [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The total number of items.
        /// </summary>
        [DataMember(Name="total_items", EmitDefaultValue = false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue = false)]
        public int? TotalPages { get; set; }
    }
}

