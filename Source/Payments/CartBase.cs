// This class was generated on Wed, 13 Dec 2017 14:31:51 CST by version 0.1 of Braintree SDK Generator
// CartBase.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A cart.
    /// </summary>
    [DataContract]
    public class CartBase {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public CartBase() {}

        /// <summary>
        /// REQUIRED
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// A free-form field for the client's use.
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue = false)]
        public string Custom { get; set; }

        /// <summary>
        /// The description of the purchase.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The invoice number to track this payment.
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// An array of items that are being purchased.
        /// </summary>
        [DataMember(Name="item_list", EmitDefaultValue = false)]
        public ItemList ItemList { get; set; }

        /// <summary>
        /// Optional. A note to the recipient of the funds in this transaction.
        /// </summary>
        [DataMember(Name="note_to_payee", EmitDefaultValue = false)]
        public string NoteToPayee { get; set; }

        /// <summary>
        /// The URL to send payment notifications.
        /// </summary>
        [DataMember(Name="notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// The URL on the merchant site related to this payment.
        /// </summary>
        [DataMember(Name="order_url", EmitDefaultValue = false)]
        public string OrderUrl { get; set; }

        /// <summary>
        /// The payee who receives the funds and fulfills the order.
        /// </summary>
        [DataMember(Name="payee", EmitDefaultValue = false)]
        public Payee Payee { get; set; }

        /// <summary>
        /// The payment options requested for this transaction.
        /// </summary>
        [DataMember(Name="payment_options", EmitDefaultValue = false)]
        public PaymentOptions PaymentOptions { get; set; }

        /// <summary>
        /// The purchase order number or ID. Identifies this payment.
        /// </summary>
        [DataMember(Name="purchase_order", EmitDefaultValue = false)]
        public string PurchaseOrder { get; set; }

        /// <summary>
        /// Optional. The merchant-provided ID for the purchase unit.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The soft descriptor that is used when charging this funding source. Maximum length is 22 characters. If you include a value that is greater than 22 characters, the API truncates the string.
        /// </summary>
        [DataMember(Name="soft_descriptor", EmitDefaultValue = false)]
        public string SoftDescriptor { get; set; }
    }
}

