// This class was generated on Wed, 13 Dec 2017 14:32:57 CST by version 0.1 of Braintree SDK Generator
// OverrideChargeModel.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yU0WvUQBDG3/0rhn1SyCUqgnBvxSJUaK/YIkgp7dzu5DK42U1nJ3cG8X+XTe6OljtRsa/JzDfz+75hf5jroSMzN4s1ibAj+NCgrAjOoyNvCvMFhXHp6QLbXGYKc0rJCnfKMZi5OQE7NbS5AbRBhbjVSuCoxt7rroZDHaXF3AquFw4rwJUQtRQUrND4pzSFORHBYdrsdWE+E7pF8IOZ1+gT5Q8PPQu5/YdLiR2JMiUzv9kzncdAA+jQEWxYG7C9CAU7gI2O4KFHzzWTgzX6ng5ZsY190CPEo2IdBdB7qDlgsIx+kpkJeVRyUDN5l0r4GAXoO7adpwKW6DFYKqDDYYR2PRWAwUGK8I/oKv1vyZNmcw+Rdg4cQF03BDfaCNEsZ4VWSeDsajF79/bN+6fG3b5sVLs0rypHa/J5fNnh0KEvbWwrF22qOCitZIyzcixktRJKWu2EZlkoVa/+Ezj03v8s/ki9y/cQeQ82lpRwzqtGYUmAAUYGkjHobR1TAs/fCO4/XX69n44dhSBEzUfBFr0foM72cQzoId8ITLZ2Hi2BI8st+n3NcfXri9NH6qlfOl6zI5d3iqBN7BMGp832vLQhkK1NEPp2SQKx3s8aJ6fpYJ9GWUAigpuzqwXknKdk51W12WxKTrGMsqo4xaqJLVVJMTgUl/Yp3o0plo22zxLk7V9EOT0kd+yOxnl2mrmzHY8fpefZ7cUvAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A charge model that overrides default charge information during agreement creation.
    /// </summary>
    [DataContract]
    public class OverrideChargeModel {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public OverrideChargeModel() {}

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount { get; set; }

        /// <summary>
        /// REQUIRED
        /// The ID of the charge model.
        /// </summary>
        [DataMember(Name="charge_id", EmitDefaultValue = false)]
        public string ChargeId { get; set; }
    }
}

