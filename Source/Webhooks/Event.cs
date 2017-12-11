// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// Event.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8yVT2vbQBDF7/0Uw/aSgmwVTAPVTZCUBkpdWtOLMclYGllb7x9ldhRXLfnuZe3YmFhuDilurjuzw++9fSP9VpOuIZWpyztyohL1HVnj3NBntPFYJeqCQsG6Ee2dylQOK5rX3i+B4g1wXnSlC4zloUpUzozdZubbRH0lLMfOdCqr0ASKB7etZip3B1/YN8SiKahsuqMJwtotDnEKJhS6Fm3pgGxSE5QoBOhKiB2wqsmB1PQXZFhhgM3UMgHtYHrlhNiRPJpVebYos7NapAlZmor3Jgw1STX0vEhrsSblqhiNRu9fByri7MG74fmb53riWmPukyeNWSu7ltjU58tGuNQoIKwXC2Iqn3DmpOB3xCHSHmd/6IhPtM/9H4h12Yt5dQG+Oq2nn7Rbwh4JjOc/qOjZYqPdMhyusgOMMJGb6balIAMmE1cBph/zyeU4/wbrq7OztPRFSLHRaY1CHsNgXXgc7/NnKvJHBDAF33LRH+5t8UXmewt3fDcdWtpGZydl+w7ij8Z9o+lEMkJrLXLX8zt4qEC5l8PK8xq7x3X44BnoJ9rGUAI3OTTY2diFrdSe9a+Dz/Lw5l9InN2/+gMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * A webhook event notification.
    */
    [DataContract]
    public class Event {

        // Required default constructor
        public Event() {}

        /**
        * The date and time when the webhook event notification was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * The event that triggered the webhook event notification.
        */
        [DataMember(Name="event_type")]
        public string EventType { get; set; }

        /**
        * The event version in the webhook notification.
        */
        [DataMember(Name="event_version")]
        public string EventVersion { get; set; }

        /**
        * The ID of the webhook event notification.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The resource that triggered the webhook event notification.
        */
        [DataMember(Name="resource")]
        public object Resource { get; set; }

        /**
        * The name of the resource related to the webhook notification event.
        */
        [DataMember(Name="resource_type")]
        public string ResourceType { get; set; }

        /**
        * A summary description for the event notification. For example, `A payment authorization was created.`
        */
        [DataMember(Name="summary")]
        public string Summary { get; set; }
    }
}

