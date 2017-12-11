// This class was generated on Mon, 11 Dec 2017 16:45:21 CST by version 0.1 of Braintree SDK Generator
// CancelNotification.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUQW/TQBCF7/yK0Z6ttBISh9yicCkSCSIVF0DRZD2uF9Y7zsyYyEL972jtpDQxFUIULpY86533zdu3/u5u+5bc3C0xeYqwYgtV8GiBkyvcB5SAu0grbPJHrnCvSb2Edlg/7VLABNRgiMACm7cbSI/azFzhFiLYj0rXhXtPWK5T7N28wqiUC/suCJUPhXfCLYkFUjf/+MCoJiHdTbG83w7qOuFbJMAsDVwBJ8p4DQvBcjkfgXUGNxX03AE3wcDqoNCiYENGApVwA1YTvNmsVyC070gNdlz2BeDZkBAUlJKBMWCMPwUAy1JIlRSsRgMUygKWiXLnkL5x8DSDtdUkh6BUgLbkQ9Vf0hhDDCMlTZszHOrg6ye4Zp+66+uXfhfZf913bDS8j0+vJpzuxsqKjeZj+epxHRZlGXJHjBPtPFNiA+3alsWoPKpdXcqdJ+HVnyYhdTHeF7+NQ2KjaRIyIWWbsnst9iR/G8wLnB1zJPzFrVFK5dZ425D4GpNN2G5SmY+LFA415RhkzLxrYD07ziP/qdX/HmHw7Rn4/4X/T8VBu90X8lPXb2uC49rpMj7nb2ug+3z/4gcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Cancels an email or SMS notification.
    */
    [DataContract]
    public class CancelNotification {

        // Required default constructor
        public CancelNotification() {}

        /**
        * An array of one or more CC: emails. If you omit this parameter from the JSON request body, a notification is sent to all CC: email addresses that are part of the invoice. Otherwise, specify this parameter to limit the email addresses to which a notification is sent.<blockquote><strong>Note:</strong> Additional email addresses are not supported.</blockquote>
        */
        [DataMember(Name="cc_emails")]
        public List<string> CcEmails { get; set; }

        /**
        * A note to the payer.
        */
        [DataMember(Name="note")]
        public string Note { get; set; }

        /**
        * Indicates whether to send the notification to the merchant.
        */
        [DataMember(Name="send_to_merchant")]
        public bool SendToMerchant { get; set; }

        /**
        * Indicates whether to send the notification to the payer.
        */
        [DataMember(Name="send_to_payer")]
        public bool SendToPayer { get; set; }

        /**
        * The subject of the notification.
        */
        [DataMember(Name="subject")]
        public string Subject { get; set; }
    }
}

