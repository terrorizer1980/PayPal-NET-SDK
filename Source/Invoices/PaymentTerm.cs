// This class was generated on Wed, 13 Dec 2017 12:24:20 CST by version 0.1 of Braintree SDK Generator
// PaymentTerm.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6ySwWsVMRDG7/4VQ7zosm9XeCi4N6EIPVSLLF5KafM2k2Zgk6yTyStR+r9LtroKPvRgb2G++Sbz+5JvaiwLqkFd6uIxCIzIXrXqs2bShxk/aF9V1aozTBPTIhSDGtToEJYfFkH2EC2IQ6BwjDRhB+cWSsyQFpzIFritTTdSFrxtV2HSIUT5pZuMN0ZLlXUwcKQJ4YicdKda9Y5Zl8dFX7XqE2rzMcxFDVbPCWvhSyZGsxUuOS7IQpjUcLUhJmEKd3/C/bz6JGQV4N5h+B1vQ6cEJmMHo6un2upzEjggaLBZMj8O6OCsajay16upKaWUZtdcXDS7xpgGmq9NCzqBQUsBDVCAq/MgyAFlNfcjeYT364TrF05kGfpeYpxTRyi2i3zXO/Fzz3ba7/dvnyecKsbudffm5f9mGPI8P7T/DHJ745NJrt/kUODe0eT+luZTLHv98Ow7AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The payment term of the invoice. If you specify `term_type`, you cannot specify `due_date`, and vice versa.
    */
    [DataContract]
    public class PaymentTerm {

        // Required default constructor
        public PaymentTerm() {}

        /**
        * The date when the invoice payment is due. This date must be a future date. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="due_date", EmitDefaultValue = false)]
        public string DueDate { get; set; }

        /**
        * The term by which the invoice payment is due.
        */
        [DataMember(Name="term_type", EmitDefaultValue = false)]
        public string TermType { get; set; }
    }
}

