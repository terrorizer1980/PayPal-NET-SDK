// This class was generated on Mon, 11 Dec 2017 17:19:30 CST by version 0.1 of Braintree SDK Generator
// PaymentDefinition.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xWYWvcRhD93l8x6FMLspSE0sJ9MzUFFxybxgSKCb653dHt0NWuMjvyRZT+97KSpTg+hTrU9ae7087Nvjfvzbv7q7geOio2xRUOLQWFM2o4sHIMRVm8R2HceXqLba4pyuKMkhHuxvNNcQp2KYcmCiAI7XuPAlFAhdFDNzWuirI4FcFhuu9VWfxOaC+DH4pNgz5RfvCxZyG7PLiS2JEoUyo2NwvSixhoAB06ggOrA9OLUDADmGgJPvbouWGycIe+p2MS2MY+6AqVseNIwntoOGAwGf/Y5kTIo5KFhsnbVMGvUYA+Ydt5KmGHHoOhcuYKtqcSMFhIEWL4Juoq/VeZJxUO+2NK8wSOSF07ght1QnRiHAoaJYHzd5cnP755/fOXg/vwvVPt0qauLd2Rz9dXHQ4d+srEtrbRpJqD0l4wN68tCxmthZLWc6OT3CjVP/xHwqH3/u/yX1nP+h5TXoiNJRVc8N4p7AgwwMiBZBT6vo4pgec/Cba/Xf2xBXWogEIQomZTsEHvB2jy+DgG9DAafRpr59EQWDLcol9q1rtfvz170D31O8t3bMlmTBHUxT5hsOru7aWOQO7HBKFvdyQQm+Wu8eZ0v3VfSFlCIoKb83eXkHWelN3U9eFwqDjFKsq+5hRrF1uqk2KwKDYtKt6OKlZO22cR8sMDKX9xKHuCi2jJpxUfj8e37Xz8aEMDYMaSh5Acdx2HPTRE46IpfgIOTZQWFwHUcXoQUI/I/PStCfREW5rBeEqrvvws4hwUUzFwOAI7WoDD+Jmy2CFNcfc5Ype0Wb6VlVfYTl23oBG2r7Yvs41NtupXQ2g5zeSzsWfsK8xfFu5tDgS5Q7+Kez4EVDg4Nm4Eb/qksSUBTjB51lbwPmcNGAw5NnYEeyHMcasOA7x+A20MebVfhB3bVTbnZ4/H/9BwpytPp7eU/scf9idSCvlljdQK6Fz7MoPO/xmeiirXPk+gfvcPAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * A definition for a regular or trial payment.
    */
    [DataContract]
    public class PaymentDefinition {

        // Required default constructor
        public PaymentDefinition() {}

        /**
        * REQUIRED
        * A type for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount { get; set; }

        /**
        * An array of shipping fee and tax information for this definition.
        */
        [DataMember(Name="charge_models")]
        public List<ChargeModels> ChargeModels { get; set; }

        /**
        * REQUIRED
        * The number of payment cycles in this definition. For infinite plans with a regular payment definition, set `cycles` to `0`.
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
        * The ID of the payment definition. A payment definition defines a regular or trial payment.
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
        * The payment definition type.
        */
        [DataMember(Name="type")]
        public string Type { get; set; }
    }
}

