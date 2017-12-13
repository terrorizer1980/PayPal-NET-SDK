// This class was generated on Wed, 13 Dec 2017 14:32:59 CST by version 0.1 of Braintree SDK Generator
// PaymentDefinition.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xWYWvcRhD93l8x6FMLspSE0sJ9MzUFFxybxgSKCb653dHt0NWuMjvyRZT+97KSpTg+hTrU9ae7087Nvjfvzbv7q7geOio2xRUOLQWFM2o4sHIMRVm8R2HceXqLba4pyuKMkhHuxvNNcQp2KYcmCiAI7XuPAlFAhdFDNzWuirI4FcFhuu9VWfxOaC+DH4pNgz5RfvCxZyG7PLiS2JEoUyo2NwvSixhoAB06ggOrA9OLUDADmGgJPvbouWGycIe+p2MS2MY+6AqVseNIwntoOGAwGf/Y5kTIo5KFhsnbVMGvUYA+Ydt5KmGHHoOhcuYKtqcSMFhIEWL4Juoq/VeZJxUO+2NK8wSOSF07ght1QnRiHAoaJYHzd5cnP755/fOXg/vwvVPt0qauLd2Rz9dXHQ4d+srEtrbRpJqD0l4wN68tCxmthZLWc6OT3CjVP/xHwqH3/u/yX1nP+h5TXoiNJRVc8N4p7AgwwMiBZBT6vo4pgec/Cba/Xf2xBXWogEIQomZTsEHvB2jy+DgG9DAafRpr59EQWDLcol9q1rtfvz170D31O8t3bMlmTBHUxT5hsOru7aWOQO7HBKFvdyQQm+Wu8eZ0v3VfSFlCIoKb83eXkHWelN3U9eFwqDjFKsq+5hRrF1uqk2KwKDYtKt6OKlZO22cR8sMDKX9xKHuCi2jJpxUfj8e37Xz8aEMDYMaSh5Acdx2HPTRE46IpfgIOTZQWFwHUcXoQUI/I/PStCfREW5rBeEqrvvws4hwUUzFwOAI7WoDD+Jmy2CFNcfc5Ype0Wb6VlVfYTl23oBG2r7Yvs41NtupXQ2g5zeSzsWfsK8xfFu5tDgS5Q7+Kez4EVDg4Nm4Eb/qksSUBTjB51lbwPmcNGAw5NnYEeyHMcasOA7x+A20MebVfhB3bVTbnZ4/H/9BwpytPp7eU/scf9idSCvlljdQK6Fz7MoPO/xmeiirXPk+gfvcPAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A definition for a regular or trial payment.
    /// </summary>
    [DataContract]
    public class PaymentDefinition {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentDefinition() {}

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount { get; set; }

        /// <summary>
        /// An array of shipping fee and tax information for this definition.
        /// </summary>
        [DataMember(Name="charge_models", EmitDefaultValue = false)]
        public List<ChargeModels> ChargeModels { get; set; }

        /// <summary>
        /// REQUIRED
        /// The number of payment cycles in this definition. For infinite plans with a regular payment definition, set `cycles` to `0`.
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
        /// The ID of the payment definition. A payment definition defines a regular or trial payment.
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
        /// The payment definition type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

