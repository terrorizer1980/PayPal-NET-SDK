// This class was generated on Wed, 13 Dec 2017 14:32:59 CST by version 0.1 of Braintree SDK Generator
// Plan.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8xYX2/bOBJ/v08xcB+uBWwrd7nr4fIWNDmcF2kSNG6BIhs4DDmKuKVIlRzaERb97ouhJMeO5W3TJt4+2aJGw9/8+82Qvw+mdYWDg8G5EXYwHHwQXosbg6ei5NXBcHCEQXpdkXZ2cDCYFgiVERbIQQzIP9KjIARhQdx6xBItjQfDwaH3om6U7w0H71CoM2vqwUEuTEBe+By1R7VcOPeuQk8aw+DgcgkrkNf2dhNYs+mMdIm9GFUDSQFLwKJAC9RBX4jQglZD0BYuJ5bQW6QHX+XOl4KuXhZEVTjIMnLOhLFGysfO32YFlSbzudzf3//vi4CSdx/9e/z61Y9ab6MxX4ZfdYFaMXprmFaEHgWLfPw+VFr1gpkcgcuXIXhiD51o+wlW9oSzm99Q0iY4o+2nsIHv0IJgMIzQ4+eIgUYeDecHXP7/cHp8dngB6dOrl5lyMmSi0pmbo59rXGQvCkHoRBglkYfRf/2Dtr1FLwthCSqPOXq0EsOmYWUrNVuX2oxD2aOOEx1EExiYWGmiwgCFW0AZZQGaQLpAgWs9IEGsUhyXxT5Mj+/fnQSuM4/pUcZArkQPknmhqrybI7j0KNH0KSjFnS5jCTaWN+g5FsIYt0AFudAGFVSiZmkQRFhWFIa8HRXo4VzU58KAiORKQVoKY2q40caEpNlFCiSs0vYWboRhBFz2/MriHSVJfidraXDY1D/jSxUNOl8z6O8BtNWkhVkCYnzh+SlPSIkVoZq1+86I5XsrvwXGAuwCQSA8G9QoSPGmQocVwgZGO3LW1Ml+jwH9vBXNI0WPTPc7YjYO5IyjMhOli5Y2jJxYpaUgDM+SAmOYbvuk0UaOeK+ELSWqrbme5trFYOouX4MsUMWVzA1j+CBMZDUHv8a9vX0ZTfrF5sno1SfpVPMPT8+alex+adwZrBwGsI56LF+vwy1eGMMR5iIaYtu+ZeN2ZR3rNuQfjy+2Q98Wq69C7oXQuXI3GdrQ2Cx601uA79+dMFsuCi2LdZt0AI9Ke5RciA231L2suJt2LQvhZwGp1wx+KSShT7z/s7PGVyePvt63K2xNy5gxNbSkNmv6Sy/mR7ae76OVN2en08np++OeCp2uJiJ4LIW2IaGa47I/PmzLDR1yfiiFivN/K+dM8lT9o452dQC07C41fGImX2G3687g68eR2JvD0zfHJxte6oA2J4mwXrxwE4mLJoCmAIH4XEEOKmyAR0u6KfeHAZUGhQ/JQ9tfNwNTp2xlU5SuxC5QW5WkpNmmQ4eWjVD1uynbLdOW4q6tmnbs6x9rHzs8rmfG3vWwJev0GddZzl7DrZ/vxniPFL19sjbTDIDP2WbeOot1mjthoakAGT3zbA1cN/A5CqNzjQrmTFib9gakWM1y3BxrDxul6aRiDOTaCis5qZOm5XEt12hUGMP/nAe8E2XFA31LE8NlFFVsx/zgwNkdXFa0XugN4iUVHnF032snF2ejf/3zH/9Zd979NYTCORreflyJuhJmLF3ZHEu1Jbz1gpVnTfAzj4GyTtGIFYXs1W5Giy7GPXNFZ1gSGcNbfVswe4GwkGxAnyLdymkMYPQnhOtfzj9e359neOylumpbRO6brikMpONs49bKCImgUOpSmKVMv/bp6dGK9hBvlJ5rbmXapmbmYhBWUdHmF5eRb920QjzdXmnn7my9FsohBES4nFycAce5iexBli0Wi7EOLl0u6eCywpWYpWYnvArLKM5SFMcFlU8SyKsvV98QTCu2XLSlWyZ++7RJdd6W6hEmIm4GpQeYunOwWsr8+d3Osvzv5e+H2p5rqdfPxOppHOh1Jr+J4Rlvyqboy57rI2qXt/suSfwl3tp+y5GuoesKd0NnsVKPv3FuXZWunBsFP/GV89WXv/0BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// The plan to use to create an agreement.
    /// </summary>
    [DataContract]
    public class Plan {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Plan() {}

        /// <summary>
        /// The date and time when the plan was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// REQUIRED
        /// The plan description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the plan.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
        /// </summary>
        [DataMember(Name="merchant_preferences", EmitDefaultValue = false)]
        public MerchantPreferences MerchantPreferences { get; set; }

        /// <summary>
        /// REQUIRED
        /// The plan name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// An array of payment definitions for this plan.
        /// </summary>
        [DataMember(Name="payment_definitions", EmitDefaultValue = false)]
        public List<PaymentDefinition> PaymentDefinitions { get; set; }

        /// <summary>
        /// The status of the plan.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// An array of terms for this plan.
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue = false)]
        public List<Terms> Terms { get; set; }

        /// <summary>
        /// REQUIRED
        /// The plan type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The date and time when this plan was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }
    }
}

