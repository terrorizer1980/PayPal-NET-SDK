// This class was generated on Mon, 08 Jan 2018 16:11:33 CST by version 0.1 of Braintree SDK Generator
// EventResend.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOMUsEQQwF4N5fEVIPYmWx3cFaXKNyiI2IZHeyGhwzazKrDHL/XcaTLdzK9uWR933hXZ0ZO7z6YC1wYGeNGPCeTGhIfE1v7YoBe/bRZC6SFTs8FR0IPnl4yfkV+OeB5iKTjNRqAYYK+/4cA+7MqJ6WLgIemOKNpordRMm5Be+LGMc1uLU8sxVhx+5hNXox0eet7pfwJNE30J0CtXHI00qlccyLFtj3/gd3+V+cLikdH49n3wAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// Resends a webhook event notification, by ID.
    /// </summary>
    [DataContract]
    public class EventResend {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public EventResend() {}

        /// <summary>
        /// An array of webhook account IDs.
        /// </summary>
        [DataMember(Name="webhook_ids", EmitDefaultValue = false)]
        public List<string> WebhookIds { get; set; }
    }
}

