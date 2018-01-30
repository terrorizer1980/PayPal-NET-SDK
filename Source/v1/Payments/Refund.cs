// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Refund.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/+xY32/bthN///4VB/X70AS2lC79mbcA3dBg3RokboEhC+yTdLa4UKRKnuIIQ//3gaJkS5bbpmjm9cFPhu6O9N19jscP7+9gUhUUnASG5qVKg1HwAY3AWNLvmDt5MAp+pWr98ZpsYkTBQqvgJDgFvw7YoLKYOHEYjIJTY7DyOx+NggvC9J2SVXAyR2nJCT6WwlC6EpwbXZBhQTY4uVr5hLkuFQ99WsnXnq1Eff8mGUGBVU6KwZuMYCk4g9gQ3ozLwj6ct5aNUIuht0lpDKmk6vnbEQ49vuLMEI2TDA0mTAbOLt+Nn/705AW0yyDRKV0/jlKd2EgopoVBt0GUCkMJR4YsR63x2Bnb6CCEc6zOUUKqyYLSDLYsCm0YUMp2a0HflhI25UZGVCnlp9EGiNOUGIW0w/SsFevsrGXD5GCaCvfp4vBmgLEuGXiA9b+P7ULMebo0WPTc70qHATgtOC3MiUL4De9EXuYgSS04A2HhyRGsoLcjWGYiyUCoRJYp2ZM/y6Oj46SU9S/5Lyn81yXdkoJULARbiGmuDdVpSSkROUootFAc+jVRu6i/xeQbzZe6/T+cu1K9599FbQDfCdFGsX0OpwxVKoVaTOdEPag2FEO0WoM9WM5l3y8ohbn2q5uO0p67nDjTKWglq3A3yAplS4Mq6cPalQ4xXWn3oPZAdbB9GdkdgWozURRes8a0IxxC2ir3iO6sp7Ypn6bCJgNCtk37ZdigtdyfyB+vzdoyZs0o+xivhVugbZQNF1uFIphyG8LZvP4y9LEkyysoQQrV2IyAM2Gh8M5WrgoOD00Ty+Hh/pTvBHjGux7m/nsIN+PdHpEHQOT6PpgMTuLnj2HvDDooFpQC6/a1RARxtfowIfyiTfOmtyMwVBiypNjWJs0unCF31jfW7abaiIVQvlm5Dfc18b1v6fuURIIFl4amIu2PGbriYXGcvQbt+7BFSd0hDsTkrmWPLe2K9yWGkGnKIu/T+b58GEeKTIAqBWcBy4xUc7nUs6klWvA7pCMQCq7OFJNRxBvr5trkyNePM+bCnkQRay1tKIjnoTaLKONcRmaeHB8fv3pkqU7T+Fn4/GBHyUk7YfeHJV35MDlNFjpmu3qa9WvxqzX48KPEe78hb7VIaKrKPCaz8ZDcUPUD+EOXBvRSQWMHjuQYTG7c4Tl7DX5ZCB9QluR6H4J3wsVshVpIGseVK0JZZKjKnIxIOt3xgRMghbqZdgphquO/KNkyYXWG/ZFcK9mY/ypA554Lp6FyY0PSHTW4enM6+fnd6SXUS9thJRYi0rdkbgUto0cZMmm049pk8yA9f/h5XWZo3p//eMGwLBOdF5LYERuzIIb3F29DmGjI8YaaavVhJijlyJnHjrk6TcPO6zlzTWFddL7zvL84A6a8cEvv22+eP3txdBDCmb8g63+Y/X82gtnj2ahuXrODWadkaqJdGBoXRidkXZGF4CKauVhnrgjdFjdUQQuQi1Uraq/2GgzAVQp8jD4edLzeOqQdnUApd3REfU570K1EQ/DeTCbnLQzti8Hxk63g7SgCQ33K5r+3DP9d+r2D7h7mqqCvlsizVy9frq6kpwctp7JkbskCWkDlupGrDKzh9UCXCvNYLEpdWlk1F0RMvj4s5ahYJLbtzm5ZCJdEcPXW7XDReGjX3i2Xy1Cgwto3tFYslHuu2sitHbchbX6Gdy6Mh7lF70OVCjSkeNq8pXuYDFRfuq7ax7hWTbrrs97lUMJCjHZn7MkQ2g1usBJtowVOtSbzm47/F/zPsdBNCruW/fj81TJyn7m2ki3zEafpU58deVkW6VaW3Zd/A8u2ujQJ1TxbomXwG/3AZPv60//+AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A refund transaction.
    /// </summary>
    [DataContract]
    public class Refund
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Refund() {}

        /// <summary>
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount;

        /// <summary>
        /// The ID of the sale transaction being refunded.
        /// </summary>
        [DataMember(Name="capture_id", EmitDefaultValue = false)]
        public string CaptureId;

        /// <summary>
        /// The date and time when the refund was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime;

        /// <summary>
        /// The refund description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description;

        /// <summary>
        /// The ID of the refund transaction.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// Your own invoice or tracking ID number. Value is a string of single-byte alphanumeric characters.
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [DataMember(Name="parent_payment", EmitDefaultValue = false)]
        public string ParentPayment;

        /// <summary>
        /// The reason that the transaction is being refunded.
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue = false)]
        public string Reason;

        /// <summary>
        /// The ID of the sale transaction being refunded.
        /// </summary>
        [DataMember(Name="sale_id", EmitDefaultValue = false)]
        public string SaleId;

        /// <summary>
        /// The state of the refund.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime;
    }
}

