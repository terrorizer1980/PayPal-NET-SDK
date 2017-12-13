// This class was generated on Wed, 13 Dec 2017 14:31:48 CST by version 0.1 of Braintree SDK Generator
// Refund.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xYzW4bNxC+9ykGm0tiSFqnbhNUNwNuUR9aG7XRi2sII3JWy5pLboazloUi715wfxRZWjVO42xTQCdhOT/6ON/McMi/kutVSck0Ycoqp5NR8juywbmlX7GI68koOaOg2JRivEumySk0qiCMLqCKy5NklJwy46pxdjxKfiPUF86ukmmGNlBceFcZJr1euGRfEouhkExv1jCw8JWTXRjr9cdgrnOCElcFOYFGZQRLIznMmfBuXJXh+aAFYeMWu9BUxUxOrXrB3UjORGOVI6MSYji/uhh/9+3rt9CZgfKabl+m2quQGie0YIwOUm2YlKRMQdJOeRyVQ/pqApe4ukQL2lMA5wVCVZaeBdDazrWhT9u9cLW1eVdZ+360Rc5Mk6CxYTcSHwS7gUCtTfyMmBs1wLmvBGSHwi9P2cJkMlsylr1QoxSiFDKiCfyCD6aoCrDkFpKDCfD6GNaEhhEsc6NyME7ZSlOY/lEdH5+oyta/1HxZ03xd0T050GZhJMCcMs9UB0CTMgVaKL1xMmls0s7osYvrT1Rf+u7/MIsJ+MS/S7sNfCYZWym0j5EcnbbGLWYZUS8pncKBkwi5KXbSkPnGum0HXSEVJLnX4J1dTYYh0LhQMTrVz95aeqDvEX2RoH/mcCD6Qm7KspHsstcJD+QN1g+7kM+0CWrv6LNJDHSah/L6+rpjqObiBW0/i62wHX/WqI1QESZwntVfTO8qCrJmDaxxrc4IJDcBygbXKhJ+dMQt7KOjQ8kOwrHgQy+9gg8HBp6BgduncLC3yB5VWAz8gjSI764fRDBfrT94Aj95bi+6YQRMJVMgJ6FWab1IjrJh32p3Tj2bhXFN14kODxnwuRfRpySAwlIqppnRvVlwfga+aacBLW0+YcCc4kHakEhDjV2KCYVmYor+uVmjEKDTEDVgmZNrz4L6BWaJARoPegTGwc25E2JHsmWXeS5Qbl/mImWYpql4b8PEkGQTz4s0l8KmnKmTk5MfXgSqwzH+fvLm1UBB0Bvb7gtCu9sNtaHuNB9Lop6XsL46f7tR54Ndx+69UTRzVTEn3nMnq1UgThuM6i6m//kZNBbPDNMadzfbIHDm53+S6nnni4q7D0inDjCCiXFv56Axk42JDzc/n17/eHF6BbVp95CGpUn9PfG9oWX6Ikchj2Fcq2yn9ZsvREGJTE5m7dD5kUzqRlPv2nOgnug2+5MJMMcwWGdiwrC3HqPow/G3jfK/aKSxnf9fmn4QlP52X0seN5eBMFWl/ncHUfAVK6qPIotBoHH0FZ9Ht++/+RsAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A refund transaction.
    /// </summary>
    [DataContract]
    public class Refund {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Refund() {}

        /// <summary>
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The ID of the sale transaction being refunded.
        /// </summary>
        [DataMember(Name="capture_id", EmitDefaultValue = false)]
        public string CaptureId { get; set; }

        /// <summary>
        /// The date and time when the refund was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The refund description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the refund transaction. Maximum length is 17 characters.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The invoice or tracking ID number.
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [DataMember(Name="parent_payment", EmitDefaultValue = false)]
        public string ParentPayment { get; set; }

        /// <summary>
        /// The reason that the transaction is being refunded.
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// The ID of the sale transaction being refunded.
        /// </summary>
        [DataMember(Name="sale_id", EmitDefaultValue = false)]
        public string SaleId { get; set; }

        /// <summary>
        /// The state of the refund.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }
    }
}

