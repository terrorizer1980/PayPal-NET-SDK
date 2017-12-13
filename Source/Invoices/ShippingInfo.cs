// This class was generated on Wed, 13 Dec 2017 12:24:21 CST by version 0.1 of Braintree SDK Generator
// ShippingInfo.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yV32/TQAzH3/krrOOFSVHKylvfxi8JCbGJDR5A0+QmTmO43N3OziBC+9/RXbMylglWqPrWnu3446/tux/mbAhkFua05RDYreCNa7wpzEeMjEtL77BLZlOYlyRV5KDsnVmYs5ZAbmLYNT52mEzQ+AjaErC78lwRRKo4MDktTWGOYsRhnfFpYd4T1sfODmbRoBVKB5c9R6o3ByfRB4rKJGbxecN6VNeRRKaUuDH8DvschWCMAr/8QpVCL1QDCizZ2lTDGAvsACHg0JFT8BHou5Krqc6FbVQaP7a7mkQju9W0pIp1mNTzgnUAhx1tlV9jfye96629Lv7O4HuncbiofE0TljlYUqUIoxckr/1wWXZ0OAF6y47gEHyTx/Cm609oVYLruyXFAkQjkRZAWh3sD3U+QT3OP9BCMsP8XmbpWakADAqPM3F58L9T90Dm0Ho37fdJOh2VTMvyqjycP4P1/u8LzIuivX8cP3HIE5hX97LnK7RpkVmglx6tHSCOBHmh10PLJKAtKrR4RakFXQmvfQTLoqkpd7xqD86PzmuWnFIgWEo3TaSGIqiHVjUsZjNy5Tf+yoFqxtLH1Sz9m538qmJPuomi/nGBa8qifDiF7CoFoKvzSN6SMnl4bemWeDvhP39ABcte2JHIRbr87n2TJs8OVL4L6Aa4id3+4vx3xRuOotvA5oB9ElrcDjD5747v/PrRTwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The shipping information for the invoice recipient.
    */
    [DataContract]
    public class ShippingInfo {

        // Required default constructor
        public ShippingInfo() {}

        /**
        * Base Address object used as billing address in a payment or extended for Shipping Address.
        */
        [DataMember(Name="address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /**
        * The invoice recipient company business name.
        */
        [DataMember(Name="business_name", EmitDefaultValue = false)]
        public string BusinessName { get; set; }

        /**
        * The invoice recipient first name.
        */
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /**
        * The invoice recipient last name.
        */
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }
    }
}

