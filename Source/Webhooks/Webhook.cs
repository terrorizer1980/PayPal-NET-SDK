// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// Webhook.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6RTTW/bMAy971cQ2qUtnGanHXIL0AIbUCxFm22HIpgZiY65KKJLyQ2Mof99kPOBLFk7FLtZj6L4+N7zLzPtGjIj853mtcjSFOYbKuPc0xdc5YIpzBVFq9wklmBGZhIIRGElSrDedIHMf5JN8dIUZqyK3ebRD4W5I3ST4DszqtBHysBjy0puD9yqNKSJKZrRw57O9ROFBP3hhBHl2o/UNRRPyI0DYCYAUkHbQBJIFKDviPm0rtnW+SO289w3J+ik1d0ilzA9LCUB9H7XzsH61nFYQKD1DsQIqaYOUAnQOXIFxIYsV13GAWMi5biEs/KiPIc1ewcW1fWDlBqPlvqL5cFW5WaHP18qL8qjds8x9fxi2zSiidyWVAEPm9oTss/CbfHZ2fs9NOihQZ53mS+fH3n38VXvkrZH1oXW++di719MymFx6h27E8umNcHnq2xYXnNnxH8m6YjODYclHIyFSR/YU36ew/L1VCk9thTTQMljlvzh03h6PRnfQ986Oxs6sXGIDQ9rTCQYB31h+DaB/73SSwq36v8q8de7G0g1JuAIVkLFi1bJ5Yhn+ymABCi9WPS1xFRCJZoTL6sc+PJ2cj8tIUjiii32Eq4oRlxQ3LxqJSTk7a8GHCrRVX/vTU6+kKvZ87vfAAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * One or more webhook objects.
    */
    [DataContract]
    public class Webhook {

        // Required default constructor
        public Webhook() {}

        /**
        * REQUIRED
        * An array of up to ten events to which to subscribe your webhook. To subscribe to all events including new events as they are added, specify the asterisk (`*`) wild card. To replace the `event_types` array, specify the `*` wild card. To list all supported events, [list available events](#available-event-type.list).
        */
        [DataMember(Name="event_types")]
        public List<EventType> EventTypes { get; set; }

        /**
        * The ID of the webhook.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/hateoas-links/).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * REQUIRED
        * The URL that is configured to listen on `localhost` for incoming `POST` notification messages that contain event information.
        */
        [DataMember(Name="url")]
        public string Url { get; set; }
    }
}

