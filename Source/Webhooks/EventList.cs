// This class was generated on Mon, 08 Jan 2018 16:11:33 CST by version 0.1 of Braintree SDK Generator
// EventList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yRQWvjMBCF7/srBp1N2NMefAtsbyEpJfRSSjN2Xqxp5JEjjRPSkv9e3IRQcKGH9PokzXzf07tbHju40mEPNQqSzRXukZNwFTDndjhzhfuPXCfpTKK60s0kG8UNHVD5GLeZPl/niSvcNCU+nmf+LdwDeL3QcHTlhkPGEOx6SVhfg/sUOyQTZFc+XWlEDQ3SGKWOvdqIZ+lB2rcV0kAlhjaTKIFrT4m1wRAn5D5YntA8Gsg8G5nHEHdRM6iVxht53oM2OCBd5phnvVzc9ciGNa06bvCS5Q0r2nPocau49iGciqv93dDm2P1c8kh+qsTD7p8/5N+NXDPRLX1ZTovqFfU3pEF0Owb9DZjn058PAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// List of webhooks events.
    /// </summary>
    [DataContract]
    public class EventList {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public EventList() {}

        /// <summary>
        /// The number of items in each range of results. Note that the response might have fewer items than the requested `page_size` value.
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// An array of webhooks events.
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue = false)]
        public List<Event> Events { get; set; }

        /// <summary>
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }
    }
}

