// This class was generated on Mon, 11 Dec 2017 16:50:54 CST by version 0.1 of Braintree SDK Generator
// PaymentDefinition.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xW32vcRhB+718x6KkFWUpCacFvIW7BhcSmMYFigj23O9JOu9pVd0Z3FaX/e1nJp3N7cus4wU/H7fzY+eab+bR/FldjT8VpcYljR0HhjBoOrBxDURYfMDFuPL3DLvsUZXFGYhL3k/20eA39XZhdwkrYOTYOLCmljgMJuLiD2CgFwGChiWk68TG0oI7ADKKxowQsYBymlmwF58H4wZJMHhyU0hY9oN5lfyCunA3TH8AuDkHL6dI4lYwexHHfc2ihIZLJpPgHSVWUxeuUcJzb8aIsfia0F8GPxWmDXigf/D5wIrscXKbYU1ImKU6vl0a+GVKiYMbj9s31HDXxyhFsUAji5lcyOvUHvYeGAwbD6GGLfqCTRB6VLDRM3koJMhgHKLBBj8FQeeBioBm0RIjhk5BpGh4EJpo4tMewzAHwMbBrdYnoJDOCRinB+fuLk29fvfwe9mFgoqWPXzvVXk7r2tKWfL6+6nHs0VcmdrWNRuo8BG3CnLy2nMhonUi03ic6yYmk/uYzAYfB+7/K/0U9cbIKeQE2uVTwllunsCHAMA1yS2ni+M6PScDzbwQ/Xf4C6lABE0GICjr2bND7EZrcvHl+83CAJcMd+uV8Nd/Vu7NDPhk2lrdsyeYaIqiLg2Cw6qSCH2Oa9ibdtQXC0G0oQWyWm3qPhmSezX9SV4IQwfX5+wvIvB6Y3O12FUusYmprlli72FEtisFisrLQdjPRVjntvghzH+9x92bWgbfRkl+Z28l602WrHEtbAMyl5CY8TjO++1TNeOSkmdF4ktVRO/C03/3ZeaaUw6TJlMkLAjtWBwiJ2sFjWlVuIYXbOcUtaITbF7fPs01NHr0HRWSxZqR5UPe1cwB1LPcwPHO5N/sv02rdj/5sVfAhawUYDHnxNwRtIsxyqQ4DvHwFXQx5VZ8FHdtVNOdn/27/E9v+9FUI+WettuOKIPs+T780mx9ZVfat4Ac0btpK6AZRcLilPCOeUBRioP9Y0iw/5fKc8WMJCJryK2GFlfmie8HSk+GGn/Ym+yLq/NXfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /**
    * A payment definition, which determines how often and for how long the customer is charged. Includes the interval at which the customer is charged, the charge amount, and optional shipping fees and taxes.
    */
    [DataContract]
    public class PaymentDefinition {

        // Required default constructor
        public PaymentDefinition() {}

        /**
        * REQUIRED
        * The base object for all financial value-related fields, such as balance, payment due, and so on.
        */
        [DataMember(Name="amount")]
        public Currency Amount { get; set; }

        /**
        * An array of shipping fees and taxes.
        */
        [DataMember(Name="charge_models")]
        public List<ChargeModel> ChargeModels { get; set; }

        /**
        * REQUIRED
        * The number of payment cycles. For infinite plans with a regular payment definition, set `cycles` to `0`.
        */
        [DataMember(Name="cycles")]
        public string Cycles { get; set; }

        /**
        * REQUIRED
        * The frequency of the payment in this definition.
        */
        [DataMember(Name="frequency")]
        public string Frequency { get; set; }

        /**
        * REQUIRED
        * The interval at which the customer is charged. Value cannot be greater than 12 months.
        */
        [DataMember(Name="frequency_interval")]
        public string FrequencyInterval { get; set; }

        /**
        * The ID of the payment definition.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * REQUIRED
        * The payment definition name.
        */
        [DataMember(Name="name")]
        public string Name { get; set; }

        /**
        * REQUIRED
        * The payment definition type. Each plan must have at least one regular payment definition and, optionally, a trial payment definition. Each definition specifies how often and for how long the customer is charged.
        */
        [DataMember(Name="type")]
        public string Type { get; set; }
    }
}

