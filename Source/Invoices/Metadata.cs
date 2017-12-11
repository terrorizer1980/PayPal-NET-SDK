// This class was generated on Mon, 11 Dec 2017 16:45:18 CST by version 0.1 of Braintree SDK Generator
// Metadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8TTz4rbMBAG8HufYtClF1N69i3QY/8R0l5KMRNrHA/Ikjsax5iSd19kJ15Cdg+7Ds5Vsj5+81n6b3ZDSyY330jRoqLJzG8Uxr2j79ikHZOZLxRL4VY5eJObTWdZgX0VpMG0BlUQ0JpAKIZOSvpkMrMRwWEK/5yZLaH94d1g8gpdpLTwr2MhOy/8lNCSKFM0+Z+ZFVXYH25RJfqSnCNb7Icb4K4mwFKDQF8HmD4le1eh75w7ZW9gWlR6EZo2AL0F5Yagr8lfQaHHOI+wlloI9fVqqUF2gNYKxQihGr1YlqHzClqjwjngIY2f7cv6nkJWIlcsUYtIXpepxxxIOSvBHV7c774pKWIkP+KuPPsX9T7PsCa7a+2yNzqqyfKD3unVEMvrnwZZyd7iQFIcmfqiE3cD/7X9CkKtULoT7A8jeTzzMUI6dfkf7I+B79T439OHJwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Audit information for the resource.
    */
    [DataContract]
    public class Metadata {

        // Required default constructor
        public Metadata() {}

        /**
        * The actor who canceled the resource.
        */
        [DataMember(Name="cancelled_by")]
        public string CancelledBy { get; set; }

        /**
        * The date and time when the resource was canceled.
        */
        [DataMember(Name="cancelled_date")]
        public string CancelledDate { get; set; }

        /**
        * The email address of the account that created the resource.
        */
        [DataMember(Name="created_by")]
        public string CreatedBy { get; set; }

        /**
        * The date and time when the resource was created.
        */
        [DataMember(Name="created_date")]
        public string CreatedDate { get; set; }

        /**
        * The date and time when the resource was first sent.
        */
        [DataMember(Name="first_sent_date")]
        public string FirstSentDate { get; set; }

        /**
        * The email address of the account that last sent the resource.
        */
        [DataMember(Name="last_sent_by")]
        public string LastSentBy { get; set; }

        /**
        * The date and time when the resource was last sent.
        */
        [DataMember(Name="last_sent_date")]
        public string LastSentDate { get; set; }

        /**
        * The email address of the account that last edited the resource.
        */
        [DataMember(Name="last_updated_by")]
        public string LastUpdatedBy { get; set; }

        /**
        * The date and time when the resource was last edited.
        */
        [DataMember(Name="last_updated_date")]
        public string LastUpdatedDate { get; set; }

        /**
        * URL representing the payer's view of the invoice.
        */
        [DataMember(Name="payer_view_url")]
        public string PayerViewUrl { get; set; }
    }
}

