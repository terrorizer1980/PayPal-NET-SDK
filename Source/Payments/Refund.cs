// This class was generated on Mon, 11 Dec 2017 13:16:27 CST by version 0.1 of Braintree SDK Generator
// Refund.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xYTW8bNxO+v79isLkkhqR1XrcpqpuBtKgPbYzaCFC4hjAiZ7WsueRmOLQsFPnvBfdDkaV14zSOmgI6LcgZzj7kM1/kn9nlqqZsmjEV0elslL1FNji39AtWaT4bZa8pKDa1GO+yaXYKrSoIowuo0vQkG2WnzLhqjR2Psl8J9RtnV9m0QBsoTbyLhkmvJ87Z18RiKGTTqzUMrHx0sgtjPX8fzGVJUOOqIifQqoxgaaSEORPejGMdng5aEDZusQtNRWZyajUI7kpKJhqrEhmVEMPZxZvxN/9/+R30y0B5TdfPc+1VyI0TWjAmA7k2TEpypiB5rzxOyiF/MYFzXJ2jBe0pgPMCIda1ZwG0tjdt6NN2Lxy3Nu+ite9HW+TMNAkaG3ZP4oNg9yBQa5OGCXOrBjj3UUB2KPzylC1MIbMlYz0INUkhSaEgmsDPeGeqWIElt5ASTICXx7AmNIxgWRpVgnHKRk1h+ns8Pj5R0TZfakfWtKMLuiUH2iyMBJhT4ZmaA9CkTIUWam+cTNo1eb/ovonLT1Rf+v5/WCQHfOTv8n4Dn0nGlgs9xEiJTlvjFrOCaJCUXuHASYLcBjtpKHy7uksHfSBVJKXX4J1dTfZDoHEhMjo1zN5aeqDvHn2JoL/ncE/0hdLUdSvZZa8XHsjbWz7sj3ymTVAPtj6bxECveQivry87hjgXL2iHWeyEXfuzRm2EqjCBs6IZMb2LFGTNGljjOp0RSGkC1C2uVSL86Ig72EdHh5DdC8eCd4P0Ct4dGHgCBq4fw8GDQXYvwtLBL0iD+P76QQTz1XrAE/jRc3fRDSNgqpkCOQmNSmdFSpSN9Z12b9SzWRjXZp1k8OABn3sRfYwDKKwlMs2MHvSCs9fg23Qa0NLmEwbMKRXSlkTaV9ulmFBoJqYa7ps1CgE6DUkDliW5rhY0LzBLDNBa0CMwDq7OnBA7kq11hecK5fp5KVKHaZ6L9zZMDEkx8bzIS6lszoU6OTn5/lmg5jjG305evdjTIeiNbQ8dQrfbDbV93Wk+5kRP/xL26NvWrTeKZi5Wc+IdlL/5yOCXDjo9SB0Fo7pJLn72GtplE3iLNlJKRQjtn9LGgnELS+P5KrmQrUt0sSI2aiNZPfEurXE3sw16Z37+B6mBV8CkuPu8dOoAE5gEvuuSxkw2hQVc/XR6+cOb0wtolvbPbFib3N8S3xpa5s9KFPIYxo3KttO/+kIM1sjkZNa1pB/xs75x9a6rEk2/t5m9TIA5hr3lLSYMD0ZrEn0ojtso/400m5L9f6UkBEEZLgaN5H7q2ROmWOt/VqaCj6yoKVQWg0Br6CuuVtfv//cXAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * A refund transaction.
    */
    [DataContract]
    public class Refund {

        // Required default constructor
        public Refund() {}

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
        * The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }
    }
}

