// This class was generated on Mon, 08 Jan 2018 16:11:33 CST by version 0.1 of Braintree SDK Generator
// Event.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8yVT2vbQBDF7/0Uw/aSgmwVTAPVTZCUBkpdWtOLMclYGllb7x9ldhRXLfnuZe3YmFhuDilurjuzw++9fSP9VpOuIZWpyztyohL1HVnj3NBntPFYJeqCQsG6Ee2dylQOK5rX3i+B4g1wXnSlC4zloUpUzozdZubbRH0lLMfOdCqr0ASKB7etZip3B1/YN8SiKahsuqMJwtotDnEKJhS6Fm3pgGxSE5QoBOhKiB2wqsmB1PQXZFhhgM3UMgHtYHrlhNiRPJpVebYos7NapAlZmor3Jgw1STX0vEhrsSblqhiNRu9fByri7MG74fmb53riWmPukyeNWSu7ltjU58tGuNQoIKwXC2Iqn3DmpOB3xCHSHmd/6IhPtM/9H4h12Yt5dQG+Oq2nn7Rbwh4JjOc/qOjZYqPdMhyusgOMMJGb6balIAMmE1cBph/zyeU4/wbrq7OztPRFSLHRaY1CHsNgXXgc7/NnKvJHBDAF33LRH+5t8UXmewt3fDcdWtpGZydl+w7ij8Z9o+lEMkJrLXLX8zt4qEC5l8PK8xq7x3X44BnoJ9rGUAI3OTTY2diFrdSe9a+Dz/Lw5l9InN2/+gMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// A webhook event notification.
    /// </summary>
    [DataContract]
    public class Event {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Event() {}

        /// <summary>
        /// The date and time when the webhook event notification was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The event that triggered the webhook event notification.
        /// </summary>
        [DataMember(Name="event_type", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The event version in the webhook notification.
        /// </summary>
        [DataMember(Name="event_version", EmitDefaultValue = false)]
        public string EventVersion { get; set; }

        /// <summary>
        /// The ID of the webhook event notification.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The resource that triggered the webhook event notification.
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue = false)]
        public object Resource { get; set; }

        /// <summary>
        /// The name of the resource related to the webhook notification event.
        /// </summary>
        [DataMember(Name="resource_type", EmitDefaultValue = false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// A summary description for the event notification. For example, `A payment authorization was created.`
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue = false)]
        public string Summary { get; set; }
    }
}

