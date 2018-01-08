// This class was generated on Mon, 08 Jan 2018 16:22:15 CST by version 0.1 of Braintree SDK Generator
// WebProfile.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8xY3XPbuBF/71+xo5drZxTFuU7bqWf64MSJ417qaGzl8tDeUCtyRe4FBHgAaJnu9H/vLADqk07sO9vtQxCZu1jsx28/gH+PZl1Do+PRZ1rA1JolKxqNRz+iZVwousBaiKPx6JRcbrnxbPToeHQCDXY1aQ8rWgDdNGSZdE7QRBGT0Xh0Yi12UfrReHRJWHzUqhsdL1E5kg+/tGypWH+YWtOQ9UxudPzPtV7vlFnBG6OXXB7qtVRmleU9cVfFWUUgdIj01qIQoEGLNXmy7vF0dN6yHlBvgfpL5m901pAuWJdZa9WgnjXZvELtwbEn+HT5AbyBgl2jsANcerKAINLAW9RuSbb3/wTONZyRrVF3Y7hGxQUYrTpYGgu+Ijhjaxrs1vGqyVemAGOH5SX6b/WNbpX6z/ibDlIY/dJgSZkX3iHvCAHMEhI3CPe2g4wOlk6xm6KKLhTrW0cW8oryL6b1E5gZ+RI4tdEvEjfmuWm135E9BkdeDpi/ZqVYl/Od3fs7Tcn6jv0fhDZ/Jmda8q3VWWs5q7xvshjJQY++n82mPRJ8ssyApYIt5T5YmbfOm5qsEBCibEHmBH5E1RKwg/nZ29lckDSffryaPZeZEtYM82DNvm1TS460d0DsK4oJ8K/26OiPufPW6DL8pjdGe9YtRcrLbZJYc7hhih1cmNUQf4+vWGq82fHdJO5Y2JeRe+/PU1piq7y48kFKjjda5qaIHLTllr/lu3s3TBP4XJGGzrRQGNDGwxctakupZI1qXQWwFmyPBeTUCCDYQZHUFUvHsKo4r9aQcQeY2cqUXmjI2xX76lfEZdF6b3TSf+esXHH+5cEe3BWBGqT+ljHBd53wjSBuPPoNV0pN+HrQ6pr9QcjEl3llTCo+DwLnk0XqK2f+ikDdLW28Ew92Ml7k5BwVwHVNBaMn1T1K4fnpHqWHh6vp+al0J9H0aYahvcJ4rpvWwzsmVbgBHYWaLXvqobaBAQJDig3fPt1oxNpTSfZQTywKS85l5pqs5eKw85/rgnP05GBVUazmm5YvznYVN4303CQKfIURJBgQEqDNDnJUCiymhoARlUbLP5DwpFGJHSzajuzeOLEdTizJbfrfcQRsq7brguLtvzZpfDRQi0+jMW7YmqRdKj8vdwXfdcyrBx/jGsp5yZJReuOvyUGBlGZBBadesC9mWMuXvW8eNwEWxihCPYApJfcBbfy90LTfAUjHOVv293VxPZjvgiLUx6KVKrGZMB/XyDsTR5us9/49rEwKFz0GDuIfK0Vv3/8S7Xv+db8d+ZdUoHS8u4xeWlMfHgvvjIWCS/aooDSmcOMI+lgz2YFNcQTUBdSt87AguIdCDzLo+wGDzsjf4b+1KT2kv3PrG0rfhp4+R+/TRLX8N9SYhpsnCP8E/pG83Gr+pY0lG8NIZZY9p0tf+5x9UEJ62349H9PVAtO9Y8+oZpd6aJzznaKAl23W532NsKiLbND9J6BwQSp20L4jR6QtWsdaECYbY484uAIPJS+8qdBiLiVVkS59FYxXXHM03R3Dq+//Ao51qejFovMEqJoKdVuT5Vzm8bjdPddbhMlRUSbpNhjBSA94EwOjrwZm5y0I91V3AifpaeZ6fXc++TQfw/xkJuvrt2G9lPXNSVjfh/VC1tNAfXsl69lrWd8FzvOw9+KDrNO4hi+XIllu5Z+u5nLyn16sfQlinRyPypmkkiSNQl22waoYYEcQImuZ3DHMC8xOfxDRFWXn4SQusvNT+fEzZn+fyg9tsouP8qPxWbTEtllQZe6us6tgg6+yWTDstsqibbdV9v6HpO5tlc0+z58t2qXJuMZyKBnSA5wPUS8NBL5NEMPFI75KSSQnJS/FlsnPTZlMmTTx0UjGbdn7nYMab7hua1hx4SvZ9+qvR9DwDSkX20iiV8RlFcbYP/f0SQ+x3JrGRYkJf2gJFNqS7JqpUZiTkxup3dIeEli9afrLSo7Wg6VrppXIwbUES3IXJV2kQ+Ry67yx8QYaxRkd6m/eWoLfv5/Npld/AEf2WhT5KJPHih2NQ01fWLNyZN3mQRNqci484on49RNKzKvcaI+swyNdOoA91f93FeWn+0yknurGWLTdPQfSvuk1ZB0779LdxBJBZVrrBF1NeO0l7VUX3iUT7/7+nmfzGhksmd+5Z++ozT7pjfNH8tnv/gsAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PaymentExperience
{
    /// <summary>
    /// A payment web experience profile.
    /// </summary>
    [DataContract]
    public class WebProfile {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public WebProfile() {}

        /// <summary>
        /// The flow configuration parameters.
        /// </summary>
        [DataMember(Name="flow_config", EmitDefaultValue = false)]
        public FlowConfig FlowConfig { get; set; }

        /// <summary>
        /// The ID of the web experience profile.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The input field customization parameters.
        /// </summary>
        [DataMember(Name="input_fields", EmitDefaultValue = false)]
        public InputFields InputFields { get; set; }

        /// <summary>
        /// REQUIRED
        /// The web experience profile name. Must be unique for a set of profiles for a merchant.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The style and presentation parameters.
        /// </summary>
        [DataMember(Name="presentation", EmitDefaultValue = false)]
        public Presentation Presentation { get; set; }

        /// <summary>
        /// Indicates whether the profile persists for three hours or permanently. To persist the profile permanently, set to `false`. To persist the profile for three hours, set to `true`.
        /// </summary>
        [DataMember(Name="temporary", EmitDefaultValue = false)]
        public bool Temporary { get; set; }
    }
}

