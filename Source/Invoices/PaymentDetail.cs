// This class was generated on Mon, 08 Jan 2018 16:45:09 CST by version 0.1 of Braintree SDK Generator
// PaymentDetail.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yVX2/zNBTG7/kUR3lvtihNgPJH9K68fZEm2FaNCoGmaju1T1qDYxv7ZFVA++4of5o2LRNDq3a3HR87z+957NO/o0XlKJpEc6wKMgwzYlQ6SqJf0CtcabrBol6PkuhHqvb/zCgIrxwraw52y2Z3SKMkmnqPVXv450l0Ryhvja6iSY46UF34s1SeZF+Ye+vIs6IQTe57WR9L78mI6lQQFrY0PJDVl4bivsdAYFe/k2DIrQfUGnJl0AiFGp5QlwSeNDJJyBVpGeBihRqNoATcjqykBIhFenk2tsBemfUpmeiYP1pJAz6xN2NIOAZNzORh1wHCSgIMIClXhiSsKrj6+Ra++vKLb/9XOOzLI/2m1Po5+U+IxtaB+l1lKL3NDEoHbOEGpForBsxrGN4QSBKqQB0gkEOPXMe3p1Kmp2qSrXegc946r5BpaMc5uJevIJfIQ/CuMORe1HC1xu2GTCNcmSerBMEWAzhUMoW+J7e+QAYVIK6qqopH8fV1PIqljCH+K06OLLm/MkzeEMMMmbKFKgh+aE5YXmyY3STL2FodUkWcp9avsw0XOvO5GI/H330IJGqNo6/Tby7f+pBfeVkK4o2VA9P60qltuydZ1HfcemhbU9gpga3iTWPp46dfF5/ubqY/PfabuHL0Pi/A2KN70BWGQLfNH6hTmELdABiCFaoZRj1HJ/6d0mCPJmBzCR7UMJWTpdN0rmbtkIU5VnPUe+P3W/81qvn0t/mbgjoPcP3ZF5G7xVPog6Z3FX4i9iWBh67WMwJNN2+UWUOu7badNveehPUSPOWlkcuLTFoRMnQq67uzD92gCg9t86htvuzeIYTSOes5HL/Atq21p/lYH/nBSj3jugPqX2PrYYXijy16CcIWDlmtlFZcncXg5fNn/wAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Payment details.
    /// </summary>
    [DataContract]
    public class PaymentDetail {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentDetail() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The date when the invoice was paid. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// REQUIRED
        /// The payment mode or method. Required with the `EXTERNAL` payment type.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Optional. A note associated with the payment.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The ID for a PayPal payment transaction. Required with the `PAYPAL` payment type.
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The transaction type.
        /// </summary>
        [DataMember(Name="transaction_type", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The payment type in an invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

