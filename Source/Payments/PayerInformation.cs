// This class was generated on Wed, 13 Dec 2017 14:31:40 CST by version 0.1 of Braintree SDK Generator
// PayerInformation.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xZ3W4bNxO9/55ioFx8MSBpJTlJEd8lzk/dILHhn/bCNeTRcqSdhktuyNnIShGgr9HX65MU5K4l2ZIdKzGUAtFNEJFzuGdmh2d2xn82jicFNXYaBU7I9dkMrctR2JpGs/ErOsaBpneYB5NGs/GCfOq4iPs7jeOMIOJgDtduNBvPnMNJdXCn2TgkVPtGTxo7Q9SewsKHkh2p6cKBswU5YfKNndMpJVTKkfeLRAasNZtRf2awyKu2gdoG2AAGsjkZacMuGhgQ0IWQUaRgaB34jItiDnJ/jnhxbEaLfqQsk6XkwwYYzOlbOZhS68/NLxOxpRE36adW0VJCpzK2rTRDh6mQg72jfdjuPnnS6kKAnD1MlE19wkZo5GIWJIodpZI48pLUx7eCrU+2QDIUYEVGeMjkQYLLlQ1YB45GIY9+Lzud7XSgbfr+Q2mF4u/q39SLs2ZUrbyzQjvVcjK/Dsdzx4ZHx7f82hEKPHcsyAbYQ4UM+xXs9fP6rNkSoFFgrCzYnrxZYuuh9KRCwgW/xBYtTR9Jg7J5eGR4rT5SiWGoCbbhxFMEnO/2zhdp72ZsEMbWaTXmei21eYEuvEYoTWqNOKs1KSgcpwQPd08OtiAnyaxqwgDNe0jRqWZ0JnXW+9bAOkUOxKHxmIbX5uuoJ9fDvkoeiiu/Lg01G+ouzb8hOy8Q9sEOY5guLym8sg7oAvNCUxNMmQ/INcGLI5LKV29hRVX6Jgd6Cw7sx/+gbseM9JRao+7giy9ZqAlYoJOgWlPnvs6pr1cHE6Rd86d4sfteUMrlmnuptVcAUAHacEhSOkMKrNGTmMCxdngYOpvDc4efWK/JoyKzZrnQxZ1ppNnA6ct2t7cNVXk7e5iJFH4nScbjcZulbLMJGpcmx63Dl7utaNvqdTrdTq+1l5DZasNbvOC8zEGTGUkWFOdxB6ZS6tflsfWC+maBr/aj3jRhnHEamYbk/MRFJUMhNz+U/BF1LKHHk4JT1HoCruZXi1JQrqDqY5Ys1NzZyeEINFdOOSKC04OZySzCZNpjfs8FKca2daMk/EoOZn5srSl0IX9vqIp3KX4RPi19IUQIJ0fxVsSAhBjPIhINrGQ0F8lwdeYiPC/XwFcUJLwzNmCn0uJpdswOnD5zo1B0Da5C+gFeoraacFrd05XwgwgJ4F00qFZ7eBohAbxnFK+G5YCIUEE9WQ0aEAH6CxZoVoL+ERAB+pYuOLUrYfMICeDjDFmjUSvBpQZtNUNmnZ4YFlJwFEz8SgeVHpdK16MOeDYjTa3BRGj9MnaH4lOXm/XwkbC9jE3YCHdweWk//3n/7cv+/mH/t/3DN+dNOH+99+r4/L4r+9kdHBiwk6yvblK4uA0qSlWlNLFmV5Vxzwg5Q1LtX6+QYq32bSYZRvXOJNeJG6bb29tPH3iK8tV63H6ydT003adPO63Oo1a3d/5f6X6iz//3i11QpzXtgmbf6yt2Q2tyknJkfat30WKWsIuXv9v7af03Pn7590PTdCv5qkFYY8us8S60gtU6WeWslKYv86rs1smsni+ppbQOcHKAuoXe8yh0CGRSNylC7arGS3svvn9jUEduvkFYdkl63+PjPnDq31iLKsphe11VGnUpl0PEm0M5M7tvXvUkr3/jBHGJxSLP6XSwNpprjOKEB6sG6frc8OqocTNE3AwRN0PEzRBxM0TcDBE3Q8QfdojoKOWCydzSM4SNy8s8NQcUkIz9ff1RcjPz3Mw8NzPPzczzR555+nI45IvbW9Nosq6A4sVNg5HI55+//vYgeAF7L9pwVBaFdXKpi9PhyWXDWX+sx++jtfK/Zf5wzYlqFLF+T84+/+9fAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The payer information.
    /// </summary>
    [DataContract]
    public class PayerInformation {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public PayerInformation() {}

        /// <summary>
        /// The billing address in a payment. Can be extended for shipping address.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The birth date of the payer, in [Internet date format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `1990-04-12`.
        /// </summary>
        [DataMember(Name="birth_date", EmitDefaultValue = false)]
        public string BirthDate { get; set; }

        /// <summary>
        /// The payer's [two-character IS0-3166-1 country code](/docs/integration/direct/rest/country-codes/).
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The payer's email address. Maximum length is 127 characters.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The payer's first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The payer's last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The payer's middle name.
        /// </summary>
        [DataMember(Name="middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The PayPal-assigned encrypted payer ID.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId { get; set; }

        /// <summary>
        /// The payer's phone number. Maximum length is 20 characters.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// The phone type.
        /// </summary>
        [DataMember(Name="phone_type", EmitDefaultValue = false)]
        public string PhoneType { get; set; }

        /// <summary>
        /// The payer's salutation.
        /// </summary>
        [DataMember(Name="salutation", EmitDefaultValue = false)]
        public string Salutation { get; set; }

        /// <summary>
        /// The extended address, which is used as the shipping address in a payment.
        /// </summary>
        [DataMember(Name="shipping_address", EmitDefaultValue = false)]
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// The payer's suffix.
        /// </summary>
        [DataMember(Name="suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; }

        /// <summary>
        /// The payer’s tax ID. Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// The payer’s tax ID type. Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="tax_id_type", EmitDefaultValue = false)]
        public string TaxIdType { get; set; }
    }
}

