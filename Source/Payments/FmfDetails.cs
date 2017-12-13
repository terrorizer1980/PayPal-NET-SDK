// This class was generated on Wed, 13 Dec 2017 14:31:46 CST by version 0.1 of Braintree SDK Generator
// FmfDetails.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yRwUoDMRCG7z7FMqcWVuN5b0IJeKiKFi+llHEzWQeS7DpJDov03SWslIKyIhVPgfmH/N/HvMNmHAgasN7uDSVkF6GGZxTGF0d36EsINawotsJD4j5AA5tXqrZaMJtqjQE78hRSpdklkmqh13q5WyjTt1G1DmPkVllvFYdEnWD547LLbEjptX7K3qOMall91l9BDTciOE5k1zU8Epr74EZoLLpIZfCWWcgcBw/SDySJKUKzPTrFJBy6rzrmxOU7Mzt5nKydyxSyc4f6R7CpeM9mDut29SuaJPksmFS2ZnBK/j9AoTwzJCX/k0PtDhcfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
    /// </summary>
    [DataContract]
    public class FmfDetails {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FmfDetails() {}

        /// <summary>
        /// The filter description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// REQUIRED
        /// The filter ID.
        /// </summary>
        [DataMember(Name="filter_id", EmitDefaultValue = false)]
        public string FilterId { get; set; }

        /// <summary>
        /// REQUIRED
        /// The filter type.
        /// </summary>
        [DataMember(Name="filter_type", EmitDefaultValue = false)]
        public string FilterType { get; set; }

        /// <summary>
        /// The filter name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }
    }
}

