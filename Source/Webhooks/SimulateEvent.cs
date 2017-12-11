// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// SimulateEvent.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yRQUszMRCG79+vGHIOy3fuTahCQVTa6kWkZDez7tBsZjtJKov0v0u6ddG2oKLXyTszz5N5Vcu+QzVRC2qTMxHhcos+Kq0ejJApHd6YNr8rraYYKqEuEvsPDQEMtFyt4QXLhnkNmAcUSqsLEdMP4/9rNUdjb73r1aQ2LmAubBIJ2rFwJ9yhRMKgJo8jWIhC/vkUaL9mFXPoGG3Z4EAB3rRYwKLDiuoe2CNwDbFBCKnMHSXaIRkKuGIBNFUDgpuEIWrohLdkEdi7ofnnalHSkZlPzu30l3pJ3Fmv+/k11Cx7ifHHve2YfCxgVgO3FCNa/SkxmwKFvVjG+u1xvqlwWL4ie9ZkNn0/xiF4ip9l/5r7affvDQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * Simulates a mock webhook event.
    */
    [DataContract]
    public class SimulateEvent {

        // Required default constructor
        public SimulateEvent() {}

        /**
        * REQUIRED
        * The event name. Specify one of the subscribed events. For each request, provide only one event.
        */
        [DataMember(Name="event_type")]
        public string EventType { get; set; }

        /**
        * The URL for the webhook endpoint. If omitted, the webhook ID is required.
        */
        [DataMember(Name="url")]
        public string Url { get; set; }

        /**
        * The ID of the webhook. If omitted, the URL is required.
        */
        [DataMember(Name="webhook_id")]
        public string WebhookId { get; set; }
    }
}

