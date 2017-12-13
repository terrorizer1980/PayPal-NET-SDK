// This class was generated on Wed, 13 Dec 2017 14:32:25 CST by version 0.1 of Braintree SDK Generator
// QrCode.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SOP4vDMAxH9/sURrPhbjg6eCvt3D+hdCkdlFgJAsd2ZWcwJd+9JIEM7dhRP8F77wmXEgkMnCu1C5ZAwxWFsXZ0wH56gIY9pUY4Zg4eDNSYaPOvyDfBklXcY0cqtCqXSMv1G30HGrYiWBb8n4aK0B69K2BadImm4TGwkF2Hk4RIkpkSmNsalrLwjHvrmk0fcV9q/eDceB9/XgAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// base64 encoded image of type image/png
    /// </summary>
    [DataContract]
    public class QrCode {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public QrCode() {}

        /// <summary>
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue = false)]
        public string Image { get; set; }
    }
}

