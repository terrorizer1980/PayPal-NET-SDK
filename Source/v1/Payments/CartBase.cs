// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// CartBase.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A cart.
    /// </summary>
    [DataContract]
    public class CartBase
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CartBase() {}

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
        /// The soft descriptor that is used when charging this funding source. Maximum length is 22 characters. If you include a value that is greater than 22 characters, the API truncates the string.
        /// </summary>
        [DataMember(Name="soft_descriptor", EmitDefaultValue = false)]
        public string SoftDescriptor;
    }
}

