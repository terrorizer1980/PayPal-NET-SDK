// This class was generated on Wed, 13 Dec 2017 14:33:00 CST by version 0.1 of Braintree SDK Generator
// AgreementTransaction.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xXb2vjxhN+//sUg35veiBLadM/1O9CQyGFu4ScOShpsMe7I2vpalc3O4qrlvvuZVe248S6piXXHAW/MvKOZp5n5nnG6z+yWd9SNs3OVkzUkBMQRhdQifEuy7N3yAaXlt5gE8OyPDunoNi06XyanTnAsVcLuCbp2JGGyjPg/hkEQlZ1keXZGTP2A4STPLsm1JfO9tm0QhsofvG+M0x698UV+5ZYDIVserMD/9o76kH6lmBtpAbVMZNTPSivCd53aE1lSMMd2o4OSWHjOyeH1IaMCb61UBmHThm0Q5oJk0WJ9AxZHQr40TPQb9i0lnJYokWnKIcW+9Qa3VEO6DQED979I+rC3UeZB2HjVoeUth04IDWrCW6kZqKJqpFRCTFcvL2cfP3Vl989bNztF7VIG6ZlqemObCxftNi3aAvlm1J7FUrjhFaMMXmpDZOSkilIuU00iYlC+eqZhF1n7Yf8Sdbb+R5S3hFLIQW8NqtaYEmADhIH4jToTZyhANb8SrD46ernBUiNAsgEzksUhVFobQ8VD3pGC4PEU1tbi4pAkzIN2l3MePbZm/O97KFbanNnNOmIyYPUvgvotNQbeUlNwJs2geuaJTH4alcrVQ4bvz0YZQ6BCG4u3l5CnPMw2WlZrtfrwgRfeF6VJviy9g2VQdBpZB12U5ynKRa1NJ9kkLd7o3ymdSui+dG+R/se7fuftK8jOdr3aN+jfT+TfT82yhZ74jk1aOzoQNMJXJxH/pIGHMQ3xM+90v9NpQ3wXHwYQ7fsgnEUAsSIzwQxCEoX/sINAkPIFt+D/07vok/AhOkv3cnJqeps+qThyZrhafGDj+tOSC8KmD1MASaA2hynxRdLNGlZ1xhgSeSG8IqimpPcKa5LomKoUm7LPCp6hSwmGnB+TVXndKp+Bi2yjFCBYbvfF+XNS/sl+amS5LRxq3GW7XAIgURs+hv6RLY92LN/Aew5OTOafJdVp4jxNOV21C+jUjENzYNg044qVeNWPaYhWNdRNI9YeZXkrHMwDm4unBA7kkdvVp4blPtfNPHehsKQVGn31dLYkit1enr6/f8DpcSTb4pvXxUv2IXfvRvfJolBPN3Ke9G1kd48HiyGC8hLAb1v/NzoUbT3O3l/obw8vHh5G29nvNVFiPv7brb9Vc9hcU1RUdHSV8PtbfFJ4N9++N+fAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// An agreement transaction. Returned for a transaction search.
    /// </summary>
    [DataContract]
    public class AgreementTransaction {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AgreementTransaction() {}

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount { get; set; }

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="fee_amount", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue FeeAmount { get; set; }

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="net_amount", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue NetAmount { get; set; }

        /// <summary>
        /// The email ID of the customer.
        /// </summary>
        [DataMember(Name="payer_email", EmitDefaultValue = false)]
        public string PayerEmail { get; set; }

        /// <summary>
        /// The business name of the customer.
        /// </summary>
        [DataMember(Name="payer_name", EmitDefaultValue = false)]
        public string PayerName { get; set; }

        /// <summary>
        /// The current status of the transaction. Value is:<ul><li>`Completed`. The transaction is complete and the money has been transfered to the payee.</li><li>`Partially_Refunded`. A part of the transaction amount has been refunded to the payer.</li><li>`Pending`. The transaction is pending settlement.</li><li>`Refunded`. The transaction amount has been refunded to the payer.</li><li>`Denied`. The transaction has been denied.</li></ul>
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The date and time when the transaction occurred, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="time_stamp", EmitDefaultValue = false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// The time zone of the `update_time` field.
        /// </summary>
        [DataMember(Name="time_zone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The ID of the transaction.
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The type of transaction. Typically, `Recurring Payment`.
        /// </summary>
        [DataMember(Name="transaction_type", EmitDefaultValue = false)]
        public string TransactionType { get; set; }
    }
}

