// This class was generated on Wed, 13 Dec 2017 14:32:20 CST by version 0.1 of Braintree SDK Generator
// InvoiceItem.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yXz47bNhDG732KgYoCiaCV5brbwr6lWRTwIUnRGrkERnZMjtZTUKRCjhyrRd69oP/FrqymabyLHPZkgBzS3/xm5jP9VzJra0omydSuHCuCqVCVZMlr9IwLQy+xirtJltxQUJ5rYWePwg1bAhaqgG3pfIVxP0+y5Jn32G7vLrLkN0L9ypo2mZRoAsWFdw170oeFX72ryQtTSCZvDqqCeLZ3XT0ahTqaZkuCuAHvl2RBljthzkMgv4pq32OA2rsVa9I5HOK3woEDpG3btulV+uJFepVqnUL6Z5oBBtBUsiUNbOHN1Ap5SwI3KDSYcUXwy+aG+ZOlSD0ZDMQ5E3ImKXPn7wZLqczAl2o0Go2/DaSi3qvr/MenXwrKNsZ8yD5N6wjTOWgbTEdBF5b13AU5I4qDco2Vs4qUCxKxI9TkFVmJVUQLWMUjsELTUB6pA62xqg1lIA5CTYrLFobFdxlQrBLcDovbHJ6ZWDEUXpFpT0I/3ulKuD6cur69XA8/b7wnq9ougu03dwD8jIHALf4gJbE1AY2Bki1axWi2uYMng0IaSiajAzxZoEGrKIMa2yry0g1lQKLyp/c+jOpjgqeJjMCQRJ77CFBO0/E4LVqY/v4Kfvh++NNnARff/L9R2NDrCN21QFPH1ngJmu9YAMsoPdqIJsUVmgCBavQosSYnlrDPYVOueALr2rvac3SXk+QvkeX8KE/bVAvy3Tx3Y9M7XNnpdO0G6jUa1rsO4wCldxUUkcmwKC5iCvP/UCIbP3ptKu5etlX6EL5r0ApL269lH3Ee3NWwKIo9vc/k90nRM1x3Fctm8R9icX0/P82PtvZoa/dma315sj47jZ6Ca3x8vd480JOq16QE1w/oUf9m81GJR+mz9bwohrEvxuN8PB4/VAEby/LWlW8rwtD48whjTHyO7WIO3cfb/xx6Y76XfqP2utlGce1Z0dfkaN0SPBra12do8w/f/A0AAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Invoice line item information.
    /// </summary>
    [DataContract]
    public class InvoiceItem {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceItem() {}

        /// <summary>
        /// The date when the item or service was provided. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// The item description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue = false)]
        public Cost Discount { get; set; }

        /// <summary>
        /// REQUIRED
        /// The item name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED
        /// The item quantity. Valid value is from -10000 to 10000.
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Tax information.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Tax Tax { get; set; }

        /// <summary>
        /// The unit of measure for the invoiced item.
        /// </summary>
        [DataMember(Name="unit_of_measure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// REQUIRED
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue = false)]
        public Currency UnitPrice { get; set; }
    }
}

