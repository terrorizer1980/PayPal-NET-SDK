// This class was generated on Wed, 13 Dec 2017 14:31:41 CST by version 0.1 of Braintree SDK Generator
// Amount.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yX32/TMBDH3/krTnmCKm06QELqGxJC2gNsYhMvY6rc+JKccOzsfKaL0P535CYpbO2mTYOKhzxF5/uRr+/js5KfyXnbYLJIVO2ClSRNviomtTL4WdVxPUmTD+hzpkbI2WSRnFcIjWprtAJdUgprkgpWjOr7NDR+lqTJe2bVdqXnafIFlT6xpk0WhTIe48JVIEa9XThl1yALoU8WF1tRXphsuSsqD8xo83avuAupGHGaV4pVLshwfHYyffv66B0MaZA7jZcvM+1yn5EVLFnFApkmxlwyRi/ZEDyNwT57NYNT1Z4qA9qhB+sEfGgaxwLKmKE04dN2LxzubN4GY27SO1iWGkWR8bud+O3YbYTSmqIZNXdhoFYuCMgOwn+PrKRClmtWzV6p0QvRCwXiDD6pa6pDDQZtKRWQh6M5bIH6FNYV5RWQzU3Q6Bffwnz+Jg9m88TOMtRZZ/gDLWgqSTyssHCMmwZozKlWBhpHVmZdTjYk3S5x/sTwtRvep4p4AB/5umzYwDNh3DlC9xGplNWGbLksEPdCGQJGJlFyN+yooXBddn8dDINUo1ROg7OmnR0GIFkfWNl8P72td8R3C18E9DDDA+HzFTVN59mlNzhHeAe7D4eWLzX5vP8YehgMDJHjeP1/t6MPK3GizH6KvbP//NmqJsHaz+C42FiMVwG9bKmBIdvHpCAVeWg6XW0EPplwL3syGUf2IIxFXe/FK+p6JPAXCFw+hsG9Q3ZrwmLjS9Qgbvj9QIRVuzV4Bh8dA2MRrPYpMDaMHq34TUhfRSolf+T30UNRx1SS7W6dWHA8Ac/9Eb28efELAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The payment amount, with break-ups.
    /// </summary>
    [DataContract]
    public class Amount {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Amount() {}

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/). PayPal does not support all currencies.
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The additional details about the payment amount.
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue = false)]
        public AmountDetails Details { get; set; }

        /// <summary>
        /// REQUIRED
        /// The total amount charged to the payee by the payer. For refunds, represents the amount that the payee refunds to the original payer. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue = false)]
        public string Total { get; set; }
    }
}

