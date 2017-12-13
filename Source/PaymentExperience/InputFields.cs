// This class was generated on Wed, 13 Dec 2017 12:10:42 CST by version 0.1 of Braintree SDK Generator
// InputFields.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8SUz29TMQzH7/wVVi5cqq7ArTekaWgXmKZpF0CTm7h9FmkSbIfxQPvf0WvaDvpD6rRJHKq+OP71dT7Jb3fTF3JTd5lKNbhgikHdyN2iMM4ifcTlsOtG7pzUCxfjnNzU3XQEvAqZDyHgq1pe8i8c9qGg4JKMRMdu5N6LYN/KTEbumjB8SrF30zlGpcHwvbJQ2BquJBcSY1I3/bxtkJPRgmS/NwxBSPUu/yARDrTX62UK7NFI4b4j60jAMgTWErEH6wi041I4LWCdCqxDA1YoqEphcLeOFTzGCIItRYdpFZzT8IM5R4J5luY5qz3JYB48rrC/wgj0s5AwJU9QcEE6hluMlYB1+qVOJu98jat/aqvIf698Du2LJs1w9mgZw3kTo4fVrLsbrwP/TXyszJsnl9FCnudMATg9zmu8cm54kIDHlLIBBbbms5vmcJdnm9k8E6dUY3wYbZma5RwJ0wGmYsz3dynbSTTtCARKRgIIQ3yDh2BJ4jtMtgPFQAKEKsMEfEf+W642flmRRy9Oyneb6Z+gct1w2DCwd/6rh0A3+v4n7Tvz1eeTf00BvR0XPZe83C8LF1kg8IINIyxyDjpq0Lc3kxVkfY6AKcCyqsGM4ISGniTo7QFBH8iOzG8rZYP0awX0PtdkUCQff0le9I5+fXj1BwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PaymentExperience
{
    /**
    * The input field customization parameters.
    */
    [DataContract]
    public class InputFields {

        // Required default constructor
        public InputFields() {}

        /**
        * Indicates whether to display the shipping address that is passed to this call rather than the one on file for this buyer on the PayPal experience pages. Value is:<ul><li><code>0</code>. Displays the shipping address on file.</li><li><code>1</code>. Displays the shipping address specified in this call. the customer cannot edit this shipping address.</li></ul>
        */
        [DataMember(Name="address_override", EmitDefaultValue = false)]
        public int AddressOverride { get; set; }

        /**
        * Indicates whether the customer can enter a note to the merchant on the PayPal page during checkout.
        */
        [DataMember(Name="allow_note", EmitDefaultValue = false)]
        public bool AllowNote { get; set; }

        /**
        * Indicates whether PayPal displays shipping address fields on the experience pages. Value is:<ul><li><code>0</code>. Displays the shipping address on the PayPal pages.</li><li><code>1</code>. Redacts shipping address fields from the PayPal pages. For digital goods, this field is required and must be <code>1</code>.</li><li><code>2</code>. Gets the shipping address from the customer's account profile.</li></ul>
        */
        [DataMember(Name="no_shipping", EmitDefaultValue = false)]
        public int NoShipping { get; set; }
    }
}

