// This class was generated on Mon, 08 Jan 2018 16:45:12 CST by version 0.1 of Braintree SDK Generator
// Search.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yYS2/cNhDH7/0UA/WSLGS5rftA99bGCWAUcYrE7cU21rPkyGJBkSo5cqoU+e4F9fJqJW1T190e1sedBzX/H8nVjP6MLqqComX0jtCJLIqjX9EpXGs6xzzYozj6iar7H6fkhVMFK2uiZXRm7qwSBL7OhgId5sTkfBLF0Q/OYdUs/0UcvSWUb4yuomWK2lMw/F4qR7I3/OxsQY4V+Wh52Re2tlYTmnFl4YnqjuSgwg3jdqVSCWTy8D4jzsgBW9DKM+TkRIaGj7pcUI0qD8oAZwSOfGGNpwTOUrhhV9JN3BvrRTxYo6sdSzWptdCZ3NLMJJlS63EOan0f9y9hhyd8jHvinp0yt2PglKPSA9qdZYj6IiNQRrFCDZo4HAewaU2yTgCU0pHfW9lGroQjDNWtJDINJUx4x3LISOiiIERBal2tqN2DBE5ba44MysOiqqpqcbR4/XpxtJByAYsPixjQg6RUmXqT4fLMMDlDXCcfX6ic4FW9wvWzjLlYHh+ztdonijhNrLs9zjjXxy4VJycn33/uSYR6jr5Jvn2+R5aypGmMG45pgrKkQ4fXKp4GuOWcgXjYAAuscjI8DXDLOQ2wDToEkC9K58iIaoxS2/fkVmwZ9QpzWxoewJx0D3H+iJ7Arn8jwTXF8EJKlUEjwv/+HeoyvDg1MklIFWnp4dkaNRpB8f0elBQDsUieP1q/MHd4RMvihZXDgyPuIQ0VnrRvL+giQFhJm5u/ruDs3Rv4+qsvv/tHOxdaiAfdgBrroPrOMiy92TMoi9DlnINUt4oB0yAmnHZJQuWoPXgKLRuH7Rsc6U5Vfz+wKJwtnAq3Y4DjMXRff4JyU+ZrcgPpvWmq/Wj60ibkkW9V/9ytEgu8He5NaxiXZ9PUE/dw2+7ZkS81+z1Wu/Lqw7jkzjquO3ghePdT+txZcCRUocIf/br0ypD3KxM8m0LmYz65We2XgG4JCEvsXWSqnOddCgcBD5BX5/8/2jTulrbpf4CykL5PYZ7R8Y5pY9o/FlbHPU0cPbHJmWPkmuN44HNHw2l28ph0z6I8dIyz88ekew7jAc0gO3By6bcRNqb5hq4JSeDCdq3HumqNMfiChEor4Ez5dgJBD2gAg5wkAAH6A/NCUww3V+3zrqIlXF5Fb1+++uX89OXpVXR988gIZj9hNgOWCL36ynULbhKZCfjbT5sZQZ0KdWro3gnd+HvmvqbNsih2TZuT7qdp82na/I+mzeuPn/0FAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Invoice search parameters.
    /// </summary>
    [DataContract]
    public class Search {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Search() {}

        /// <summary>
        /// Indicates whether to list merchant-archived invoices in the response. If `true`, response lists only merchant-archived invoices. If `false`, response lists only unarchived invoices. If `null`, response lists all invoices.
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue = false)]
        public bool Archived { get; set; }

        /// <summary>
        /// The initial letters of the email address.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The end creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="end_creation_date", EmitDefaultValue = false)]
        public string EndCreationDate { get; set; }

        /// <summary>
        /// The end due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="end_due_date", EmitDefaultValue = false)]
        public string EndDueDate { get; set; }

        /// <summary>
        /// The end date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="end_invoice_date", EmitDefaultValue = false)]
        public string EndInvoiceDate { get; set; }

        /// <summary>
        /// The end payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="end_payment_date", EmitDefaultValue = false)]
        public string EndPaymentDate { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="lower_total_amount", EmitDefaultValue = false)]
        public Currency LowerTotalAmount { get; set; }

        /// <summary>
        /// The invoice number.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The offset for the search results.
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue = false)]
        public double Page { get; set; }

        /// <summary>
        /// The page size for the search results.
        /// </summary>
        [DataMember(Name="page_size", EmitDefaultValue = false)]
        public double PageSize { get; set; }

        /// <summary>
        /// The initial letters of the recipient business name.
        /// </summary>
        [DataMember(Name="recipient_business_name", EmitDefaultValue = false)]
        public string RecipientBusinessName { get; set; }

        /// <summary>
        /// The initial letters of the recipient first name.
        /// </summary>
        [DataMember(Name="recipient_first_name", EmitDefaultValue = false)]
        public string RecipientFirstName { get; set; }

        /// <summary>
        /// The initial letters of the recipient last name.
        /// </summary>
        [DataMember(Name="recipient_last_name", EmitDefaultValue = false)]
        public string RecipientLastName { get; set; }

        /// <summary>
        /// The start creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="start_creation_date", EmitDefaultValue = false)]
        public string StartCreationDate { get; set; }

        /// <summary>
        /// The start due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="start_due_date", EmitDefaultValue = false)]
        public string StartDueDate { get; set; }

        /// <summary>
        /// The start date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="start_invoice_date", EmitDefaultValue = false)]
        public string StartInvoiceDate { get; set; }

        /// <summary>
        /// The start payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="start_payment_date", EmitDefaultValue = false)]
        public string StartPaymentDate { get; set; }

        /// <summary>
        /// The invoice status. To search by status, specify this value as an array. For example, `"status": ["REFUNDED"]`.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the total count appears in the response.
        /// </summary>
        [DataMember(Name="total_count_required", EmitDefaultValue = false)]
        public bool TotalCountRequired { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="upper_total_amount", EmitDefaultValue = false)]
        public Currency UpperTotalAmount { get; set; }
    }
}

