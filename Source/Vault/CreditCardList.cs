// This class was generated on Mon, 11 Dec 2017 15:04:24 CST by version 0.1 of Braintree SDK Generator
// CreditCardList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zSz04yMRAA8Pv3FJP5LposricPe9ugiQciRokXQszQHWCktOu0YIjh3U1rQgjrQSLX+dP5TdtPHG1bxgr7yo3EPmkzkBCxwBdSoanlB1qlPBZ4y8GotFG8wwprsBIi+BmY3AqGtAlXWGCtStvvY68LfGJqhs5usZqRDZwC72tRbvaBR/UtaxQOWI2PQJBEXY1EXoUuyQGl2Uco8NM3NvHYdnOqza2t3RV74EDcEg4AMMxjulgrbtnFjhZ8iOyFlo3MxMD4vh7dDetnyH2Ti7LxJpTUSuk3rBvhj/L/giJ7Cr1ccnnmxcRFnrN2F4k+kn39+e7TOjkPbr2asqY3yJV//RGn4Vqa8+9wufIsuMnu3xcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Vault
{
    /**
    * A list of credit cards.
    */
    [DataContract]
    public class CreditCardList {

        // Required default constructor
        public CreditCardList() {}

        /**
        * An array of credit card objects.
        */
        [DataMember(Name="items")]
        public List<CreditCard> Items { get; set; }

        /**
        * The credit card-specific [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The total number of items.
        */
        [DataMember(Name="total_items")]
        public int TotalItems { get; set; }

        /**
        * The total number of pages.
        */
        [DataMember(Name="total_pages")]
        public int TotalPages { get; set; }
    }
}

