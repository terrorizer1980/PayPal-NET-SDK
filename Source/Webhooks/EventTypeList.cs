// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// EventTypeList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOscoCMRAE4P5/ijB1+LGySHegnaiI2IhIztvDYEziJqcEuXeXKNicIJY7DLPfHescCArTK7kkyiFmJiZIbDQbXVua63MpQGJC8cAmJOMdFEpN+FbcqD56fxJUFuI/JCpmnV+7I4kV6WbhbIZqtY1UgktnmJp3sGQfiJOhCLX9IBpinr/2KQeKA1flhC6Ar7bxrzbXWdvv+r8HAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * List of webhook events.
    */
    [DataContract]
    public class EventTypeList {

        // Required default constructor
        public EventTypeList() {}

        /**
        * An array of webhook events.
        */
        [DataMember(Name="event_types")]
        public List<EventType> EventTypes { get; set; }
    }
}

