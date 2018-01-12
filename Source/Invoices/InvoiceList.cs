// This class was generated on Mon, 08 Jan 2018 16:45:10 CST by version 0.1 of Braintree SDK Generator
// InvoiceList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6ySQevTQBDF736KYc/hjycPuQUVFIsVLV5Emulm2ozdzMbZSTFIv7skaWNjexE97hvYeb9576fb9C253LGcInvaBk7mMvcZlXEX6D02w9Rl7h31vx+vKHnl1jiKy92Kk0HcQ0PqaxSDy2fpCV6iAIsPXUVgNYFFwzDPwcdODFAqeFNsXq+LTxBYjgn2UUHwxAccVjy5zBWq2E9en2fuI2G1ltC7fI8h0SB871ipmoUPGltSY0ou/zJTvp0W3wNeHS1Ab8QlcCGAg58BembBBIlQfQ1KqQv2h+sXf+tauhDO2Wx9xXKEGxuw3n0j/yCr8YILjquyhNjU9ODqpdAPK8dIylbpxLFL5U0WwDIGOTFCov/NyWJ0IL3nGquzHRuzoFvq94xT5aRrdqSLwKxGgwbN1yPRJTyvbKSM/1q6Eevr+dkvAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// List of merchant invoices. Can include the total invoices count and HATEOAS links for navigation.
    /// </summary>
    [DataContract]
    public class InvoiceList {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public InvoiceList() {}

        /// <summary>
        /// An array of invoices as search result.
        /// </summary>
        [DataMember(Name="invoices", EmitDefaultValue = false)]
        public List<Invoice> Invoices { get; set; }

        /// <summary>
        /// The HATEOAS links for `next` and `previous` navigation in the result set.
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The total number of invoices that match the search criteria.
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue = false)]
        public int? TotalCount { get; set; }
    }
}

