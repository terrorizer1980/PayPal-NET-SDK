// This class was generated on Mon, 11 Dec 2017 13:16:29 CST by version 0.1 of Braintree SDK Generator
// PaymentHistory.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6ySMa/bMAyE9/4KQrNhBB06eAuQpUtaFGmXokiY+GIJkGSHotIYRf57odZJgLhD8d5byaP48XS/zGYcYBoz8BgQdWtd0l5GU5lvLI73HmsORWAqs0I6iBvU9dE0ZhmJRXik/kjTdCK1rKQWlOA9hAK3qE1llkX5d9WiMl/A7afoR9Mc2SeUwik7QXsvfJZ+gKhDMs33O6SLig4yhzv0OeqMcGNBMYc9pDA6RUgk0CwRLblI4IMl4dih9AUpe001rXvF4xDPSW+9SRxcZ5Usn0FH/IRMT6vl+GdEcMpIivZ5e00FKfDFhRzozD6DXKLd+8XutSbF7P21ujuVVFzs5kZFXHTr2n9a9XFVQMsBRUXwKH9a09cE0p466KM5c+1t8ac8zflvQfuvND5BfXgR1I/ru98AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * An array of payments that the seller made.
    */
    [DataContract]
    public class PaymentHistory {

        // Required default constructor
        public PaymentHistory() {}

        /**
        * The number of items returned in each range of results. Note that the last results range might have fewer items than the requested number of items. The maximum value is `20`.
        */
        [DataMember(Name="count")]
        public int Count { get; set; }

        /**
        * The ID of the next element. Use to get the next range of results.
        */
        [DataMember(Name="next_id")]
        public string NextId { get; set; }

        /**
        * An array of payments.
        */
        [DataMember(Name="payments")]
        public List<Payment> Payments { get; set; }
    }
}

