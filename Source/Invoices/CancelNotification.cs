// This class was generated on Wed, 13 Dec 2017 14:32:24 CST by version 0.1 of Braintree SDK Generator
// CancelNotification.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUQW/TQBCF7/yK0Z6ttBISh9yicCkSCSIVF0DRZD2uF9Y7zsyYyEL972jtpDQxFUIULpY86533zdu3/u5u+5bc3C0xeYqwYgtV8GiBkyvcB5SAu0grbPJHrnCvSb2Edlg/7VLABNRgiMACm7cbSI/azFzhFiLYj0rXhXtPWK5T7N28wqiUC/suCJUPhXfCLYkFUjf/+MCoJiHdTbG83w7qOuFbJMAsDVwBJ8p4DQvBcjkfgXUGNxX03AE3wcDqoNCiYENGApVwA1YTvNmsVyC070gNdlz2BeDZkBAUlJKBMWCMPwUAy1JIlRSsRgMUygKWiXLnkL5x8DSDtdUkh6BUgLbkQ9Vf0hhDDCMlTZszHOrg6ye4Zp+66+uXfhfZf913bDS8j0+vJpzuxsqKjeZj+epxHRZlGXJHjBPtPFNiA+3alsWoPKpdXcqdJ+HVnyYhdTHeF7+NQ2KjaRIyIWWbsnst9iR/G8wLnB1zJPzFrVFK5dZ425D4GpNN2G5SmY+LFA415RhkzLxrYD07ziP/qdX/HmHw7Rn4/4X/T8VBu90X8lPXb2uC49rpMj7nb2ug+3z/4gcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Cancels an email or SMS notification.
    /// </summary>
    [DataContract]
    public class CancelNotification {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CancelNotification() {}

        /// <summary>
        /// An array of one or more CC: emails. If you omit this parameter from the JSON request body, a notification is sent to all CC: email addresses that are part of the invoice. Otherwise, specify this parameter to limit the email addresses to which a notification is sent.<blockquote><strong>Note:</strong> Additional email addresses are not supported.</blockquote>
        /// </summary>
        [DataMember(Name="cc_emails", EmitDefaultValue = false)]
        public List<string> CcEmails { get; set; }

        /// <summary>
        /// A note to the payer.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Indicates whether to send the notification to the merchant.
        /// </summary>
        [DataMember(Name="send_to_merchant", EmitDefaultValue = false)]
        public bool SendToMerchant { get; set; }

        /// <summary>
        /// Indicates whether to send the notification to the payer.
        /// </summary>
        [DataMember(Name="send_to_payer", EmitDefaultValue = false)]
        public bool SendToPayer { get; set; }

        /// <summary>
        /// The subject of the notification.
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue = false)]
        public string Subject { get; set; }
    }
}

