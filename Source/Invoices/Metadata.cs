// This class was generated on Mon, 08 Jan 2018 16:45:11 CST by version 0.1 of Braintree SDK Generator
// Metadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8SUP4vcMBDF+3yKQU0aE1Jvd5AufzkuaUJY5qzxeUCWnNH4jAn33YPsPV9sbYo4i7f0POvp/XiDfpm7oSVzMB9J0aKiKcw3FMZ7R5+wSYopzHsaXj7eUSyFW+XgzcHcdJYV2FdBGkwzqIKA1gRCMXRS0htTmBsRHKab3hbmltB+9m4whwpdpDT42bGQnQdfJLQkyhTN4fucMaqwf8gTluhLco7s8X5YpF0Jy+R3NQGWGgT6OsD0K9mLRvedc0/FP+S3qPQXgpOUMyQB0FtQbgj6mvyCAXqMM91eQEKoZ+r4c5yDUIPsAK0VihFCNWJgWYbOK2iNCieDq3R0yp43tBQ29jOZ7MRSsUQ9RvKa4+TaNqLRB5LPTlAOn3Ovtm4lbNm7ZDGyXGPzXvJnZWXStq5mvD2JutaeeyNybXNhZPlKj8UC4nxrK/U/ipswdyJrcSA5PjL1x07cAiuTlkxfbz+AUCuUFo39w0gznnkdIZ16LpL9Y+ALVfXj6dVvAAAA//8=
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

