// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// FmfDetails.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/7zRwUoDMRAG4LtPscyphdV43ptQAiJV0eKllDJuJutAktZJclik7y6hpW6pRaTiadl/huT7yQfM+jVBA9bbpaGE7CLU8ILC+OroHn0ZQg131H/9TCi2wuvEqwANzN6ommvBbKopBuzIU0iVZpdIqpGe6vFipMyqjap1GCO3ynqrOCTqBMsZl11mQ0pP9XP2HqVX42pnuYIabkSw3zKva3giNA/B9dBYdJFK8J5ZyOyDR1mtSRJThGa+LxiTcOiOu5lBl2HNw/y4sd32G6ydaw3ZuU39I3h78ZLNAXeYnsTeTn5lTJLPIqay9Q1yl59klvn/QEP5DIW74CStzP/knRebi08AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
    /// </summary>
    [DataContract]
    public class FmfDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FmfDetails() {}

        /// <summary>
        /// The filter description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The filter ID.
        /// </summary>
        [DataMember(Name="filter_id", EmitDefaultValue = false)]
        public string FilterId;

        /// <summary>
        /// REQUIRED
        /// The filter type.
        /// </summary>
        [DataMember(Name="filter_type", EmitDefaultValue = false)]
        public string FilterType;

        /// <summary>
        /// The filter name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;
    }
}

