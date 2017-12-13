// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// PaymentDefinition.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xW32vcRhB+718x6KkFWUpCacFvIW7BhcSmMYFigj23O9JOu9pVd0Z3FaX/e1nJp3N7cus4wU/H7fzY+eab+bR/FldjT8VpcYljR0HhjBoOrBxDURYfMDFuPL3DLvsUZXFGYhL3k/20eA39XZhdwkrYOTYOLCmljgMJuLiD2CgFwGChiWk68TG0oI7ADKKxowQsYBymlmwF58H4wZJMHhyU0hY9oN5lfyCunA3TH8AuDkHL6dI4lYwexHHfc2ihIZLJpPgHSVWUxeuUcJzb8aIsfia0F8GPxWmDXigf/D5wIrscXKbYU1ImKU6vl0a+GVKiYMbj9s31HDXxyhFsUAji5lcyOvUHvYeGAwbD6GGLfqCTRB6VLDRM3koJMhgHKLBBj8FQeeBioBm0RIjhk5BpGh4EJpo4tMewzAHwMbBrdYnoJDOCRinB+fuLk29fvfwe9mFgoqWPXzvVXk7r2tKWfL6+6nHs0VcmdrWNRuo8BG3CnLy2nMhonUi03ic6yYmk/uYzAYfB+7/K/0U9cbIKeQE2uVTwllunsCHAMA1yS2ni+M6PScDzbwQ/Xf4C6lABE0GICjr2bND7EZrcvHl+83CAJcMd+uV8Nd/Vu7NDPhk2lrdsyeYaIqiLg2Cw6qSCH2Oa9ibdtQXC0G0oQWyWm3qPhmSezX9SV4IQwfX5+wvIvB6Y3O12FUusYmprlli72FEtisFisrLQdjPRVjntvghzH+9x92bWgbfRkl+Z28l602WrHEtbAMyl5CY8TjO++1TNeOSkmdF4ktVRO/C03/3ZeaaUw6TJlMkLAjtWBwiJ2sFjWlVuIYXbOcUtaITbF7fPs01NHr0HRWSxZqR5UPe1cwB1LPcwPHO5N/sv02rdj/5sVfAhawUYDHnxNwRtIsxyqQ4DvHwFXQx5VZ8FHdtVNOdn/27/E9v+9FUI+WettuOKIPs+T780mx9ZVfat4Ac0btpK6AZRcLilPCOeUBRioP9Y0iw/5fKc8WMJCJryK2GFlfmie8HSk+GGn/Ym+yLq/NXfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// A payment definition, which determines how often and for how long the customer is charged. Includes the interval at which the customer is charged, the charge amount, and optional shipping fees and taxes.
    /// </summary>
    [DataContract]
    public class PaymentDefinition {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentDefinition() {}

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// An array of shipping fees and taxes.
        /// </summary>
        [DataMember(Name="charge_models", EmitDefaultValue = false)]
        public List<ChargeModel> ChargeModels { get; set; }

        /// <summary>
        /// REQUIRED
        /// The number of payment cycles. For infinite plans with a regular payment definition, set `cycles` to `0`.
        /// </summary>
        [DataMember(Name="cycles", EmitDefaultValue = false)]
        public string Cycles { get; set; }

        /// <summary>
        /// REQUIRED
        /// The frequency of the payment in this definition.
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// REQUIRED
        /// The interval at which the customer is charged. Value cannot be greater than 12 months.
        /// </summary>
        [DataMember(Name="frequency_interval", EmitDefaultValue = false)]
        public string FrequencyInterval { get; set; }

        /// <summary>
        /// The ID of the payment definition.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// REQUIRED
        /// The payment definition name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED
        /// The payment definition type. Each plan must have at least one regular payment definition and, optionally, a trial payment definition. Each definition specifies how often and for how long the customer is charged.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

