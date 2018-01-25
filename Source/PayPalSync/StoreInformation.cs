// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// StoreInformation.cs
// @version 0.1.0-dev+27d306
// @type object
// @data H4sIAAAAAAAC/6zPPUsEMRAG4N5fEaYOYr2dcM0hqOhhIyJjMusO5mOdzBZB7r9LVr0Pt7DwyrwZZt7nAzZ1JOjgXrOQWac+S0TlnMDCAwrjS6BrjG0ELFxR3T9WVJzwOA93sBnIlHkJ75ecg4VLEaxfVy4s3BH6mxQqdD2GQi14n1jI74JbySOJMhXoHnf9igqn12Wp+eQz+6NyB+Gy5Hplcm/wu2yfxaCJJG7ApIaT0QapRSm2OSGXxf/XkaYQtvZPjJJEThh+e47zJennv9kaqBHcQO4tT2qKYvINdsCc7SdBPW3PPgEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// The store information.
    /// </summary>
    [DataContract]
    public class StoreInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public StoreInformation() {}

        /// <summary>
        /// The ID of a store for a merchant in the system of record.
        /// </summary>
        [DataMember(Name="store_id", EmitDefaultValue = false)]
        public string StoreId;

        /// <summary>
        /// The terminal ID for the checkout stand in a merchant store.
        /// </summary>
        [DataMember(Name="terminal_id", EmitDefaultValue = false)]
        public string TerminalId;
    }
}

