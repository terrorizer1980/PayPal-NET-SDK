// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// SearchResponse.cs
// @version 0.1.0-dev+27d306
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// The search response information.
    /// </summary>
    [DataContract]
    public class SearchResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SearchResponse() {}

        /// <summary>
        /// The merchant account number.
        /// </summary>
        [DataMember(Name="account_number", EmitDefaultValue = false)]
        public string AccountNumber;

        /// <summary>
        /// The end date and time or the last date when the data can be served, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue = false)]
        public string EndDate;

        /// <summary>
        /// The date and time when the data was last refreshed, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="last_refreshed_datetime", EmitDefaultValue = false)]
        public string LastRefreshedDatetime;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;

        /// <summary>
        /// A zero-relative index of transactions.
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue = false)]
        public int? Page;

        /// <summary>
        /// The start date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue = false)]
        public string StartDate;

        /// <summary>
        /// The total number of transactions as an integer beginning with the specified `page` in the full result and not just in this response.
        /// </summary>
        [DataMember(Name="total_items", EmitDefaultValue = false)]
        public int? TotalItems;

        /// <summary>
        /// The total number of pages, as an `integer`, when the `total_items` is divided into pages of the specified `page_size`.
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue = false)]
        public int? TotalPages;

        /// <summary>
        /// An array of transaction detail objects.
        /// </summary>
        [DataMember(Name="transaction_details", EmitDefaultValue = false)]
        public List<TransactionDetails> TransactionDetails;
    }
}

