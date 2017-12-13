// This class was generated on Wed, 13 Dec 2017 12:24:22 CST by version 0.1 of Braintree SDK Generator
// Search.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yYz3LbNhDG732KHfaSaGiqrftnqltbJzM+xOkkbi+2R14BSxMdEECxS6dMJ+/eAUnRdWXJdq1RDvIV3F18+wMG+MC/s9M2UDbL3hNGVWV59jtGgwtLJ1in8SzPjohVNEGMd9ksO3bX3igC7hIgYMSahCIXWZ79FCO2fcWv8uwdoX7rbJvNSrRMaeDPxkTS48Cv0QeKYoiz2dmoZeG9JXSrYtKM5pr0HaK0USjE8KEiqSiCeLCGBWqKqkInB8tcMH0DDMaBVASROHjHVMBxCZcSG7rMx8GuCIN3tt1Qqk/telqT27g1Sa6xdjUHrb2JeyLXNMOnfITLEo27WmVLNRq7Ava0IjDOiEELliStM/iy49YlAGodiXcm0um5ioRJ3Vyj0J2CyWlYRkGKgtLHTvPAtICjYbRGAcMwadu2nRxM3ryZHEy0nsDk4yQHZNBUGtctGpwdO6HoSLrk6ampCV53FS5eVCJhNp2K95YLQ1IWPl5NK6ntNJbq8PDwxy+ZVNJz8F3x/csd0tINbQalG9p3RkPH93Dab0YB25qcbGY0BO0Dq1+aGMmpdpWW9R8ozsUL2jnWvnGywutnZAK/+IOUdJjScV8ah06lc/YabZOuJYtCGkpDVjO8WKBFpyi/gdxQDiSqeLm1i3fdBlA3zd5u5HC4FGAZAcpr+vciLlo4fv8Wvv3m6x8etQLpHv5fm7WjtyK0XwhoQjIGJ6DNlRHAMklPe1STMjVaBqZkaCStya2NuOxh3NUYQvQhmrSnbzW/jS4vHtCna+oFxTUXdm/R+pAtb/xx3v/oCXh198Hgy5JJRnCDb4zEjRXeobg5m493K0xfIX3djch1KxpJmWDSIbto2Dhinrv05RGebCwByxKQSuy8gdJElieo7/I/j3SLT1Ke0ncpnAWjPMATd3HPrngkttEX97D23Bn3nO71xgOrfed0rz/uOe2RQ97ASxreaFz6kAJO/fImXrTDYA4cSJmyBakMD14ZGdABJu1F6h7oL6yDpRwuz4f5zrMZnJ1n7169/u3k6NXReXZxueV+1/616p8CKhnQeVwWfMAfrIqgS4UuNTlOwrj622pX75omhOd3zfO75mnvmotPX/wDAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Invoice search parameters.
    */
    [DataContract]
    public class Search {

        // Required default constructor
        public Search() {}

        /**
        * Indicates whether to list merchant-archived invoices in the response. If `true`, response lists only merchant-archived invoices. If `false`, response lists only unarchived invoices. If `null`, response lists all invoices.
        */
        [DataMember(Name="archived", EmitDefaultValue = false)]
        public bool Archived { get; set; }

        /**
        * The initial letters of the email address.
        */
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /**
        * The end creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="end_creation_date", EmitDefaultValue = false)]
        public string EndCreationDate { get; set; }

        /**
        * The end due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="end_due_date", EmitDefaultValue = false)]
        public string EndDueDate { get; set; }

        /**
        * The end date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="end_invoice_date", EmitDefaultValue = false)]
        public string EndInvoiceDate { get; set; }

        /**
        * The end payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="end_payment_date", EmitDefaultValue = false)]
        public string EndPaymentDate { get; set; }

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="lower_total_amount", EmitDefaultValue = false)]
        public Currency LowerTotalAmount { get; set; }

        /**
        * The invoice number.
        */
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /**
        * The offset for the search results.
        */
        [DataMember(Name="page", EmitDefaultValue = false)]
        public double Page { get; set; }

        /**
        * The page size for the search results.
        */
        [DataMember(Name="page_size", EmitDefaultValue = false)]
        public double PageSize { get; set; }

        /**
        * The initial letters of the recipient business name.
        */
        [DataMember(Name="recipient_business_name", EmitDefaultValue = false)]
        public string RecipientBusinessName { get; set; }

        /**
        * The initial letters of the recipient first name.
        */
        [DataMember(Name="recipient_first_name", EmitDefaultValue = false)]
        public string RecipientFirstName { get; set; }

        /**
        * The initial letters of the recipient last name.
        */
        [DataMember(Name="recipient_last_name", EmitDefaultValue = false)]
        public string RecipientLastName { get; set; }

        /**
        * The start creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="start_creation_date", EmitDefaultValue = false)]
        public string StartCreationDate { get; set; }

        /**
        * The start due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="start_due_date", EmitDefaultValue = false)]
        public string StartDueDate { get; set; }

        /**
        * The start date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="start_invoice_date", EmitDefaultValue = false)]
        public string StartInvoiceDate { get; set; }

        /**
        * The start payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="start_payment_date", EmitDefaultValue = false)]
        public string StartPaymentDate { get; set; }

        /**
        * The invoice status. To search by status, specify this value as an array. For example, `"status": ["REFUNDED"]`.
        */
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /**
        * Indicates whether the total count appears in the response.
        */
        [DataMember(Name="total_count_required", EmitDefaultValue = false)]
        public bool TotalCountRequired { get; set; }

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="upper_total_amount", EmitDefaultValue = false)]
        public Currency UpperTotalAmount { get; set; }
    }
}

