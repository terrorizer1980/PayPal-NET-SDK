// This class was generated on Mon, 11 Dec 2017 13:16:19 CST by version 0.1 of Braintree SDK Generator
// DetailedRefund.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xZX2/bNhB/36c4uA9rA9lKl63D8hagG5aHNcESFBiyQD2TJ4srRarHYxxj6HcfqD+OEzttuqZGN/jJkO5I/Xi/+8fz36PzRUOjw5EmQWNJF0xldHqUjV4jG5xaeoV1Uhhlo5cUFJtGjHejw9F5RdApgzC6gCoJoNsogFQogJx0JLIjDdMFSEXw5vTk7BzybukbUGjtZJSNjphx0YHZz0a/E+oTZxejwxJtoPTiXTRMevnilH1DLIbC6PBieQysfXSyjn75fv0MDS5qcgKdSgZzIxVMmfDtODbh8aAFYeNm69BUZCanFhvBXUjFRGNVIaMSYjg+Oxl//93zH2FYBsprunyaa69CbpzQjDFtkGvDpCRnCpIPyuOkHPJnEzjFxSla0J4COC8QYtN4FkBrh60NfdrpheOdw7to7fvsDjlF7yHrlrgRrBsCtTbpMWHuPQynPkrrUrcp/PKUzUwpxZyx2Qg1SSFJoSSawG94bepYgyU3kwpMgOf7sCQ0ZDCvjKrAOGWjpnD4Z9zfP1DRtr/UPVnTPZ3RFTnQZmYkwJRKz9QaQJMyNVpovHEy6dbkw6LbW5x/ovrcD9/DMjngAz+XDwf4TDLuuNB9jFTotDVuVpREG0kZFHacJMhdsJOG0ner+3QwBFJNUnkN3tnFZDsEGhcio1Ob2VtKd/Tdoi8R9GEOt0RfqEzTdJJ19gbhjryt5cPB5IU2Qd3b+qwSA4PmLry+vuwY4lS8oN3MYi/s258laiNUhwkcl+0T07tIQZasgTWu18lAKhOg6XAtEuF7e9zD3tvbhexWOBa83kiv4PWOgUdg4PIhHNwbZLciLBl+RhrED9cPouF6mx54Ar947m/HIQOmhimQk9Cq9Lu0N+Sb9b32sKlnMzOuyzppw50HfO5F9CEOoLCRyFQYvdELjl+C79JpQEu35h5TSoW0I5G21XYpJhQqxNSb+2aNQoBOQ9KAeUWurwXt2GaOAboddAbGwcWxE2JHcmdd6blGuXxaiTThMM/FexsmhqSceJ7lldQ251IdHBz89CRQa47xD5MXz7ZlhBjE12vnP4KSicYJPJSG7E05V9akWPwWYqAtYdQr0D4wSFtR29a962OOvj7i29qN8MobRYWL9ZR4DeUfPjL4uYNeDxK5jOptCsPjl9Atm8BrtJFSukTovpQOFoybWRpPF8nNbVOhizWxUSsJ9ZFPaY17W6zQW/jpX6Q2TCqT4voI7MgBJjAJfN/JjZlsCl24+PXo/OeTozNolw6jQGxM7q+IrwzN8ycVCnkM41blbmC++EIMNsjkpOjb5o/42dBce9dXsrYnXc2wJsAUw9ZyKxOGe6M1iW4K+F2UX7IUrIyL1wCnDxYl+7pgUmSuSBcfGHwnY96MkTt/bHMkWgulceiUQQtXKYCWztZm0tD1N3SNdWMpgyladIqyJYk6UtbWj+Dh8xPGbob+cW9tWdo8Oe//14hNai33Xu3d34gFapBRPGeAATSVxpHuOoPeZJ9qpGXNxSZdL9mkxuKW2SeP3Nk9LD5WIvbekfEuPnbx8f+Lj3tHTGj/M9eeICibyWwlt1vXrdXfdkRQDKbYVd5dZtlllvQ+NvrfDSmCj6yoHVNYDALdRl/xrOLy/Tf/AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The refund transaction details that are returned by the `POST /refund` call.
    */
    [DataContract]
    public class DetailedRefund {

        // Required default constructor
        public DetailedRefund() {}

        /**
        * The payment amount, with break-ups.
        */
        [DataMember(Name="amount")]
        public Amount Amount { get; set; }

        /**
        * The ID of the sale transaction being refunded.
        */
        [DataMember(Name="capture_id")]
        public string CaptureId { get; set; }

        /**
        * The date and time when the refund was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * A free-form field for the clients' use.
        */
        [DataMember(Name="custom")]
        public string Custom { get; set; }

        /**
        * The refund description.
        */
        [DataMember(Name="description")]
        public string Description { get; set; }

        /**
        * The ID of the refund transaction.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * Your own invoice or tracking ID number. Value is a string of single-byte alphanumeric characters.
        */
        [DataMember(Name="invoice_number")]
        public string InvoiceNumber { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The ID of the payment on which this transaction is based.
        */
        [DataMember(Name="parent_payment")]
        public string ParentPayment { get; set; }

        /**
        * The reason that the transaction is being refunded.
        */
        [DataMember(Name="reason")]
        public string Reason { get; set; }

        /**
        * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="refund_from_received_amount")]
        public Currency RefundFromReceivedAmount { get; set; }

        /**
        * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="refund_from_transaction_fee")]
        public Currency RefundFromTransactionFee { get; set; }

        /**
        * The ID of the sale transaction being refunded.
        */
        [DataMember(Name="sale_id")]
        public string SaleId { get; set; }

        /**
        * The state of the refund.
        */
        [DataMember(Name="state")]
        public string State { get; set; }

        /**
        * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="total_refunded_amount")]
        public Currency TotalRefundedAmount { get; set; }

        /**
        * The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }
    }
}

