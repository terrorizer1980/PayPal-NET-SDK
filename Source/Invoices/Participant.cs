// This class was generated on Wed, 13 Dec 2017 14:32:19 CST by version 0.1 of Braintree SDK Generator
// Participant.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yWz3LjRBDG7zxFl7jEhUoh4c8ht+CFE5V1kYUDFOVqaVpWw2hmdrq1GxXFu1Mjy443crJe8Jo95Gj1NzO/7pmv239lr/pA2VW2wKhccUCnWZ79gpGxtHSDbQpmefaCpIoclL17Vw3sah9bTJEiy7PrGLFfb/plnv1EaF4622dXNVqh9OF1x5HM9sMi+kBRmSS7+m2LIxrZraYkaAynk9Au07kTsOttfJcrB+mqBlCg7IQdiUDjuyj/ldd11v6db6GvjYkkspd6DLxL+x0KwbgKfPkHVQqdkBlI2Vp2KxjXAjtACNi35BR8BLpTcoYM1D7CbcMhJPW42ce/iIq1n+QzZ+3BYUsfdL7G7um6PsrgO6exX1be0ITlEiypUoRRBUl1Gi7Lji4mQD+yI7gAX4M297d+RqsCXNeWFHMQjUSaA2k1Ox3q5QT1ZRg9lMJwuZdZOlbKAYPC5wNxMTuynR5jDo130/tepK9jJZNZvi8uLr+CdQs4FZgXRbv/Of7KYXiBg3Vfd/wGbTIyC3TSobU9xJFgMPT60TIJaIMKDb6hdAVtAT/4CJZF06U8UBkPzo/iNctwpECwlDpNpJoiqIdGNVydn5Mr3vKfHMgwFj6uztOv88V9FieqmyjqkwY2NBTl51sYpJIDOjM8yZ1SJoXXhnaKdxT+3w/IYDNWlqn5TTJ51RCEnYlZ+Tag6++H0Qe3zH9fa2qR7XsJB9Vm9By3Ey1G9z7gqvFuP9WOrU8w1Z6aKAlnO0xwPZ2Ht3k2n8/yNLMN1ezIQNmn9vPt1wWkNS3ecdu16drLIWzJrbRJBp7Pv3C4+b8icPENGF6xyokew+bs5bq+ezPe8m2G1N48rx/qoPJOWFRSmtuYIVFe/xpLd/NiPhvcLF2Zjk5Lxx3Obm9m/28FD7F+zVH0MN8P0lOa3eKhaEn5Mcgecfv+Ef7s92e/f/J+f0ulsL7fUaPuSFyf/QMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Participant information.
    /// </summary>
    [DataContract]
    public class Participant {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Participant() {}

        /// <summary>
        /// Additional information, such as business hours.
        /// </summary>
        [DataMember(Name="additional_info", EmitDefaultValue = false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Base Address object used as billing address in a payment or extended for Shipping Address.
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// The participant company business name.
        /// </summary>
        [DataMember(Name="business_name", EmitDefaultValue = false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// REQUIRED
        /// The participant email address.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue = false)]
        public Phone Fax { get; set; }

        /// <summary>
        /// The participant first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The participant last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public Phone Phone { get; set; }

        /// <summary>
        /// The participant website.
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue = false)]
        public string Website { get; set; }
    }
}

