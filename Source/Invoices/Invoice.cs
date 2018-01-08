// This class was generated on Mon, 08 Jan 2018 16:45:10 CST by version 0.1 of Braintree SDK Generator
// Invoice.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Invoice details.
    /// </summary>
    [DataContract]
    public class Invoice {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Invoice() {}

        /// <summary>
        /// Indicates whether the invoice allows a partial payment. If `false`, invoice must be paid in full. If `true`, the invoice allows partial payments.
        /// </summary>
        [DataMember(Name="allow_partial_payment", EmitDefaultValue = false)]
        public bool AllowPartialPayment { get; set; }

        /// <summary>
        /// Indicates whether the invoice enables the customer to enter a tip amount during payment. If `true`, the invoice shows a tip amount field so that the customer can enter a tip amount. If `false`, the invoice does not show a tip amount field.
        /// </summary>
        [DataMember(Name="allow_tip", EmitDefaultValue = false)]
        public bool AllowTip { get; set; }

        /// <summary>
        /// List of files that are attached to the invoice.
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue = false)]
        public List<FileAttachment> Attachments { get; set; }

        /// <summary>
        /// The required invoice recipient email address and any optional billing information. Supports only one recipient.
        /// </summary>
        [DataMember(Name="billing_info", EmitDefaultValue = false)]
        public List<BillingInfo> BillingInfo { get; set; }

        /// <summary>
        /// For invoices sent by email, one or more email addresses to which to send a CC: copy of the notification. Supports only email addresses under participant.
        /// </summary>
        [DataMember(Name="cc_info", EmitDefaultValue = false)]
        public List<Participant> CcInfo { get; set; }

        /// <summary>
        /// The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue = false)]
        public CustomAmount Custom { get; set; }

        /// <summary>
        /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue = false)]
        public Cost Discount { get; set; }

        /// <summary>
        /// The ID of the invoice.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The date when the invoice was enabled. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// The items to include in the invoice. An invoice can contain a maximum of 100 items.
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue = false)]
        public List<InvoiceItem> Items { get; set; }

        /// <summary>
        /// The HATEOAS links that provide related actions for the invoice based on the current invoice status.
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The full URL to an external logo image.
        /// </summary>
        [DataMember(Name="logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// REQUIRED
        /// Merchant business information that appears on the invoice.
        /// </summary>
        [DataMember(Name="merchant_info", EmitDefaultValue = false)]
        public MerchantInformation MerchantInfo { get; set; }

        /// <summary>
        /// A private bookkeeping memo for the merchant.
        /// </summary>
        [DataMember(Name="merchant_memo", EmitDefaultValue = false)]
        public string MerchantMemo { get; set; }

        /// <summary>
        /// Audit information for the resource.
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue = false)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="minimum_amount_due", EmitDefaultValue = false)]
        public Currency MinimumAmountDue { get; set; }

        /// <summary>
        /// A note to the payer.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The unique invoice number. If you omit this number, it is auto-incremented from the previous invoice number.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The payment and refund summary.
        /// </summary>
        [DataMember(Name="paid_amount", EmitDefaultValue = false)]
        public PaymentSummary PaidAmount { get; set; }

        /// <summary>
        /// The payment term of the invoice. If you specify `term_type`, you cannot specify `due_date`, and vice versa.
        /// </summary>
        [DataMember(Name="payment_term", EmitDefaultValue = false)]
        public PaymentTerm PaymentTerm { get; set; }

        /// <summary>
        /// List of payment details for the invoice.
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue = false)]
        public List<PaymentDetail> Payments { get; set; }

        /// <summary>
        /// Reference data, such as PO number, to add to the invoice.
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The payment and refund summary.
        /// </summary>
        [DataMember(Name="refunded_amount", EmitDefaultValue = false)]
        public PaymentSummary RefundedAmount { get; set; }

        /// <summary>
        /// List of refund details for the invoice.
        /// </summary>
        [DataMember(Name="refunds", EmitDefaultValue = false)]
        public List<RefundDetail> Refunds { get; set; }

        /// <summary>
        /// The shipping cost, as a percentage or amount value.
        /// </summary>
        [DataMember(Name="shipping_cost", EmitDefaultValue = false)]
        public ShippingCost ShippingCost { get; set; }

        /// <summary>
        /// The shipping information for the invoice recipient.
        /// </summary>
        [DataMember(Name="shipping_info", EmitDefaultValue = false)]
        public ShippingInfo ShippingInfo { get; set; }

        /// <summary>
        /// The invoice status. When you [search for invoices](/docs/api/invoicing/#invoices_search), you must specify this value as an array. For example, `"status": ["REFUNDED"]`.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the tax is calculated before or after a discount. If `false`, the tax is calculated before a discount. If `true`, the tax is calculated after a discount.
        /// </summary>
        [DataMember(Name="tax_calculated_after_discount", EmitDefaultValue = false)]
        public bool TaxCalculatedAfterDiscount { get; set; }

        /// <summary>
        /// Indicates whether the unit price includes tax.
        /// </summary>
        [DataMember(Name="tax_inclusive", EmitDefaultValue = false)]
        public bool TaxInclusive { get; set; }

        /// <summary>
        /// The ID of the template from which to create the invoice. Useful for copy functionality.
        /// </summary>
        [DataMember(Name="template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The general terms of the invoice.
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue = false)]
        public string Terms { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="total_amount", EmitDefaultValue = false)]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// The URI of the invoice.
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue = false)]
        public string Uri { get; set; }
    }
}

