// This class was generated on Wed, 13 Dec 2017 12:24:20 CST by version 0.1 of Braintree SDK Generator
// ShippingCost.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yVQWsbPRCG79+vGHT6Cotx2kJZ39rkkktSGpNLyWFWmrWnaCV1NCpeSv57ke04TTahLfWlkNPCaIWeZ+bV7nezHBOZhblac0ocVnAas5rGXKMwdp4ucKjLpjFnlK1wUo7BLMxyTZDv9tiYtQHMgJBILAXFFUEUwCGWoPANfaGZacx7ERx3J84b84nQXQY/mkWPPlMtfC0s5A6FjxITiTJls/h8YD0tIhTsOMXcnTeB/YCZIHZfyCr0Fct76DlgsIx+RwdCHpUc9EzeZfi/Q4/BUgMJx4GCgivUAKmdvTqaSFbhsJpq2HvBhyJvwJMqCdy9ATY6qp131HMgB90I51eX8Pb1ybs/arhKeYQZive3zS9Zt92bgO4HXxJohAtwvGIF7Cu6rgkcWR7QZ8iUUFDrTO4dOBwctuOqOzAliUkYlR7KH8Py5ifPJW6mkrotProBuAEOfZQBa+Ul3i/x/gfi/Zwnuyc/8UI5FrEE52d/G/DfbHioj6dQFDdQF48791CGjmSKsf+PPUsiqDSDa/Ts9jeMM/QSB5jP5vOTmou2nbVte5wB3tz+9wMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The shipping cost, as a percentage or amount value.
    */
    [DataContract]
    public class ShippingCost {

        // Required default constructor
        public ShippingCost() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /**
        * Tax information.
        */
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Tax Tax { get; set; }
    }
}

