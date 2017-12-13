// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// ChargeModel.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yU32sUQQzH3/0rwjwp7O2qCMK9iUWo0B/YIkgpkp3J3kRnZ9ZMtuci/u8y23ZP6YmV9jWTSfLJ90t+mPNpILM2bz3KhuAoOQqmMh9RGNtAx9iXV1OZA8pWeFBO0azNuSfInoeB4wY6IsDoQPE7cOyS9FjSalOZNyI4Xbd4XpkPhO4khsmsOwyZSuDbyEJuCZxKGkiUKZv1xW64UYSine4Ohn0ao+4dr8VMkNovZBW6JIAhQMcRo2UMcIVhpJVQQCUHHVNwuYI8Wg+YocWA0VIFA049RQU3UjUz5gT/SaYy/hUsq3Dc3MWyO+C7YBfqhWhlPQpaJYHDs5PVq5cvXsPtN7DJ0eVTrzrkddM4uqJQ2tcDTgOG2qa+ccnmhqPSRma1GsdCVhuhrM1toVUplJtnDwSOYwg/q39Sz5rsRV7A5pQajnjjFdpiO5gZSGaNb/KYMgT+SvD+9BOoRwUUgpgUdBrYYggTdGV5nCIGKOYAR5Z7DEt8b73z44NdvTy2jq/YkSszJFCfxozRqc81vEsC6gnkZi0Qx74lgdQtnYaAlvK1N/+UroJMBBeHZydQdN0pud1ua86pTrJpOKfGp56arBgdisuLbJ9n2Wqv/aMod3kP7djtFe7woBCXRdjrA9OXA/PQy3BPP2l53mun32YplqAKtp6tB87zEUuyHLfH2d+TXwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// The shipping fee and tax information.
    /// </summary>
    [DataContract]
    public class ChargeModel {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ChargeModel() {}

        /// <summary>
        /// REQUIRED
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The ID of the charge model.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// REQUIRED
        /// The charge model type, which is tax or shipping.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

