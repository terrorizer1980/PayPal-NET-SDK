// This class was generated on Mon, 11 Dec 2017 13:16:22 CST by version 0.1 of Braintree SDK Generator
// PayerInformation.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xZ3W4bNxO9/55ioFx8MSBpJTlJEd8lzk/dILHhn/bCNeTRcqSdhktuyNnIShGgr9HX65MU5K4l2ZIdKzGUAtFNEJFzuGdmh2d2xn82jicFNXYaBU7I9dkMrctR2JpGs/ErOsaBpneYB5NGs/GCfOq4iPs7jeOMIOJgDtduNBvPnMNJdXCn2TgkVPtGTxo7Q9SewsKHkh2p6cKBswU5YfKNndMpJVTKkfeLRAasNZtRf2awyKu2gdoG2AAGsjkZacMuGhgQ0IWQUaRgaB34jItiDnJ/jnhxbEaLfqQsk6XkwwYYzOlbOZhS68/NLxOxpRE36adW0VJCpzK2rTRDh6mQg72jfdjuPnnS6kKAnD1MlE19wkZo5GIWJIodpZI48pLUx7eCrU+2QDIUYEVGeMjkQYLLlQ1YB45GIY9+Lzud7XSgbfr+Q2mF4u/q39SLs2ZUrbyzQjvVcjK/Dsdzx4ZHx7f82hEKPHcsyAbYQ4UM+xXs9fP6rNkSoFFgrCzYnrxZYuuh9KRCwgW/xBYtTR9Jg7J5eGR4rT5SiWGoCbbhxFMEnO/2zhdp72ZsEMbWaTXmei21eYEuvEYoTWqNOKs1KSgcpwQPd08OtiAnyaxqwgDNe0jRqWZ0JnXW+9bAOkUOxKHxmIbX5uuoJ9fDvkoeiiu/Lg01G+ouzb8hOy8Q9sEOY5guLym8sg7oAvNCUxNMmQ/INcGLI5LKV29hRVX6Jgd6Cw7sx/+gbseM9JRao+7giy9ZqAlYoJOgWlPnvs6pr1cHE6Rd86d4sfteUMrlmnuptVcAUAHacEhSOkMKrNGTmMCxdngYOpvDc4efWK/JoyKzZrnQxZ1ppNnA6ct2t7cNVXk7e5iJFH4nScbjcZulbLMJGpcmx63Dl7utaNvqdTrdTq+1l5DZasNbvOC8zEGTGUkWFOdxB6ZS6tflsfWC+maBr/aj3jRhnHEamYbk/MRFJUMhNz+U/BF1LKHHk4JT1HoCruZXi1JQrqDqY5Ys1NzZyeEINFdOOSKC04OZySzCZNpjfs8FKca2daMk/EoOZn5srSl0IX9vqIp3KX4RPi19IUQIJ0fxVsSAhBjPIhINrGQ0F8lwdeYiPC/XwFcUJLwzNmCn0uJpdswOnD5zo1B0Da5C+gFeoraacFrd05XwgwgJ4F00qFZ7eBohAbxnFK+G5YCIUEE9WQ0aEAH6CxZoVoL+ERAB+pYuOLUrYfMICeDjDFmjUSvBpQZtNUNmnZ4YFlJwFEz8SgeVHpdK16MOeDYjTa3BRGj9MnaH4lOXm/XwkbC9jE3YCHdweWk//3n/7cv+/mH/t/3DN+dNOH+99+r4/L4r+9kdHBiwk6yvblK4uA0qSlWlNLFmV5Vxzwg5Q1LtX6+QYq32bSYZRvXOJNeJG6bb29tPH3iK8tV63H6ydT003adPO63Oo1a3d/5f6X6iz//3i11QpzXtgmbf6yt2Q2tyknJkfat30WKWsIuXv9v7af03Pn7590PTdCv5qkFYY8us8S60gtU6WeWslKYv86rs1smsni+ppbQOcHKAuoXe8yh0CGRSNylC7arGS3svvn9jUEduvkFYdkl63+PjPnDq31iLKsphe11VGnUpl0PEm0M5M7tvXvUkr3/jBHGJxSLP6XSwNpprjOKEB6sG6frc8OqocTNE3AwRN0PEzRBxM0TcDBE3Q8QfdojoKOWCydzSM4SNy8s8NQcUkIz9ff1RcjPz3Mw8NzPPzczzR555+nI45IvbW9Nosq6A4sVNg5HI55+//vYgeAF7L9pwVBaFdXKpi9PhyWXDWX+sx++jtfK/Zf5wzYlqFLF+T84+/+9fAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The payer information.
    */
    [DataContract]
    public class PayerInformation {

        // Required default constructor
        public PayerInformation() {}

        /**
        * The billing address in a payment. Can be extended for shipping address.
        */
        [DataMember(Name="billing_address")]
        public Address BillingAddress { get; set; }

        /**
        * The birth date of the payer, in [Internet date format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `1990-04-12`.
        */
        [DataMember(Name="birth_date")]
        public string BirthDate { get; set; }

        /**
        * The payer's [two-character IS0-3166-1 country code](/docs/integration/direct/rest/country-codes/).
        */
        [DataMember(Name="country_code")]
        public string CountryCode { get; set; }

        /**
        * The payer's email address. Maximum length is 127 characters.
        */
        [DataMember(Name="email")]
        public string Email { get; set; }

        /**
        * The payer's first name.
        */
        [DataMember(Name="first_name")]
        public string FirstName { get; set; }

        /**
        * The payer's last name.
        */
        [DataMember(Name="last_name")]
        public string LastName { get; set; }

        /**
        * The payer's middle name.
        */
        [DataMember(Name="middle_name")]
        public string MiddleName { get; set; }

        /**
        * The PayPal-assigned encrypted payer ID.
        */
        [DataMember(Name="payer_id")]
        public string PayerId { get; set; }

        /**
        * The payer's phone number. Maximum length is 20 characters.
        */
        [DataMember(Name="phone")]
        public string Phone { get; set; }

        /**
        * The phone type.
        */
        [DataMember(Name="phone_type")]
        public string PhoneType { get; set; }

        /**
        * The payer's salutation.
        */
        [DataMember(Name="salutation")]
        public string Salutation { get; set; }

        /**
        * The extended address, which is used as the shipping address in a payment.
        */
        [DataMember(Name="shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }

        /**
        * The payer's suffix.
        */
        [DataMember(Name="suffix")]
        public string Suffix { get; set; }

        /**
        * The payer’s tax ID. Supported for the PayPal payment method only.
        */
        [DataMember(Name="tax_id")]
        public string TaxId { get; set; }

        /**
        * The payer’s tax ID type. Supported for the PayPal payment method only.
        */
        [DataMember(Name="tax_id_type")]
        public string TaxIdType { get; set; }
    }
}

