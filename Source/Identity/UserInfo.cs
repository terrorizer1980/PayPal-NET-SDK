// This class was generated on Wed, 13 Dec 2017 14:32:41 CST by version 0.1 of Braintree SDK Generator
// UserInfo.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8SYzW7jNhDH732KgXroRXbcq29BfAmw6S62aQGjKBRaHFnTUkN1OMpWW/TdC1KSkXjtTYB6lVMicYb68U/OB/1Pdt+3mK2zLqAUxJXP8uxXI2R2Dn8yTRzK8myDoRRqlTxn6+x9iwy3G7jxzFgqRF+IvtKYaLK0vuwaZE1P74j/XNeq7frqyrfIZJeMehVaLMP4YlEOMy12JlC5+LFYLWtt3Pc/q2FrxN44Q03I8uxaxPQD8SrPPqKx79n12boyLmB88VdHgvbw4oP4FkUJQ7b+7bDWoEK8/3Khpix9x1poNDte9DUDctegpEWBr0BrhNEFoktY/k9C7pz7N3++JcZawRBOwB4GnnPe1wjINm3KDwFawQpF0MLosPzmMiZFpD9JNo5dWKlzJM6XxpGeQSHtwQtMRjMxtT6ocUXpLZ7E+kwtxMGINtimx5noBPcR5RRYUKOYQyv+kbhM/2GFpXaCeYQdXGfiDCqIWnwtCKrOORjsDmcfbgwDcek6iyl+a98FBO6aHQoYtpMDm+Yykv/+isWYPRZieH/6QEwppvbOppA2e4RkPpPWOxKtrVF8KdeMhn0OxPCw3W63i7u7xWbzAENpWEJ06NEI3F1vYYfwsFqtVg85fKqprIHYUmkUA2htNO1PMqYAviFVtEu49yDYCgZkBc+uP5jlESM9pU8fPjqPSNgYcq9PxriI9pfKyUeMO+8dGj4DWTyiUEVov6C9Pej/qUatUZKaT/jxKXTclmmqmUSuTEOuL2Jwnk5RncSxlI6cCUMYx4f4N+RT0Z5WNBP1HtmivHQ2Bqu5kOgR+byOaTipWJEEzZ/r+EYypjr9Yg4arGZCashah+d1HMZH9d5EtLNoTyRLhTIxEoOl0DrTxylSAh2rJfEezGTWGtGwhA8+BNq5fiqoAZTUYRjqaFdV9DcGCF40dp9l6SVNo/44rQx7ltyGDIlcXrybPtuPmT7efOxJlW43x41+Mp8LrfaMxdCcvL60KDpMnmNbMxcspVbwJOcvH98dn/+E7CtyCKPnXJ1jtztTO3Z/xMvs7Sae+2esMDYjFEI3m57DhfylYzkL4tl+Yir/xRgdJ2Eno0MIxYtEN1d4f/aM488aX40fpQYhGl+o6//uPwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Identity
{
    /// <summary>
    /// Open ID Connect user information.documentationLink:http://openid.net/specs/openid-connect-basic-1_0.html#StandardClaims
    /// </summary>
    [DataContract]
    public class UserInfo {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public UserInfo() {}

        /// <summary>
        /// An enumeration of the account types.
        /// </summary>
        [DataMember(Name="account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The end user's preferred address.
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public UserAddress Address { get; set; }

        /// <summary>
        /// The account holder's age range.
        /// </summary>
        [DataMember(Name="age_range", EmitDefaultValue = false)]
        public string AgeRange { get; set; }

        /// <summary>
        /// The end user's birthday, in `YYYY-MM-DD` format. The year MAY be `0000`, which indicates that the year is omitted. To represent only the year, use the `YYYY` format.
        /// </summary>
        [DataMember(Name="birthdate", EmitDefaultValue = false)]
        public string Birthdate { get; set; }

        /// <summary>
        /// The end user's preferred e-mail address.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the end user's email address is verified.
        /// </summary>
        [DataMember(Name="email_verified", EmitDefaultValue = false)]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// The surname, or last name or names, of the end user.
        /// </summary>
        [DataMember(Name="family_name", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// The end user's gender.
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// The given, or first, name or names of the end user.
        /// </summary>
        [DataMember(Name="given_name", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// The end user's locale.
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// The middle name of the end user.
        /// </summary>
        [DataMember(Name="middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The end user's full name in displayable form including all name parts. Possibly includes titles and suffixes sorted according to the end user's locale and preferences.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the account payer.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId { get; set; }

        /// <summary>
        /// The end user's preferred telephone number.
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The URL of the end user's profile picture.
        /// </summary>
        [DataMember(Name="picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// The subject ID for the end user at the issuer.
        /// </summary>
        [DataMember(Name="sub", EmitDefaultValue = false)]
        public string Sub { get; set; }

        /// <summary>
        /// The ID of the end user at the issuer.
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// The verified account status.
        /// </summary>
        [DataMember(Name="verified_account", EmitDefaultValue = false)]
        public bool VerifiedAccount { get; set; }

        /// <summary>
        /// The end user's time zone.
        /// </summary>
        [DataMember(Name="zoneinfo", EmitDefaultValue = false)]
        public string Zoneinfo { get; set; }
    }
}

