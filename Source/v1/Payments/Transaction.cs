// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Transaction.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment.
    /// </summary>
    [DataContract]
    public class Transaction
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Transaction() {}

        /// <summary>
        /// REQUIRED
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount;

        /// <summary>
        /// A free-form field for the client's use.
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue = false)]
        public string Custom;

        /// <summary>
        /// The description of the purchase.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The invoice number to track this payment.
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber;

        /// <summary>
        /// An array of items that are being purchased.
        /// </summary>
        [DataMember(Name="item_list", EmitDefaultValue = false)]
        public ItemList ItemList;

        /// <summary>
        /// Optional. A note to the recipient of the funds in this transaction.
        /// </summary>
        [DataMember(Name="note_to_payee", EmitDefaultValue = false)]
        public string NoteToPayee;

        /// <summary>
        /// The URL to send payment notifications.
        /// </summary>
        [DataMember(Name="notify_url", EmitDefaultValue = false)]
        public string NotifyUrl;

        /// <summary>
        /// The URL on the merchant site related to this payment.
        /// </summary>
        [DataMember(Name="order_url", EmitDefaultValue = false)]
        public string OrderUrl;

        /// <summary>
        /// The payee who receives the funds and fulfills the order.
        /// </summary>
        [DataMember(Name="payee", EmitDefaultValue = false)]
        public Payee Payee;

        /// <summary>
        /// The payment options requested for this transaction.
        /// </summary>
        [DataMember(Name="payment_options", EmitDefaultValue = false)]
        public PaymentOptions PaymentOptions;

        /// <summary>
        /// The purchase order number or ID. Identifies this payment.
        /// </summary>
        [DataMember(Name="purchase_order", EmitDefaultValue = false)]
        public string PurchaseOrder;

        /// <summary>
        /// Optional. The merchant-provided ID for the purchase unit.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId;

        /// <summary>
        /// An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment.
        /// </summary>
        [DataMember(Name="related_resources", EmitDefaultValue = false)]
        public List<RelatedResources> RelatedResources;

        /// <summary>
        /// The soft descriptor that is used when charging this funding source. Maximum length is 22 characters. If you include a value that is greater than 22 characters, the API truncates the string.
        /// </summary>
        [DataMember(Name="soft_descriptor", EmitDefaultValue = false)]
        public string SoftDescriptor;
    }
}

