// This class was generated on Wed, 13 Dec 2017 14:32:58 CST by version 0.1 of Braintree SDK Generator
// PaymentCard.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xYTXMbsQ2991dglEPjGX34o3UnvjlOm7ptYk1s96JmbGgJaRlzyQ2Ilax0+t87IGVJsaWJlTi6eKwlHvYBBB+B/W/ralZT66TVx1lFXuAM2bTarX8jWxw6+oiVrrbarXcUC7a12OBbJ61TqOeAAtmAlKj/eRgSNJEMSIBR4w3gg1231W6dMuMsv2+/3fpEaC68m7VORugi6YOvjWUyiwd9DjWxWIqtk8GC6aWtakfQD1HQwakxTDE+pTy0zlk/vsGFweMIYnZUZ0dzO5haKaEIyJE6Y0brycDIkjOxC+8C+CAaIYwCA3qwXog9qs+ljy5czy2GWNxNNUFFqGoUO7TOygyCdzP1RjH5K4IXtB7qMnh6uURFYevHTzNTWJk9ScdVSaAL4LHajoNw84iCb5z7X/vHPELjhWc3RTC0ls9ApqFTlMhYCDGcX17A0cHxcecAFPL5dc+EIvZ0C8actqBnLFMhPaYovbn7jtrG3l6uUWvIix1ZiiAacbaBwMA0tsF3/9Ps7x8VQxeKu69NEEq/898iCgc/zk8+BqGT/Li3+hyuVtzqq1MdvGdCgbds0z7bCBmp6xn2/u3c1/IRoDepPB7bXv9zjW3M5876FJeEuuNoQg5MqPSVuqsxUclHNRPMhaqA27PD26e0z0rrEaaBnZna+bNUyazbCI3XyuXgHBmo2RYEr8+u+3tQkZTBtGGI/i4JRDsFU3CIsTMMbIhBGH3EQrctzrPee5z2nZShs54O1tbfyHIU0HUIo5SmxQH/W2Cge1QBaYNvqiFxG6IwkeRYY4DguzsL4PBJABd1FqVuqshIRfDmGbHExgq1AWtkSfr+ENzPBbVGoJ4ZVZblzeIwl21db8O0tEWp50oD+2brXMIa19fGTtDpBQRXs9oW6NwMeM5vXtBa9aoISfpx1TNklV/1ckkEg/7S5PPrUqSOJ70e+e7U3tmajMVu4HFPf/X6yzj2dpS6KCgbFPU5wpngC9lMFx1cX0J6DElBaCUjySBISSuZ7MKn1QyvHnWw31Wf7pn1EBZlGWnp5gQGpzxWwfa4DelX+IDaa8PgLeM367bCDxNEwWfo0Wz38iJBFHzujd0OaxWRoIJuth1UEQr9B9bot4J+UYRCP9C9LcJW2CpBFHxVonXozVZwmYP22lpZg2tvhQxcqkncylETca8LH/DeVk0FjvxYkiD8aR+i9WNHneFMCBbdRHyRs/h55TQmmsRr+pzJ5HB9v6Wd4QSdNSm4JCdduGzqOrCmQdtEmJbkocI768fLbhqGjaTeIK1GnHy/mhzryRs10nBqyV9YejYGS/e1ZbqpgpdybdDa0xk7tnOWyX4Gyf5lr8sfUZwR8vprPzS8hqLa7+ZCp/s0VLibookSKuIba9YzxUIHCpTAnZrDxBoycP7u4YZP7MvgDPGKIueSkcC5ZnRM0/+sj8JNKp/A0MS8qnaq4k+N5p1mH2d9dDDBxsmOrrfUlt1oR7v5VOWo/xjnPdzWQ83Ps9uwVctdSanShnnlsO6Im8PnJ05tf0fe/mX9Hay8HC6GX6iQtW3t3Zqx3QMqGc2mtnEUpcPkUDM6+Pvp1V8vTi8hQR+uD6xtL0yIJ5amvVclCgWMnWTyuCE7/k15zz305qTn9R3JXxRkeb5AJ/Of0OdfuEMyw2frc2a4tTz/Wn/dxLXc8tLDUX8qmztiKLq8sdx0dTc3WWpubhov1q2lY3Sk0MlSbEX5ZlpcXEMqQkURGt/E9LlhxKFaKmhbb6DBefr+RvLI0yhwhbIczSQEF7uWZJQGs1Iq1+NRcXR09OZVpDSZdP7cPd7Lw/LtCu1bqJGxIiHWdlJ7LqUQsUofXdIspP1B7uDSMUk0UjkmbxuXobLjUmBIoPKVvszk8L9/v0b2aEhf5Ci3MmmE+hgmpCoCh/sHb1J/uN6VRnFRSFDTg79I2U6AF+qG//B/AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A payment card that can be used to fund a payment.
    /// </summary>
    [DataContract]
    public class PaymentCard {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentCard() {}

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public SimplePostalAddress BillingAddress { get; set; }

        /// <summary>
        /// The card validation code. Supported only when making a payment but not when saving a payment card for future use.
        /// </summary>
        [DataMember(Name="cvv2", EmitDefaultValue = false)]
        public int? Cvv2 { get; set; }

        /// <summary>
        /// REQUIRED
        /// The two-digit card expiry month.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth { get; set; }

        /// <summary>
        /// REQUIRED
        /// The four-digit card expiry year.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear { get; set; }

        /// <summary>
        /// The facilitator-provided ID of the card holder. Required when storing a funding instrument or using a stored funding instrument in the PayPal vault.
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue = false)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// The card holder's first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The ID of the vaulted payment card.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The card holder's last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// REQUIRED
        /// The card number.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The two-digit card start month.
        /// </summary>
        [DataMember(Name="start_month", EmitDefaultValue = false)]
        public int? StartMonth { get; set; }

        /// <summary>
        /// The four-digit card start year.
        /// </summary>
        [DataMember(Name="start_year", EmitDefaultValue = false)]
        public int? StartYear { get; set; }

        /// <summary>
        /// The status of the funding instrument.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// REQUIRED
        /// The card type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The date and time when the card becomes unusable from the vault, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The `valid_until` parameter is not the same as the expiration month and year. The expiration month and year might be later than the `valid_until` date. For example, the card expires in November 2019 but the `valid_until` date is October 17th, 2019.
        /// </summary>
        [DataMember(Name="valid_until", EmitDefaultValue = false)]
        public string ValidUntil { get; set; }
    }
}

