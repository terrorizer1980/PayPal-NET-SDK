// This class was generated on Mon, 11 Dec 2017 13:16:23 CST by version 0.1 of Braintree SDK Generator
// Transaction.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment.
    */
    [DataContract]
    public class Transaction {

        // Required default constructor
        public Transaction() {}

        /**
        * REQUIRED
        * The payment amount, with break-ups.
        */
        [DataMember(Name="amount")]
        public Amount Amount { get; set; }

        /**
        * A free-form field for the client's use.
        */
        [DataMember(Name="custom")]
        public string Custom { get; set; }

        /**
        * The description of the purchase.
        */
        [DataMember(Name="description")]
        public string Description { get; set; }

        /**
        * The invoice number to track this payment.
        */
        [DataMember(Name="invoice_number")]
        public string InvoiceNumber { get; set; }

        /**
        * An array of items that are being purchased.
        */
        [DataMember(Name="item_list")]
        public ItemList ItemList { get; set; }

        /**
        * Optional. A note to the recipient of the funds in this transaction.
        */
        [DataMember(Name="note_to_payee")]
        public string NoteToPayee { get; set; }

        /**
        * The URL to send payment notifications.
        */
        [DataMember(Name="notify_url")]
        public string NotifyUrl { get; set; }

        /**
        * The URL on the merchant site related to this payment.
        */
        [DataMember(Name="order_url")]
        public string OrderUrl { get; set; }

        /**
        * The payee who receives the funds and fulfills the order.
        */
        [DataMember(Name="payee")]
        public Payee Payee { get; set; }

        /**
        * The payment options requested for this transaction.
        */
        [DataMember(Name="payment_options")]
        public PaymentOptions PaymentOptions { get; set; }

        /**
        * The purchase order number or ID. Identifies this payment.
        */
        [DataMember(Name="purchase_order")]
        public string PurchaseOrder { get; set; }

        /**
        * Optional. The merchant-provided ID for the purchase unit.
        */
        [DataMember(Name="reference_id")]
        public string ReferenceId { get; set; }

        /**
        * An array of payment-related transactions. A transaction defines what the payment is for and who fulfills the payment.
        */
        [DataMember(Name="related_resources")]
        public List<RelatedResources> RelatedResources { get; set; }

        /**
        * The soft descriptor that is used when charging this funding source. Maximum length is 22 characters. If you include a value that is greater than 22 characters, the API truncates the string.
        */
        [DataMember(Name="soft_descriptor")]
        public string SoftDescriptor { get; set; }
    }
}

