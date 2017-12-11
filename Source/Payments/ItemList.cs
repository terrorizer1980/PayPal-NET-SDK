// This class was generated on Mon, 11 Dec 2017 13:16:24 CST by version 0.1 of Braintree SDK Generator
// ItemList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xX3XIbtw6+P0+B0bmJZ/RnJ8cXvkt8nByfTGKNf9oLNyNDXEiLZhfckNjISqczfY2+Xp+kA+5KsmOltVKPbjRaEh8JgOCHj790LhcVdY46rFSOC47a6XZ+wMA4Keg9ljbV6Xb+S9EFrpS9dI46LwUwBFyAn4LhImiOChgIJsQyg6oOLsdIWb/T7bw002aXYbdzTpidSbHoHE2xiGQDn2oOlK0GRsFXFJQpdo6u7/n30LW0+9P5d7itf1IXxa/dlZMx56pimY0xywLF+NDhDRb3fb/MCehWSTLKoDXqwjxnlwNHqKMNW0AEy7WWZsACCBUuShJ9usxHDSyzh6E41sVG920CBEv6pz58nd1vOeJr0bAYO5/RRoeude57LseATinA6cUZPN8/POztg0E+PBtk3sUBi9IsoOEGGQdyOggUddAu3zPbONhraokzEuUpU3MUrQ34AIFm7KX/Uz0cPneTwruPn2qvlL6bXxc1eJk1I++90lEzPLg7Dpd3lrWtYeoDvAmECq8CK7JYPTRIm29gb161a62HACUD8frA9urtBtu2xFhSXOqrXkGfqYDMl7alHWtMrqQ0tA724SpSAtwcH9w8dPs4Z0GY+1Bkc27HnC8rDHaMUIvzosEXBWVQBXYEz46vRntQkuY+68IE5SM4DFk3BeOCj7E38SGjABpQIjo7tthmffB12repQw3195VhwUL7G+tvyiEq2LwxkqWpvbF9eO0D0C2WVUFdkLqcUOhC1ECkTazRg5f+zgI4eBDAWfqDRT9VZCTnJXtELLFmpS5ghUGNj1bBfV9Q388O4kOJBX9JF3scFbXezLpLFr0HgAbQh3PSOghl4KVYpAKucEEhwjT4El4F/MLFjiKqci+biS7NrDLNAtcn/f2D5+ZuifrhWa5axaPBYD6f91nrPotxnBtc9s5PjnvJtncwHO4PD3qnA5K9PrzDWy7rEgqSmaYO9J8hrKg07ipiHxWLbxN8M5/45k6vtOL8wlVDQ1abn2r+jIU1R7hcVOywKBYQWv9aUjLmMlafs+bWTdcr2xIo91a5IILr0dpknWGS/pw/ckUZY9+H2cC+BqN1HHs7Sl0gxxWT6Nioe2P2bGJ5mVfmgAqac1xd7924a9ftG038Mb06wVed2k4U4eoiXeJ0fhbi+gCTgdec7hy83fQ7BXG3uwDfIzwrMRbwKyaMtF7mCK5fhplpBMFtnP43LlF7XbhuaGUr/CRBDHyMgtl2m7sEMfCpZLwdlg2RoIrFYjuoIQz6f6xQtoL+bAiDvqNbdn4rbJkgBr7MkQuUbCu4tqC9rlXW9ZWwUgYXZhK3WqiOuJFpXwwhsswK6k0WSrtn3Uf0yrY77sYftelN3tiE3cHNSuTmf2fvTsZn5+Mfz87f3nTh5s3p68ubpxYiHx6T0OXjr9G1G2NZPeoam0aNN3qb4/JxZ/LK5SbWry5GFzDC4GhX6mMVRBIb40Zs/HUoD2QJawSH4sV6MNglCYKNzGy1isWW0ZRNcU0WiXZNyxy++LsWm4z22s3S5gVKH07EQohQkr38RSOoh5hjoEbH/fHb7xHsFYJuKVUbCTDCxajxqnno1SFY51i+sqHR95IEwD30EpGWh3nu7UpjjN4xGlGk1dMba91ioORZrjBp3lLR+jJGY5eMp1NKGye5mV5aGw/iBiYYk0pdb55iazfw0kb0REX/rz8BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * An array of items that are being purchased.
    */
    [DataContract]
    public class ItemList {

        // Required default constructor
        public ItemList() {}

        /**
        * An array of items that are being purchased.
        */
        [DataMember(Name="items")]
        public List<Item> Items { get; set; }

        /**
        * The extended address, which is used as the shipping address in a payment.
        */
        [DataMember(Name="shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }

        /**
        * The shipping method used for this payment, such as USPS Parcel.
        */
        [DataMember(Name="shipping_method")]
        public string ShippingMethod { get; set; }

        /**
        * The shipping phone number, in its canonical international format as defined by the [E.164](https://en.wikipedia.org/wiki/E.164) numbering plan. Enables merchants to share payer’s contact number with PayPal for the current payment. The final contact number for the payer who is associated with the transaction might be the same as or different from the `shipping_phone_number` based on the payer’s action on PayPal.
        */
        [DataMember(Name="shipping_phone_number")]
        public string ShippingPhoneNumber { get; set; }
    }
}

