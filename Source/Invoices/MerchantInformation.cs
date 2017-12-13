// This class was generated on Wed, 13 Dec 2017 12:24:19 CST by version 0.1 of Braintree SDK Generator
// MerchantInformation.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yWz27kRBDG7zxFyVwywpqQ8OeQW5iAtBJkI7JwAKHZsrs8Lmh3e7vK2bEQ7466xzMZ4iEky6zhsEe7q92/+rq+Kv+evepbyi6y7yiUNTqFF67yoUFl77I8+xEDY2HpGpsYleXZFUkZuE3re9uKTtiRCPD9ftAaFbBtCYNAeiZgd+e5pHmWZ5chYL85/9M8+57QvHS2zy4qtELxxZuOA5ndi5vgWwrKJNnFzzty0cBuNWZFYzhSoF1GphH65W59nzkH6coaUO4zqn0X5N/yus7aP/LnQi8tFmTH6JDeQ+VD0vT1g22voWKy5sjMl8YEEjkIPSz8FfMrFIJhF/jiVyoVOiGT1GVr2a1g2AvsAKHFviGn4APQWskZMinH25rbNkYPH3v/xVOy9qN8Fqw9OGyeV7waunerhdJ3TkO/LL2hEcs5WFKlAEMUxKhpuCw7OhsBfcuO4Ax8lSpye+sntJqD65qCQg6igUhzIC1n06Gej1BftoPv4zKcH2SWjpVywFbh40Q8n03UAtrau/F938S3g5LRLF/Pz84/g03bmgrMi6I9XI4/cZsqMFn3Tcd3aKORWaCTDq3tIQwEydCbomWSzYio8Y7iFTRz+MYHsCwaL+VBlPHg/BC8YUlHCrSWYqcJVFEA9VCrthenp+Tmb/k3bskwzn1Yncan05v7LCbSTRT1UQMbSqL8cAspVHJAZ1JJ7kkZI7zWtCfeUfh/eUIG21G4jM1vlMmrmqDZ/geUvmnR9ffT89n98t2FpgbZPo6XQrZD57g96Gbw7QOoCtcHkdo9Q08wzx6bJRFnN0ZwM5dTVZ4sFrM8TmtDFTsyUPSx8Xz5+RySqrjmpmvinRdp2ZJbaR2tu1h84nD7dyVw9gUYXrFO9Ru1PXu50fdgxju+7Xg6mOflwzgovRMWlZjmbs2QKG+eBumurxaz5GPpinh03Dp84eT2evbfKvgU01ccRJ/g+BQ3pc0tPokrhr0PrL/x+eGx/cHpH5z+v3e64nrJ5nE3Ka7hxdVEl/qWCmH9B38PQUdS6aM/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Merchant business information that appears on the invoice.
    */
    [DataContract]
    public class MerchantInformation {

        // Required default constructor
        public MerchantInformation() {}

        /**
        * Additional information, such as business hours.
        */
        [DataMember(Name="additional_info", EmitDefaultValue = false)]
        public string AdditionalInfo { get; set; }

        /**
        * A label for the `additional_info` field.
        */
        [DataMember(Name="additional_info_label", EmitDefaultValue = false)]
        public string AdditionalInfoLabel { get; set; }

        /**
        * Base Address object used as billing address in a payment or extended for Shipping Address.
        */
        [DataMember(Name="address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /**
        * The merchant company business name.
        */
        [DataMember(Name="business_name", EmitDefaultValue = false)]
        public string BusinessName { get; set; }

        /**
        * REQUIRED
        * The merchant email address.
        */
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /**
        * The phone number.
        */
        [DataMember(Name="fax", EmitDefaultValue = false)]
        public Phone Fax { get; set; }

        /**
        * The merchant first name.
        */
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /**
        * The merchant last name.
        */
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /**
        * The phone number.
        */
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public Phone Phone { get; set; }

        /**
        * The merchant tax ID.
        */
        [DataMember(Name="tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /**
        * The merchant website.
        */
        [DataMember(Name="website", EmitDefaultValue = false)]
        public string Website { get; set; }
    }
}

