// This class was generated on Mon, 11 Dec 2017 16:45:20 CST by version 0.1 of Braintree SDK Generator
// QrCode.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SOP4vDMAxH9/sURrPhbjg6eCvt3D+hdCkdlFgJAsd2ZWcwJd+9JIEM7dhRP8F77wmXEgkMnCu1C5ZAwxWFsXZ0wH56gIY9pUY4Zg4eDNSYaPOvyDfBklXcY0cqtCqXSMv1G30HGrYiWBb8n4aK0B69K2BadImm4TGwkF2Hk4RIkpkSmNsalrLwjHvrmk0fcV9q/eDceB9/XgAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * base64 encoded image of type image/png
    */
    [DataContract]
    public class QrCode {

        // Required default constructor
        public QrCode() {}

        /**
        */
        [DataMember(Name="image")]
        public string Image { get; set; }
    }
}

