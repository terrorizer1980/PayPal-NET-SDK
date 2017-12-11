// This class was generated on Mon, 11 Dec 2017 13:16:28 CST by version 0.1 of Braintree SDK Generator
// PaymentExecution.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SSwa7TMBBF93zFyOtQsWKRXaWCVAlBVRU2CKUTe0qMHNuMx5QI9d+RHZqil917W89Vcs6d+aNOUyTVqojTSF46+k06iw1eNeoLssXe0UccS0Q1akdJs4113qp3NUsJEA44HdABah2yl9c9JjLw75twtTKADATniBNxZ80ZQi9oPRm4cBjr8Eo9YIwcfqGDz8cPG9WoLTNOM+GbRh0JzSfvJtVe0CUqDz+zZTLLw4FDJBZLSbVfF7ckbP33tdCdZiV2Ggj2OwiXClZjIAPKXTNiSpTA+tmKSTL7LrM7vxTaZ+duzUKukaUrZa7hhdEn1IU4rQS2HrBQVIVHEAwJWpc2sPfaZUOpCuBYlgboDVih8ZF6HxhyNChUh/Nt0LJXjc6lZu7gf5yy3R+kpZwDRUkQvJvm2Pyre+BJW2+f1da326u/AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * Executes a PayPal account-based payment with the `payer_id` obtained from the web approval URL.
    */
    [DataContract]
    public class PaymentExecution {

        // Required default constructor
        public PaymentExecution() {}

        /**
        * The ID of the payer that PayPal passes in the `return_url`.
        */
        [DataMember(Name="payer_id")]
        public string PayerId { get; set; }

        /**
        * An array of transaction details. Includes the amount and item details. For update and execute payment calls, the `transactions` object accepts only the `amount` object.
        */
        [DataMember(Name="transactions")]
        public List<CartBase> Transactions { get; set; }
    }
}

