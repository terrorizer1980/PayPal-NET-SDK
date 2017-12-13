// This class was generated on Wed, 13 Dec 2017 12:24:23 CST by version 0.1 of Braintree SDK Generator
// Notification.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTQYvbQAyF7/0VYs4mu1DowbewvWyhSWmWXtoSlLG8nnY8ciS5wZT972XsZLuJt5TSvQQiMe99kp9+uruhI1e6FVuog0cLnFzhPqEE3EVaYZu7rnBvSb2EbuyX7q4hoBZDBBbYvN9AevJ+4Qq3FMFh0r4u3EfCap3i4Moao1Iu7PsgVD0WPgh3JBZIXfn5kUpNQrqf83i/Hd11BrZMgNkauAZOlPFaFoKbm3IC1gXc1jBwD9wGA2uCQoeCLRkJ1MItWEPwbrNegdC+JzXYcTUUgGdDQlBQSgbGgDH+NgCsKiFVUrAGDVAoG1gmysoh/eDgaQFra0gOQakA7ciHerikMYYYJkqaizMcmuCbMyod7TLX4kt/ff3a7yL77/uejcb/069XE073U2XFRuVUvnpah2VVhayJceadTRIbaN91LEbV0e3q0u48CW/+NQmpj/Gh+GscEhvNk5AJKa8pb6/DgeR/g3mBs2OOhM+ci1KqtsbblsQ3mGzGdpuq/MFI4dBQjkHGzK8AwXM3nLIy7f04wknthaf401K1330jb8+e/rF3wnzJ4x/pvj68+gUAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The email or SMS notification.
    */
    [DataContract]
    public class Notification {

        // Required default constructor
        public Notification() {}

        /**
        * An array of one or more CC: emails. If you omit this parameter from the JSON request body, a notification is sent to all CC: email addresses that are part of the invoice. Otherwise, specify this parameter to limit the email addresses to which notifications are sent.<blockquote><strong>Note:</strong> Additional email addresses are not supported.</blockquote>
        */
        [DataMember(Name="cc_emails", EmitDefaultValue = false)]
        public List<string> CcEmails { get; set; }

        /**
        * A note to the payer.
        */
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /**
        * Indicates whether to send a copy of the email to the merchant.
        */
        [DataMember(Name="send_to_merchant", EmitDefaultValue = false)]
        public bool SendToMerchant { get; set; }

        /**
        * The subject of the notification.
        */
        [DataMember(Name="subject", EmitDefaultValue = false)]
        public string Subject { get; set; }
    }
}

