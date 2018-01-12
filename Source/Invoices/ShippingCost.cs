// This class was generated on Mon, 08 Jan 2018 16:45:08 CST by version 0.1 of Braintree SDK Generator
// ShippingCost.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yVT2sbPRCH7++nGHR6C4tx2kKxb61zCYWkNCaXksNYmrWnaCV1NFu8lHz3Iv/bbLalLfWp5LTop93V82g06JtZdonM3NxuOCUOa1jErKYydyiMK0/X2JRpU5n31PWDS8pWOCnHYOZmuSHIxx/YmLUCzICQSCwFxTVBFMAmtkHhK/qWJqYyb0Ww2y8/rcxHQncTfGfmNfpMJfjSspA7BR8kJhJlymb+6QS+aEUo2G7MvF9vQH6KhvzvMBPE1WeyCnUh9R5qDhgso98Dg5BHJQc1k3cZ/l+hx2CpgoRdQ0HBtVQBqZ28OJtbVuGwHpvZg/MiOhr42X4zhoavwJMqCRzfABsdlSo5qjmQg1UHV7c38PrlxZs/Ko5K+4Q/tN4/VL+U2G3rgP6YDNEPx6ZNoBGuwfGaFbAuMrohcGS5QZ8hU0JBLeXrrTicrHaVLV9gShKTMCoNt+Mc3vePzJe4HWvrLuyl9+Mn/YRb4FBHabAkz83y3Cz/fLP8zJzdQHs3HN8+Qjm2YgmuLv+2W36zIqE8HpMdgjGb4hbK5HlPSmibFcmY63DnDtD67Md0gkoTuEPP7tDAnKGW2MB0Mp1elLM0m01ms9l5in7/8N93AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The shipping cost, as a percentage or amount value.
    /// </summary>
    [DataContract]
    public class ShippingCost {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public ShippingCost() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// Tax information.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Tax Tax { get; set; }
    }
}

