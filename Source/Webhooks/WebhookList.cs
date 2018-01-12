// This class was generated on Mon, 08 Jan 2018 16:11:33 CST by version 0.1 of Braintree SDK Generator
// WebhookList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOMYvCQBAF4P5+xfLq5bjqiu0ClqIiooVYTMwEB9fdOLtBguS/SwhaGBBs3zDvfXdsuobhsOPyFOPZeEkZFltSodLzgi7DFRYzTkeVJksMcJhLyibW5ja+pV9YFKrUjXV/Fmumahl8B1eTTzwE11aUq1ew0tiwZuEEt3+HTA3PqYmlCIaG6Q+e/289ofW+P/Q/DwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /// <summary>
    /// List of webhooks.
    /// </summary>
    [DataContract]
    public class WebhookList {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public WebhookList() {}

        /// <summary>
        /// An array of webhooks.
        /// </summary>
        [DataMember(Name="webhooks", EmitDefaultValue = false)]
        public List<Webhook> Webhooks { get; set; }
    }
}

