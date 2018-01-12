// This class was generated on Wed, 13 Dec 2017 14:32:59 CST by version 0.1 of Braintree SDK Generator
// ChargeModels.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yUX2sbOxDF3++nGPR0L6x3b0uh4LfQUEghf2hCoYTQjKVZa6hW2oxm4yyl371o7bhJ7dKU5FUaHel3zmi+mYuxJzM37zzKkuA4OQrZVOYTCuMi0Al2ZdtU5pCyFe6VUzRzcwB2faIrJ6BNAgg9jh1FBUctRy6VNfxSOG1Rhuy57zkuoSUCjA4U74Bjm6TD6aCpzIEIjuv3/V+Zj4TuNIbRzFsMmcrCzcBCbrtwJqknUaZs5pdbsuMUaQQde4IVqwc7iFC0I9jkCG4GDNwyObjFMNAuOXZpiLqHf1KcuEOAliNGyxjWMjOhgEoOWqbgcg3vkwDdYdcHqmCBAaOl6qdfA1WTCTnBX6KrDL8lzyocl7tI9w7sQF14gkv1QjQroaFVEjg6P529ef3q7WPjrv71qn2eN42jWwrl+rrHscdQ29Q1LtnccFRayhRn41jIaiOUtbkXmhWh3Pz3TOA4hPC9+iP1fb67yFuwqaSGY156hUXpS5gYSKagN3VMGQJ/Jbj+cPb5GtSjAgpBTFqagi2GMEJb7OMUMcD0N9a29gEtgSPLHYZtzX71i5PDB+p5WDi+ZUeuvCmB+jRkjE79pr3UE8jGJohDtyCB1G7vmm7Om4/6KMoKMhFcHp2fQsl5ney8aVarVc051UmWDefU+NRRkxWjQ3F5m+KXKcXaa/ciQV49IUp2e3M8OizAxYeHI+e5k+SJ7VXGwf7uejj+StXLuPTPDwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// A charge model for a payment definition. A charge model defines shipping fee and tax information.
    /// </summary>
    [DataContract]
    public class ChargeModels {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public ChargeModels() {}

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount { get; set; }

        /// <summary>
        /// The ID of the charge model.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// REQUIRED
        /// The charge model type.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

