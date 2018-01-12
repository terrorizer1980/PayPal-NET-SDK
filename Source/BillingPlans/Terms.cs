// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// Terms.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xWUWsbRxB+768Y7qmF011bCgW9lZqCCrVNbQLBGDG3O9JOsrd7mZ21coT897AnWSKRTBJsnBe/zs3OzPd9Mx/3oboeB6rm1TVJn6q6eoXC2Hk6x76Eq7o6o2SEB+UYSp4j0JILqyigjmDwGJqqrv4SwXFb7de6+p/QXgQ/VvMV+kQl8C6zkN0HLiUOJMqUqvnNfo6/swgFMx6Pgn3MQZeCYU0nx+owEcTuDRmdhkPvYcUBg2H0cIc+00zIo5KFFZO3qYaUjQNM0KHHYKiGAceegoLNVAMGCylC/D58KvlBeEmFw/oYnDnAPgZ2o06IZsahoFESWFxdzP74/bc/4f4ZmGjp9menOqR521q6I1/aNwOOA/rGxL610aSWg9JasBRvLQsZbYWStveFZqVQan95JOCQvf9YfxX1pMlJyHtgU0oD//HaKXQEGGDCQDJpvMtjSuD5LcG/l69BHSqgEISooOPABr0fYVXI4xjQQ1kOsGS4R7+Pn6x3fX52qJdyZ/mOLdkyQwR1MScMVl1q4J/dOciOFgi570ggrvadBo+GtoeDn0tXQyKCm8XVBRRdD0puNpuGU2yirFtOsXWxpzYpBoti01625SRb47R/EuVuv0G7Lo8kS7KsJXgk4iJYNqiUYONIHW3JMTlp7EnAYIDydopuLxs4gDpOk708z/6xPbl8i7Oimt473WPN7YthHna4Ht8vO/aew3q55eTF51587sXnfqjPRbNrTumkggf4yj2lLYt9DDROJtcRDNl7smBzafDcFqfl80M/cWVr6GmI/OkTAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// The terms for the plan.
    /// </summary>
    [DataContract]
    public class Terms {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Terms() {}

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount_range", EmitDefaultValue = false)]
        public Currency AmountRange { get; set; }

        /// <summary>
        /// REQUIRED
        /// Indicates whether the customer can edit the amount in this term.
        /// </summary>
        [DataMember(Name="buyer_editable", EmitDefaultValue = false)]
        public string BuyerEditable { get; set; }

        /// <summary>
        /// The ID of the terms.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="max_billing_amount", EmitDefaultValue = false)]
        public Currency MaxBillingAmount { get; set; }

        /// <summary>
        /// REQUIRED
        /// The number of times that money can be pulled during this term.
        /// </summary>
        [DataMember(Name="occurrences", EmitDefaultValue = false)]
        public string Occurrences { get; set; }

        /// <summary>
        /// REQUIRED
        /// The term type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

