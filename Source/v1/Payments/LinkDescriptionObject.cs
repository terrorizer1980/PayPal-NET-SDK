// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// LinkDescriptionObject.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/6yUQU/bThDF7/9PMVr+ByI5NofS0tyQqAQqKiiEXiKEJ+tJvGW9a3bGpFbFd6/WC0EhqmjVHvd5Z+f95o38Q836ltREWePubitiHUwrxrtbv/hGWlSmvmIwuLD0BZt4UWXqM/Uvh5OXGjVRs5og0H1HLONAFoUqmJ8ezz5dHF9B7ME3+0XlNRfYmsI/UHgwtC72ahTyyOPhyihXmToOAftk7iBTU8LqwtleTZZomaJw35lA1Ua4DL6lIIZYTeYbLJZg3GqXog603CJ5EnZptG9aS0IgGFYkcD09z2HmocE7AhlwE6ZGa7N4fWFc+tKQ1L6CtZEapDY8DCAD42B+PT0DoaaNpbD0oUG52a9FWp4UhXhvOTcky9yHVVFLY4uw1O8PPxyMcjhz2nZV6lD+X2ZQ7pcZoKugHJWgawyohQLHZ6ENNG6D18Rs3CqHSFRG1hIMD0/cUQ/PAUVW78gJSI2S8gLcjCAxJh4E7hYck3YyyH+UmYTuVWSus/YxezO3NNKt5DbSbnans9nlcwrhqTnIL7L726X7TYJAdst+Ou96n8fpJ4PGO5C+pTc35PDj0dEek44V43ejDNa10TUwhQdiQAZ0cHYyLAYO6aacO4fNwqw637HtIf0EFpTWg6lBJ0Yz+OUgxLIcrohgfh5fmD455Bd36/U6N+hw8IbMZuUacsJFrB0/I70+5t8jxuhf7NHN438/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
    /// </summary>
    [DataContract]
    public class LinkDescriptionObject
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkDescriptionObject() {}

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this link, in [URI template format](https://tools.ietf.org/html/rfc6570). Include the `$`, `(`, and `)` characters for pre-processing. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue = false)]
        public string Href;

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method;

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [DataMember(Name="rel", EmitDefaultValue = false)]
        public string Rel;
    }
}

