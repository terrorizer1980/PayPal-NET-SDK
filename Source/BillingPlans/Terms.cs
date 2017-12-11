// This class was generated on Mon, 11 Dec 2017 16:50:54 CST by version 0.1 of Braintree SDK Generator
// Terms.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xWUWsbRxB+768Y7qmF011bCgW9lZqCCrVNbQLBGDG3O9JOsrd7mZ21coT897AnWSKRTBJsnBe/zs3OzPd9Mx/3oboeB6rm1TVJn6q6eoXC2Hk6x76Eq7o6o2SEB+UYSp4j0JILqyigjmDwGJqqrv4SwXFb7de6+p/QXgQ/VvMV+kQl8C6zkN0HLiUOJMqUqvnNfo6/swgFMx6Pgn3MQZeCYU0nx+owEcTuDRmdhkPvYcUBg2H0cIc+00zIo5KFFZO3qYaUjQNM0KHHYKiGAceegoLNVAMGCylC/D58KvlBeEmFw/oYnDnAPgZ2o06IZsahoFESWFxdzP74/bc/4f4ZmGjp9menOqR521q6I1/aNwOOA/rGxL610aSWg9JasBRvLQsZbYWStveFZqVQan95JOCQvf9YfxX1pMlJyHtgU0oD//HaKXQEGGDCQDJpvMtjSuD5LcG/l69BHSqgEISooOPABr0fYVXI4xjQQ1kOsGS4R7+Pn6x3fX52qJdyZ/mOLdkyQwR1MScMVl1q4J/dOciOFgi570ggrvadBo+GtoeDn0tXQyKCm8XVBRRdD0puNpuGU2yirFtOsXWxpzYpBoti01625SRb47R/EuVuv0G7Lo8kS7KsJXgk4iJYNqiUYONIHW3JMTlp7EnAYIDydopuLxs4gDpOk708z/6xPbl8i7Oimt473WPN7YthHna4Ht8vO/aew3q55eTF51587sXnfqjPRbNrTumkggf4yj2lLYt9DDROJtcRDNl7smBzafDcFqfl80M/cWVr6GmI/OkTAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /**
    * The terms for the plan.
    */
    [DataContract]
    public class Terms {

        // Required default constructor
        public Terms() {}

        /**
        * REQUIRED
        * The base object for all financial value-related fields, such as balance, payment due, and so on.
        */
        [DataMember(Name="amount_range")]
        public Currency AmountRange { get; set; }

        /**
        * REQUIRED
        * Indicates whether the customer can edit the amount in this term.
        */
        [DataMember(Name="buyer_editable")]
        public string BuyerEditable { get; set; }

        /**
        * The ID of the terms.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * REQUIRED
        * The base object for all financial value-related fields, such as balance, payment due, and so on.
        */
        [DataMember(Name="max_billing_amount")]
        public Currency MaxBillingAmount { get; set; }

        /**
        * REQUIRED
        * The number of times that money can be pulled during this term.
        */
        [DataMember(Name="occurrences")]
        public string Occurrences { get; set; }

        /**
        * REQUIRED
        * The term type.
        */
        [DataMember(Name="type")]
        public string Type { get; set; }
    }
}

