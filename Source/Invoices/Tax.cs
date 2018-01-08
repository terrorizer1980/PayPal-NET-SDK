// This class was generated on Mon, 08 Jan 2018 16:45:07 CST by version 0.1 of Braintree SDK Generator
// Tax.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTwW7UMBCG7zzFyCeQomgLSCh7g/ZSIbUIql4Qh4k9aQc5thmPUSPEuyPvbnfJLhJF5BT5Txx9n3/PD3MzJTJrc4MPpjG3KIy9pysca2ga856mw+KCshVOyjFstwCHIcqINWlNY96K4LT946oxHwnddfCTWQ/oM9XgW2Ehtw8+SEwkypTN+vOe5byIULDTKRCOsQSdYe2jOdw7zASx/0pWYYgC6D0MHDBYRg/f0RcCIY9KDgYm7zI879FjsNRAwmmkoOAKNUBq2xeLuWUVDnenZnbnfB4dzfzs4TDmhq/AkyoJPH4BNjoCzOBo4EAO+gkuP13D65dnb/6pHJVyxB+K9z+bv0psjnVG/5jM0bedQUmgEa7A8R0r4FBl9J7AkeURfYZMCQW11new4rC32jRbd2BKEpMwKs2PYwnvL08wZzfT3iyPpuW+Xrgci1iCy4v/nZYnNhLq43eyXXDKpvgA9eWyNyWUsSc55Uoklo4m+ZD9mU5QqYVb9Ox2A8wZBokjrNrV6qzepa5ru65bpvRnvwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Tax information.
    /// </summary>
    [DataContract]
    public class Tax {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Tax() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The resource ID.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// REQUIRED
        /// The tax name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED
        /// The tax rate. Valid value is from 0.001 to 99.999.
        /// </summary>
        [DataMember(Name="percent", EmitDefaultValue = false)]
        public double Percent { get; set; }
    }
}

