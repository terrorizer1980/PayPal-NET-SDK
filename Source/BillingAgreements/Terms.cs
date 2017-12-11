// This class was generated on Mon, 11 Dec 2017 17:19:31 CST by version 0.1 of Braintree SDK Generator
// Terms.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xUTWvcSBC9768odNoFjbS7LCzMzWAWZsEfxCYQjBmXumtGRVrdcnW1xyLkv4eWxpM4MyEJNiYHX4vWq/dReh+Ky6GnYl5cknSxKIu3KIyNo1Ps8rgoi2OKRrhXDj6/awl6hx40f1AVZXEkgsOE8mdZvCG0Z94NxXyFLlIe3CYWsrvBuYSeRJliMb/a7T8JngbQoSfYsLZgkgh5M4AJluA2oeMVk4U7dIn2eWIXkteloF/THuejCXcVBNA5WLFHbxjdBDYTcqhkYcXkbKzgvyBA99j1jkpo0KE3VEKPQ0dewSYqAb2FGCD4nzJAJX1Tf1Rhv94X9uDDwSCutBWimWlR0CgJLC7OZv/8/de/j+27/r1V7eO8ri3dkcvrqx6HHl1lQlfbYGLNXmktmMFry0JGa6Go9QPQLAPF+o8nCvbJuY/ld1U/pLwveSdsfFLBCa9bhYYAPYwaSMagt++YIjh+T3Dz//m7G9AWFVAIfNB8FGzQuQFW2T4OHh3kG4HJ1t6hIbBkuEO3e3MY/fL0+Av0mBrLd2zJZk4BtA0porfabs9LWwLZ2gQ+dQ0JhNVu17g5Tgf7OMoSIhFcLS7OIOc8JTuv681mU3EMVZB1zTHUbeiojoreoti4S3E5pli12j1LkNc/EGWTBpIlWdY83Mt04S0bVIqwaUlbmrwxKWroSMCgh/ztOJ1+cmAP2nIcG+hlzpHtwVtcHOfQMrNnKcOvyDyxETu8XzbsHPv1cjLutRdfe/G1F3+VXgxmu5ziwUA/q1fuKE4mdmMn5FJsCPrkHFmwKS946UrMzXGQd6Yw9srzGPnbJwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * The plan terms.
    */
    [DataContract]
    public class Terms {

        // Required default constructor
        public Terms() {}

        /**
        * REQUIRED
        * A type for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="amount_range")]
        public MoneyTypeWithCurrencyCodeQualifiedValue AmountRange { get; set; }

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
        * A type for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="max_billing_amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue MaxBillingAmount { get; set; }

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

