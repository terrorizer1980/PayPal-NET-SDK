// This class was generated on Mon, 11 Dec 2017 16:45:16 CST by version 0.1 of Braintree SDK Generator
// Cost.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yT0WsUMRDG3/0rhoCgEI49tQj3VhXBl1a09EWEm01m25FsEieT4iL+75Leeue5iEjvdZhJvt838303V1MmszGvU1FjzTUKYx/oAsdWNda8oeKEs3KKZmOubglcKgpYACGTOIoKSQAj4JhqVLjDUGkFb5MAfcMxB7KgCUomx8ME6+6xBYpKAtt1t13BeVCSiMp3FKaj1sObaYCz/dTZdmWsORfBaSe+s+YDob+MYTKbAUOhVvhaWcjvC+8lZRJlKmbz6YBdRSi6aYm++3lhwCssBKn/Qk5haNwhwMARo2MMO3YQCqjkYWAKvsCTHgNGRxYyTmPzy1eyQOpWT08GUlQ43iwx3AHwGOQ5BNLm568OcMlT26ungSN56Cd49/ESXjxbv/wvw1XqHzJjDeGH/afWe/cWQucTqLmdxgV4vmEFHJp0vSXw5HjEUKBQRkFtOzkwcNwz3K+rTWDOkrIwKh3Dn4Ly82+csY49yZJzjs1fw2WP0zUH6hoD+/nCuMAgaYSuebLuuocGYpb+6CcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
    */
    [DataContract]
    public class Cost {

        // Required default constructor
        public Cost() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="amount")]
        public Currency Amount { get; set; }

        /**
        * The cost, as a percent value. Valid value is from 0 to 100.
        */
        [DataMember(Name="percent")]
        public double Percent { get; set; }
    }
}

