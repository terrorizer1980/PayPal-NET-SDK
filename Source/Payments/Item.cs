// This class was generated on Mon, 11 Dec 2017 13:16:24 CST by version 0.1 of Braintree SDK Generator
// Item.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8yUT2sbMRDF7/0Ug04JrL1JKAR8C/RS+icmTnoJOUy1Y+9graSMRsWi5LsX1XgprZ22tJicln16O/zezKy+mtsSycwMKw2mMZ9QGD87+ohDVU1j3lCywlE5eDMztz1BtUJHiuzS1DTmSgTLtsxZY24Iu2vvipkt0SWqwmNmoW4U5hIiiTIlM7sfAZIK+9WvCDaLkLdlL8q99kI0sT0KWiWBt4vryeuL80vYfQY2dPRw0nbBppa90kqwFmg7FrLaCiVtd+ZJNaf29K9SqeSfQvns3FPz22TdD3Ge6fMoT2GRYwyi1EHwrsAyCGhPMMcyRwcRy0BeYSDtQ/evk/nDEL4+DtLX0yl8wA0PeQBHfqU9cILzi0sYh5aO0+4obJ9BtSHpXtSzo5M+ZvTKWg7D7hwvBDit817WpMGuYU0U2a8ge1Y4Wby7Ox03t4Y50qIqbg73U3HzIv+uLG4v9N3Ne9CwZWe/DDLg9oa4+oLsaoF6XOkjFhJg//1FBX1CW63Qc9Ig5b8EeXh69Q0AAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The item details.
    */
    [DataContract]
    public class Item {

        // Required default constructor
        public Item() {}

        /**
        * REQUIRED
        * The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/).
        */
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /**
        * The item description. Supported only for the PayPal payment method.
        */
        [DataMember(Name="description")]
        public string Description { get; set; }

        /**
        * REQUIRED
        * The item name. Maximum length is 127 characters.
        */
        [DataMember(Name="name")]
        public string Name { get; set; }

        /**
        * REQUIRED
        * The item cost. Maximum length is 10 characters.
        */
        [DataMember(Name="price")]
        public string Price { get; set; }

        /**
        * REQUIRED
        * The item quantity. Maximum length is 10 characters.
        */
        [DataMember(Name="quantity")]
        public string Quantity { get; set; }

        /**
        * The stock keeping unit (SKU) for the item.
        */
        [DataMember(Name="sku")]
        public string Sku { get; set; }

        /**
        * The item tax. Supported only for the PayPal payment method.
        */
        [DataMember(Name="tax")]
        public string Tax { get; set; }

        /**
        * The URL to item information. Available to the payer in the transaction history.
        */
        [DataMember(Name="url")]
        public string Url { get; set; }
    }
}

