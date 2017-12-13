// This class was generated on Wed, 13 Dec 2017 12:24:16 CST by version 0.1 of Braintree SDK Generator
// Address.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUS2/UQAzH73wKa7hQKcqyy21v5XVCdEWBAwghb8a7MUxmprZTiFC/O5ps1FZNxUOgvSX2X/HPj39+uLdDJrd2p94LqbrKvUdh3AZ6jV1JuMo9J22Es3GKbu2eohJMckjbL9QY9EoeUGHLIXDcA05pjoCQcegoGiQB+m4UPXnYJYHzlnMu6uljtavcqQgOB6THlXtD6M9iGNx6h0GpBC56FvLXgY2kTGJM6tYfr5tRE477eS8N2zDr5xnbABE7+qv6Jv2d8rEP4ar6PUPqo8nwuUmeZiwrCGRGApMKiuo4XIEjLWdArzgSLCHtwNqbrT+ifQ2x77YkFagJkVVA1pwcD3U1Qz0bHzBAScPqXmbt2agCzAYPR+L65F+v7g+Zc5vifN+bEp0mWczyol6unhRzdGjHAktqGO4/xw+cxwscrXvR8yWGYmRW6LXHEAaQiWA09OFomRSsRYMWL6msoKvhZRIIrFaWckflE8Q0iQ8sY0mFHKj8aYR2JGAJWrO8Xiwo1t/4K2fyjHWS/aK8LTY3XRxpbmpovzSwp3Eo785hlGoFGP14krdGWRTJWro1vP/C/+nqwU8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Base Address object used as billing address in a payment or extended for Shipping Address.
    */
    [DataContract]
    public class Address {

        // Required default constructor
        public Address() {}

        /**
        * REQUIRED
        * City name.
        */
        [DataMember(Name="city", EmitDefaultValue = false)]
        public string City { get; set; }

        /**
        * REQUIRED
        * 2 letter country code.
        */
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /**
        * REQUIRED
        * Line 1 of the Address (eg. number, street, etc).
        */
        [DataMember(Name="line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /**
        * Optional line 2 of the Address (eg. suite, apt #, etc.).
        */
        [DataMember(Name="line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /**
        * Phone number in E.123 format.
        */
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /**
        * Zip code or equivalent is usually required for countries that have them. For list of countries that do not have postal codes please refer to http://en.wikipedia.org/wiki/Postal_code.
        */
        [DataMember(Name="postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /**
        * 2 letter code for US states, and the equivalent for other countries.
        */
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State { get; set; }
    }
}

