// This class was generated on Mon, 08 Jan 2018 16:11:33 CST by version 0.1 of Braintree SDK Generator
// EventTypeList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOscoCMRAE4P5/ijB1+LGySHegnaiI2IhIztvDYEziJqcEuXeXKNicIJY7DLPfHescCArTK7kkyiFmJiZIbDQbXVua63MpQGJC8cAmJOMdFEpN+FbcqD56fxJUFuI/JCpmnV+7I4kV6WbhbIZqtY1UgktnmJp3sGQfiJOhCLX9IBpinr/2KQeKA1flhC6Ar7bxrzbXWdvv+r8HAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// List of webhook events.
    /// </summary>
    [DataContract]
    public class EventTypeList {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventTypeList() {}

        /// <summary>
        /// An array of webhook events.
        /// </summary>
        [DataMember(Name="event_types", EmitDefaultValue = false)]
        public List<EventType> EventTypes { get; set; }
    }
}

