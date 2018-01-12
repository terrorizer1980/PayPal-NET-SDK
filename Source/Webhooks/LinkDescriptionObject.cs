// This class was generated on Mon, 08 Jan 2018 16:11:33 CST by version 0.1 of Braintree SDK Generator
// LinkDescriptionObject.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTQU/bTBCG79+vGC3fgUiOzaG0NDckKoGECgqhlwjJk/Uk3ma9a2bGpFbFf6/WBlpRKlq1x0xmvO8zz+5Xs+hbMjNz7sIWTkgsu1ZdDHCx+kxWTWY+ITtcefqITWo0mfmhzczMoiZguu1IdMrkUamC5enx4sPF8RV4F7Zys19U0UqBrSviHfGdo12xV6NSRJkOLZPcZOaYGfsxz0Fm5oTVRfC9ma3RC6XCbeeYqqfCJceWWB2JmS2fSETZhc3PwWum9YvhbWxaT0qgyBtSuJ6f57CI0OCWQAe6kcqi91lqX7kw/tOQ1rGCndMatHYy8GbgAiyv52eg1LRpFNaRG9Sb/Vq1lVlRaIxecke6ziNvilobX/Davj18dzDJ4SxY31XjCeX/ZQblfpkBhgrKSQm2RkarxJI+Cy3TtOVoScSFTQ6JqEysJTgZPrGlHh59JNYYKChojTrqAXxawcg48iBIt5IkNuhQ/iNFyt0zQ6Hz/j57VdO40hdFnS4Wl48r54eTQH8h6m8v1G/GZfIvZl2m1Y6B0mvSvqVX9R++PzraE7JpYvpmksGudrYGIb4jARTAAGcng3Uc1I0Su4DNym262InvoRqirGh0L9RgUGcF4noopLEcrohgOTz5+UNC+Z5ut9vlDgMO2VDEbUJDQaVIs9NHpOc/8y8JY/IvLsnN/X/fAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// The request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
    /// </summary>
    [DataContract]
    public class LinkDescriptionObject {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public LinkDescriptionObject() {}

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this link, in [URI template format](https://tools.ietf.org/html/rfc6570). Include the `$`, `(`, and `)` characters for pre-processing. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [DataMember(Name="rel", EmitDefaultValue = false)]
        public string Rel { get; set; }
    }
}

