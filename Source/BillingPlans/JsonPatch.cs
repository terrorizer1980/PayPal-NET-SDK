// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// JsonPatch.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7SST0/DMAzF73wKK+dq4tzbJE4ctgkmLghpXuqtQWkcHHeoQvvuKBnbJAYaf4+1X53fs9+LmQ+RTG2ub6cTmKHa1lTmDsXh0tMEu9wzlbmiZMVFdRxMbcZQ5DHLgZePZBWUAWP0A0QUdeihjw0qpdwQStyLpTQylRmL4LB79bIyN4TNNPjB1Cv0iXLhqXdCzaEwE44k6iiZ+v7Am1RcWJ+yroS7T3nZBSXJRNoSeLaYBeBC+VaUNSk0bPuOgkIeBc+ts23+o+MNFdkGfU8j2HPCiqXUF1mxgAxbxv7Wa+i931ZnDXM8sTtv6YiR2S130ZPSt5BU+p8RRdT2CyfAswdAPa5/b6EI/2vHuyifOion/3DNpXPI/ghybSH0LgrQMCUIrCA7GsC3GP0F/8P24hUAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// A JSON patch object to apply partial updates to resources.
    /// </summary>
    [DataContract]
    public class JsonPatch<T> {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public JsonPatch() {}

        /// <summary>
        /// A JSON pointer to the location in the target document from which to move the value. Required for the `move` operation.
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// REQUIRED
        /// The operation to complete.
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue = false)]
        public string Op { get; set; }

        /// <summary>
        /// A JSON pointer to a location in the target document at which to complete the operation.
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// The value to apply. The `remove` operation does not require a value.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public T Value { get; set; }
    }
}

