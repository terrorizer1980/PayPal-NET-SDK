// This class was generated on Mon, 11 Dec 2017 16:45:15 CST by version 0.1 of Braintree SDK Generator
// Participant.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yWz3LjRBDG7zxFl7jEhUoh4c8ht+CFE5V1kYUDFOVqaVpWw2hmdrq1GxXFu1Mjy443crJe8Jo95Gj1NzO/7pmv239lr/pA2VW2wKhccUCnWZ79gpGxtHSDbQpmefaCpIoclL17Vw3sah9bTJEiy7PrGLFfb/plnv1EaF4622dXNVqh9OF1x5HM9sMi+kBRmSS7+m2LIxrZraYkaAynk9Au07kTsOttfJcrB+mqBlCg7IQdiUDjuyj/ldd11v6db6GvjYkkspd6DLxL+x0KwbgKfPkHVQqdkBlI2Vp2KxjXAjtACNi35BR8BLpTcoYM1D7CbcMhJPW42ce/iIq1n+QzZ+3BYUsfdL7G7um6PsrgO6exX1be0ITlEiypUoRRBUl1Gi7Lji4mQD+yI7gAX4M297d+RqsCXNeWFHMQjUSaA2k1Ox3q5QT1ZRg9lMJwuZdZOlbKAYPC5wNxMTuynR5jDo130/tepK9jJZNZvi8uLr+CdQs4FZgXRbv/Of7KYXiBg3Vfd/wGbTIyC3TSobU9xJFgMPT60TIJaIMKDb6hdAVtAT/4CJZF06U8UBkPzo/iNctwpECwlDpNpJoiqIdGNVydn5Mr3vKfHMgwFj6uztOv88V9FieqmyjqkwY2NBTl51sYpJIDOjM8yZ1SJoXXhnaKdxT+3w/IYDNWlqn5TTJ51RCEnYlZ+Tag6++H0Qe3zH9fa2qR7XsJB9Vm9By3Ey1G9z7gqvFuP9WOrU8w1Z6aKAlnO0xwPZ2Ht3k2n8/yNLMN1ezIQNmn9vPt1wWkNS3ecdu16drLIWzJrbRJBp7Pv3C4+b8icPENGF6xyokew+bs5bq+ezPe8m2G1N48rx/qoPJOWFRSmtuYIVFe/xpLd/NiPhvcLF2Zjk5Lxx3Obm9m/28FD7F+zVH0MN8P0lOa3eKhaEn5Mcgecfv+Ef7s92e/f/J+f0ulsL7fUaPuSFyf/QMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Participant information.
    */
    [DataContract]
    public class Participant {

        // Required default constructor
        public Participant() {}

        /**
        * Additional information, such as business hours.
        */
        [DataMember(Name="additional_info")]
        public string AdditionalInfo { get; set; }

        /**
        * Base Address object used as billing address in a payment or extended for Shipping Address.
        */
        [DataMember(Name="address")]
        public Address Address { get; set; }

        /**
        * The participant company business name.
        */
        [DataMember(Name="business_name")]
        public string BusinessName { get; set; }

        /**
        * REQUIRED
        * The participant email address.
        */
        [DataMember(Name="email")]
        public string Email { get; set; }

        /**
        * The phone number.
        */
        [DataMember(Name="fax")]
        public Phone Fax { get; set; }

        /**
        * The participant first name.
        */
        [DataMember(Name="first_name")]
        public string FirstName { get; set; }

        /**
        * The participant last name.
        */
        [DataMember(Name="last_name")]
        public string LastName { get; set; }

        /**
        * The phone number.
        */
        [DataMember(Name="phone")]
        public Phone Phone { get; set; }

        /**
        * The participant website.
        */
        [DataMember(Name="website")]
        public string Website { get; set; }
    }
}

