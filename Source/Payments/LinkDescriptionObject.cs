// This class was generated on Mon, 11 Dec 2017 13:16:17 CST by version 0.1 of Braintree SDK Generator
// LinkDescriptionObject.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTT0/bTBCH7++nGC3vgUiOzaG0NDckKoGECgqhlwjhyXoSb1nvmpkxqVXx3au1+SNRKlq1x0xmxr9nHvu7WfQtmZnxLtxcVySWXasuhuu4+kpWTWa+IDtcefqMTWo0mTl6bjMzs6gJmG47Ep0yeVSqYHl8uPh0dngBaa1c7RZVtFJg64p4R3znaFvs1KgUUaZDyyQ3mTlkxn7Ms5eZOWF1FnxvZmv0Qqlw2zmm6qlwzrElVkdiZssnElF2YfNz8Jpp/Wp4G5vWkxIo8oYULuenOSwiNHhDoAPdSGXR+yy1r1wY/2lI61jB1mkNWjsZeDNwAZaX8xNQato0CuvIDerVbq3ayqwoNEYvuSNd55E3Ra2NL3ht3+9/2JvkcBKs76rxCeX/ZQblbpkBhgrKSQm2RkarxJLWQss0bTlaEnFhk0MiKhNrCU6GFTfUw6OPxBoDBQWtUUc9gE8nGBlHHgTpVpLEBh3Kf6RIuXthKHTe32dvahpP+qqo48Xi/PHk/PAk0F+I+tsX6jfjMvlXsy7TacdALgbQvqU39e9/PDjYEbJpYvpuksG2drYGIb4jARTAACdHg3Uc1I0Su4DNym262InvYfyGVzS6F2owqLMCcT0U0lgOF0SwPE0b5g8J5TnddrvNHQYcsqGI24SGgkqRZqePSC9/5t8SxuRfvCRX9//9AAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
    */
    [DataContract]
    public class LinkDescriptionObject {

        // Required default constructor
        public LinkDescriptionObject() {}

        /**
        * REQUIRED
        * The complete target URL. To make the related call, combine the method with this link, in [URI template format](https://tools.ietf.org/html/rfc6570). Include the `$`, `(`, and `)` characters for pre-processing. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        */
        [DataMember(Name="href")]
        public string Href { get; set; }

        /**
        * The HTTP method required to make the related call.
        */
        [DataMember(Name="method")]
        public string Method { get; set; }

        /**
        * REQUIRED
        * The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        */
        [DataMember(Name="rel")]
        public string Rel { get; set; }
    }
}

