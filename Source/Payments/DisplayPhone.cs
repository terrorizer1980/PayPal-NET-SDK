// This class was generated on Mon, 11 Dec 2017 13:16:25 CST by version 0.1 of Braintree SDK Generator
// DisplayPhone.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yRQUvDQBCF7/6KZS9ayGYTlR5yE+2hF5VavJRSpptps7DZXWc3hiD975I21oIFD3p9w3u8980Hn3ceecFLHbyBbuUrZ5En/BVIw9rgI9T9mSf8AYMi7aN2lhd8XiHz0CFeBrb3MNvUa6SUJ/yOCLpDbpbwGUL5ZE3Hiw2YgL3w1mjC8ig8k/NIUWPgxeLYKETSdvuzinKNjdStlCvxbK1FbJ1QFRCoiMSmL5m4ycdjkbPBynrr8qqK0YdCyhLf0fQNUg+dB5MqV8vSqSC1jbgl6LNlqQlVlIQhyiFH9DlBjpjbsHjCYzj/FYVtjNklv/I4cD9LQlvxNfn0RwnTli0maT6+HRRtt8wbsGzjqIb4zaZt21THJtW2n67kXMwm92JvFddZnuW5mI7+Zehyd/EJAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The payee's phone number.
    */
    [DataContract]
    public class DisplayPhone {

        // Required default constructor
        public DisplayPhone() {}

        /**
        * The [two-character IS0-3166-1 country code](https://developer.paypal.com/docs/integration/direct/rest/country-codes/) of the payee's country.
        */
        [DataMember(Name="country_code")]
        public string CountryCode { get; set; }

        /**
        * The in-country phone number, in [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164-201011-I).
        */
        [DataMember(Name="number")]
        public string Number { get; set; }
    }
}

