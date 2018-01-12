// This class was generated on Wed, 13 Dec 2017 14:32:58 CST by version 0.1 of Braintree SDK Generator
// Payer.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xXQW/bOBO9f79ioO+wDSDbabvowbc0QYvsoq3RJL1kA2dMjq3ZUKRKUnXVRf/7YihVdmNnN8oGuQQINW/8ZubxkfwrO28qyqbZDBvyWZ59Qs+4MPQeS1nO8uyEgvJcRXY2m2bnBYGqQ3QleVgXDpa11QFiQVBhU5KN4yzPjrzHps18mGcfCfUHa5psukQTSBY+1+xJ9wsz7yrykSlk08ue05vaarYrOLUh+lpy7xJctjFz7mPCDucjCyiEwC2hi4et+FuEXw0lbGtjvuc96xA929XdTF2iNWe9t7enJ8IybnV5FMiQiqR77m0GWDr/U9/hE5qagANc7+nKNTi/+dCTuP6v47pVfdIRnNql8yWmunYaUUnInO3S7XRgCwe4cHX8qROPp6wzLitDMHMhooEjrT2FsMt0wcZIt7APuCUsCG2iqk3UxcGaYwHKoQ80WnlkK8NjMjqM4cSBdRHqQGmAaIFtJG9T0ZscY7joIhaobtboNShXVhh5wYZjA86aRrJRSPmUsxHZQlU4S4/XqLvErDg2+71BuFksh3GIvn7YplKuttE3c+U07eVzGddupAr0qKII8+wDvHz+6tXoOQjk6tlEOxUmMoKVTyOYaPak4sRTiJMu/Uhiw+QAYoERWJONvGRqba+Lke3lacXOjv+oDw9fqoVx6uZz7SKl/9u/KkTv7Kpdee8iTdvlyfY6nG+llZ9OOnjrCSO89pzmzAFapHxvYW9fd7k2S4BWJ3ncjr34fU9sEFVqYJvqiq4aGfpCBrQr5SdlqqFzHYw/CLZCFcD18YvrXdrHBVuEtfNGr7lbS0r2MkaorSjXO2NIQ+VZETw7vpgdQEmxcDqHBdobUOh1nopR3oUwWjivyUP0aAMqGVvouj653fYnkaFhS8/36m/JPkSQ7z98vd/gb5wH+opiIDnYulyQzyFETxTbWoMDZ8dPVsCLnQI+VK0pjZMiAyln9T1qCTVHygEr9FHOnr64hxX18CO3teW7zaGzbfmew7pgVci+ksK+cdVKWOr6XPMXNOmIPW8qVmhMA77j1wlaVC+OkKwftzND6/LbWc6I4HK2Cbl6VsRYhelkQna85huuSDOOnV9N5L/JbFPHwRO1LkSMdzjqfYwzwXvbTAcdXJxBWobu3rLpSApwsaCtTo7h43aHt7c68E/qk5mxBdfLMtAmzRQuj/xKDNviENL/xx+ogxwuX3v8xmYQfpEgAj5Gi3rYj6sEEfCp1TwMy4JI0IimGQYVhEB/wwrtIOifghDoO/rKyg3Clgki4PMC2aDVg+CxAx3koqzLC8tyWT6TkDAoUR3wYAzv8CuXdQmG7ComQ/j1EALblaHRookE/W0iPMpevLrHbqQS2fzjW+yXACmot+SnsYl0vM3lZvBv7NqDcPDN8OHUDN6TmQQ+JbHu/bP//TfDZoZmhCHwSp4Npyf9O++xnkH3Vl33sJy3V7H9J2gb0t3WHuOucvX9f38DAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// The customer who funds the payment.
    /// </summary>
    [DataContract]
    public class Payer {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public Payer() {}

        /// <summary>
        /// An array of funding instruments.
        /// </summary>
        [DataMember(Name="funding_instruments", EmitDefaultValue = false)]
        public List<FundingInstrument> FundingInstruments { get; set; }

        /// <summary>
        /// The ID of the customer-selected funding option for the payment. Value is `funding_instruments` or `funding_option_id`.
        /// </summary>
        [DataMember(Name="funding_option_id", EmitDefaultValue = false)]
        public string FundingOptionId { get; set; }

        /// <summary>
        /// Information about the customer.
        /// </summary>
        [DataMember(Name="payer_info", EmitDefaultValue = false)]
        public PayerInformation PayerInfo { get; set; }

        /// <summary>
        /// REQUIRED
        /// The payment method.
        /// </summary>
        [DataMember(Name="payment_method", EmitDefaultValue = false)]
        public string PaymentMethod { get; set; }
    }
}

