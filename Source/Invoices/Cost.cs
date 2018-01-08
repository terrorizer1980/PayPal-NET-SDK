// This class was generated on Mon, 08 Jan 2018 16:45:07 CST by version 0.1 of Braintree SDK Generator
// Cost.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTUWsUMRDH3/0UQ0BQWI49tQj3ViuCCK1o6YsIN5f8t41kkziZLS7id5f0treuJ4jYx/2TbOb3m5nv5nLMMBtzloqaxlyxeN4FnHNfU9OYdxjnj9coVnxWn6LZmMsbkE1FiQsxZYhFVEpCHIn7NESlWw4DVvQmCeEb9zmgIU1UMqzvRlq3jxtCVAht1+12RadBIZHV3yKMi6PzP1NHJ4dbJ9uVacypCI97krYxH8DuIobRbDoOBTX4OniBOwTvJWWIehSz+TQ7GEQQ7XjsYf/ywsYhWjp5xQWUdl9glbqqIgTqfORoPYe9DhIEVjjqPIIr9GTHgaNFQ5nHvip0AxqC2tXTB2MrKj5eH5PZifksOSz47CxjSficArS6vz9BNjnUGXDofISj3UhvP17Qi2frl//UHJXht/rjEMKP5q8Qd1oX1d8ny9KnARpyHaxzcv7aK3FXYfQG5GB9z6FQQWZhre2bqXw8UN11tt7gnCVl8axY6ngI7s+/kMeh30GOyaelW7DP2Z/XtVnu67SiVxy8mwbUF+ok9dRWT+u2/d8Vm3Ae/QQAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
    /// </summary>
    [DataContract]
    public class Cost {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Cost() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The cost, as a percent value. Valid value is from 0 to 100.
        /// </summary>
        [DataMember(Name="percent", EmitDefaultValue = false)]
        public double Percent { get; set; }
    }
}

