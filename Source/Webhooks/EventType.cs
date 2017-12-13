// This class was generated on Wed, 13 Dec 2017 14:33:08 CST by version 0.1 of Braintree SDK Generator
// EventType.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zQz0tDMQwH8Lt/Rci5iud3G+hVRYYX8ZD5Mlvs0i5NlSL736V7MoZPEH+cSpNvmw95w2XLjANevrAY7C8O70gDrSJf0ab30OEFl0cN2UISHHAhwPu8tcxn6HChSm366dzhLdN4LbHhsKZYuBe2NSiPh8KNpsxqgQsO9wdDMQ3yNJ8/Hg2fUcDXDcmpMo39CRyFIa3BPE/WvzKlxrhz31qlH5+RS89QJWzrhwV66kcg0/o7TzGyWr4UTa2+JIJXXvmUnv9xVQ+7k3cAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// An event type.
    /// </summary>
    [DataContract]
    public class EventType {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventType() {}

        /// <summary>
        /// A human-readable description of the event.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// REQUIRED
        /// The unique event name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The status of a webhook event.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }
    }
}

