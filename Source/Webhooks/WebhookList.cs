// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// WebhookList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5TOMYvCQBAF4P5+xfLq5bjqiu0ClqIiooVYTMwEB9fdOLtBguS/SwhaGBBs3zDvfXdsuobhsOPyFOPZeEkZFltSodLzgi7DFRYzTkeVJksMcJhLyibW5ja+pV9YFKrUjXV/Fmumahl8B1eTTzwE11aUq1ew0tiwZuEEt3+HTA3PqYmlCIaG6Q+e/289ofW+P/Q/DwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * List of webhooks.
    */
    [DataContract]
    public class WebhookList {

        // Required default constructor
        public WebhookList() {}

        /**
        * An array of webhooks.
        */
        [DataMember(Name="webhooks")]
        public List<Webhook> Webhooks { get; set; }
    }
}

