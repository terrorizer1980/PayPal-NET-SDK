// This class was generated on Mon, 11 Dec 2017 13:16:17 CST by version 0.1 of Braintree SDK Generator
// FmfDetails.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yRwUoDMRCG7z7FMqcWVuN5b0IJeKiKFi+llHEzWQeS7DpJDov03SWslIKyIhVPgfmH/N/HvMNmHAgasN7uDSVkF6GGZxTGF0d36EsINawotsJD4j5AA5tXqrZaMJtqjQE78hRSpdklkmqh13q5WyjTt1G1DmPkVllvFYdEnWD547LLbEjptX7K3qOMall91l9BDTciOE5k1zU8Epr74EZoLLpIZfCWWcgcBw/SDySJKUKzPTrFJBy6rzrmxOU7Mzt5nKydyxSyc4f6R7CpeM9mDut29SuaJPksmFS2ZnBK/j9AoTwzJCX/k0PtDhcfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
    */
    [DataContract]
    public class FmfDetails {

        // Required default constructor
        public FmfDetails() {}

        /**
        * The filter description.
        */
        [DataMember(Name="description")]
        public string Description { get; set; }

        /**
        * REQUIRED
        * The filter ID.
        */
        [DataMember(Name="filter_id")]
        public string FilterId { get; set; }

        /**
        * REQUIRED
        * The filter type.
        */
        [DataMember(Name="filter_type")]
        public string FilterType { get; set; }

        /**
        * The filter name.
        */
        [DataMember(Name="name")]
        public string Name { get; set; }
    }
}

