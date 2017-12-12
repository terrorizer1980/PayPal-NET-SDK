// This class was generated on Tue, 12 Dec 2017 12:38:03 CST by version 0.1 of Braintree SDK Generator
// UserInfo.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8SYzW7jNhDH732KgXroRXbcq29BfAmw6S62aQGjKBRaHFnTUkN1OMpWW/TdC1KSkXjtTYB6lVMicYb68U/OB/1Pdt+3mK2zLqAUxJXP8uxXI2R2Dn8yTRzK8myDoRRqlTxn6+x9iwy3G7jxzFgqRF+IvtKYaLK0vuwaZE1P74j/XNeq7frqyrfIZJeMehVaLMP4YlEOMy12JlC5+LFYLWtt3Pc/q2FrxN44Q03I8uxaxPQD8SrPPqKx79n12boyLmB88VdHgvbw4oP4FkUJQ7b+7bDWoEK8/3Khpix9x1poNDte9DUDctegpEWBr0BrhNEFoktY/k9C7pz7N3++JcZawRBOwB4GnnPe1wjINm3KDwFawQpF0MLosPzmMiZFpD9JNo5dWKlzJM6XxpGeQSHtwQtMRjMxtT6ocUXpLZ7E+kwtxMGINtimx5noBPcR5RRYUKOYQyv+kbhM/2GFpXaCeYQdXGfiDCqIWnwtCKrOORjsDmcfbgwDcek6iyl+a98FBO6aHQoYtpMDm+Yykv/+isWYPRZieH/6QEwppvbOppA2e4RkPpPWOxKtrVF8KdeMhn0OxPCw3W63i7u7xWbzAENpWEJ06NEI3F1vYYfwsFqtVg85fKqprIHYUmkUA2htNO1PMqYAviFVtEu49yDYCgZkBc+uP5jlESM9pU8fPjqPSNgYcq9PxriI9pfKyUeMO+8dGj4DWTyiUEVov6C9Pej/qUatUZKaT/jxKXTclmmqmUSuTEOuL2Jwnk5RncSxlI6cCUMYx4f4N+RT0Z5WNBP1HtmivHQ2Bqu5kOgR+byOaTipWJEEzZ/r+EYypjr9Yg4arGZCashah+d1HMZH9d5EtLNoTyRLhTIxEoOl0DrTxylSAh2rJfEezGTWGtGwhA8+BNq5fiqoAZTUYRjqaFdV9DcGCF40dp9l6SVNo/44rQx7ltyGDIlcXrybPtuPmT7efOxJlW43x41+Mp8LrfaMxdCcvL60KDpMnmNbMxcspVbwJOcvH98dn/+E7CtyCKPnXJ1jtztTO3Z/xMvs7Sae+2esMDYjFEI3m57DhfylYzkL4tl+Yir/xRgdJ2Eno0MIxYtEN1d4f/aM488aX40fpQYhGl+o6//uPwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Identity
{
    /**
    * Open ID Connect user information.documentationLink:http://openid.net/specs/openid-connect-basic-1_0.html#StandardClaims
    */
    [DataContract]
    public class UserInfo {

        // Required default constructor
        public UserInfo() {}

        /**
        * An enumeration of the account types.
        */
        [DataMember(Name="account_type")]
        public string AccountType { get; set; }

        /**
        * The end user's preferred address.
        */
        [DataMember(Name="address")]
        public UserAddress Address { get; set; }

        /**
        * The account holder's age range.
        */
        [DataMember(Name="age_range")]
        public string AgeRange { get; set; }

        /**
        * The end user's birthday, in `YYYY-MM-DD` format. The year MAY be `0000`, which indicates that the year is omitted. To represent only the year, use the `YYYY` format.
        */
        [DataMember(Name="birthdate")]
        public string Birthdate { get; set; }

        /**
        * The end user's preferred e-mail address.
        */
        [DataMember(Name="email")]
        public string Email { get; set; }

        /**
        * Indicates whether the end user's email address is verified.
        */
        [DataMember(Name="email_verified")]
        public bool EmailVerified { get; set; }

        /**
        * The surname, or last name or names, of the end user.
        */
        [DataMember(Name="family_name")]
        public string FamilyName { get; set; }

        /**
        * The end user's gender.
        */
        [DataMember(Name="gender")]
        public string Gender { get; set; }

        /**
        * The given, or first, name or names of the end user.
        */
        [DataMember(Name="given_name")]
        public string GivenName { get; set; }

        /**
        * The end user's locale.
        */
        [DataMember(Name="locale")]
        public string Locale { get; set; }

        /**
        * The middle name of the end user.
        */
        [DataMember(Name="middle_name")]
        public string MiddleName { get; set; }

        /**
        * The end user's full name in displayable form including all name parts. Possibly includes titles and suffixes sorted according to the end user's locale and preferences.
        */
        [DataMember(Name="name")]
        public string Name { get; set; }

        /**
        * The ID of the account payer.
        */
        [DataMember(Name="payer_id")]
        public string PayerId { get; set; }

        /**
        * The end user's preferred telephone number.
        */
        [DataMember(Name="phone_number")]
        public string PhoneNumber { get; set; }

        /**
        * The URL of the end user's profile picture.
        */
        [DataMember(Name="picture")]
        public string Picture { get; set; }

        /**
        * The subject ID for the end user at the issuer.
        */
        [DataMember(Name="sub")]
        public string Sub { get; set; }

        /**
        * The ID of the end user at the issuer.
        */
        [DataMember(Name="user_id")]
        public string UserId { get; set; }

        /**
        * The verified account status.
        */
        [DataMember(Name="verified_account")]
        public bool VerifiedAccount { get; set; }

        /**
        * The end user's time zone.
        */
        [DataMember(Name="zoneinfo")]
        public string Zoneinfo { get; set; }
    }
}

