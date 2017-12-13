// This class was generated on Wed, 13 Dec 2017 14:32:22 CST by version 0.1 of Braintree SDK Generator
// Metadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8TTz4rbMBAG8HufYtClF1N69i3QY/8R0l5KMRNrHA/Ikjsax5iSd19kJ15Cdg+7Ds5Vsj5+81n6b3ZDSyY330jRoqLJzG8Uxr2j79ikHZOZLxRL4VY5eJObTWdZgX0VpMG0BlUQ0JpAKIZOSvpkMrMRwWEK/5yZLaH94d1g8gpdpLTwr2MhOy/8lNCSKFM0+Z+ZFVXYH25RJfqSnCNb7Icb4K4mwFKDQF8HmD4le1eh75w7ZW9gWlR6EZo2AL0F5Yagr8lfQaHHOI+wlloI9fVqqUF2gNYKxQihGr1YlqHzClqjwjngIY2f7cv6nkJWIlcsUYtIXpepxxxIOSvBHV7c774pKWIkP+KuPPsX9T7PsCa7a+2yNzqqyfKD3unVEMvrnwZZyd7iQFIcmfqiE3cD/7X9CkKtULoT7A8jeTzzMUI6dfkf7I+B79T439OHJwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Audit information for the resource.
    /// </summary>
    [DataContract]
    public class Metadata {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Metadata() {}

        /// <summary>
        /// The actor who canceled the resource.
        /// </summary>
        [DataMember(Name="cancelled_by", EmitDefaultValue = false)]
        public string CancelledBy { get; set; }

        /// <summary>
        /// The date and time when the resource was canceled.
        /// </summary>
        [DataMember(Name="cancelled_date", EmitDefaultValue = false)]
        public string CancelledDate { get; set; }

        /// <summary>
        /// The email address of the account that created the resource.
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date and time when the resource was created.
        /// </summary>
        [DataMember(Name="created_date", EmitDefaultValue = false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// The date and time when the resource was first sent.
        /// </summary>
        [DataMember(Name="first_sent_date", EmitDefaultValue = false)]
        public string FirstSentDate { get; set; }

        /// <summary>
        /// The email address of the account that last sent the resource.
        /// </summary>
        [DataMember(Name="last_sent_by", EmitDefaultValue = false)]
        public string LastSentBy { get; set; }

        /// <summary>
        /// The date and time when the resource was last sent.
        /// </summary>
        [DataMember(Name="last_sent_date", EmitDefaultValue = false)]
        public string LastSentDate { get; set; }

        /// <summary>
        /// The email address of the account that last edited the resource.
        /// </summary>
        [DataMember(Name="last_updated_by", EmitDefaultValue = false)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// The date and time when the resource was last edited.
        /// </summary>
        [DataMember(Name="last_updated_date", EmitDefaultValue = false)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// URL representing the payer's view of the invoice.
        /// </summary>
        [DataMember(Name="payer_view_url", EmitDefaultValue = false)]
        public string PayerViewUrl { get; set; }
    }
}

