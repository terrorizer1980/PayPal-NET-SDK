// This class was generated on Mon, 11 Dec 2017 13:16:25 CST by version 0.1 of Braintree SDK Generator
// PayeeDisplayMetadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7STT4vbPBDG7++nGHTJu2DZ8bak4Ftp97CH/mEbeglLmFiTWCCP1JHc1JR+96Jskl26LhSaHj2eZ/R7Hmm+q+UYSDUq4Ei0NjYGh+O6p4QGE6pCfUaxuHH0Hvvcpwr1lmIrNiTrWTVq2REcZdqzG+Gkha0XSB3BYXSpCvVaBMeH8+aFuiM0H9iNqtmii5QLXwYrZM6Fj+IDSbIUVbM6k8YklnfPyTaCbNacP6YYM4XMImyGaJlihNz5t1Q8OPejOKOd4gudZ3pO+OvvaUiaRTh0AA/9huTfJ9f6gZOM69abaaxV2nvddijYJhK4/TTXL+rFQtdwlEKW3v/fpRRiU1WGvpLLBGXAMaArW99XxrexspxoJ5hnV8YKtakSiqk6ztF5TqyuwG8fn84sno658HX9Lo+H3CeTsKxPlp/eUQGWYXVT1ouXx4rlHQSHnLegx/SYzX6/L20aSsvZelst9d3NG32Q6ut5Pa9rfXt1EaP3f2CVerRu0unhD6Axkpfl6S5LCe/wm+2HHhzxLnVgI9TXr+D8QuKF+P/7CQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * The display-only metadata for the payee.
    */
    [DataContract]
    public class PayeeDisplayMetadata {

        // Required default constructor
        public PayeeDisplayMetadata() {}

        /**
        * The payer's business name.
        */
        [DataMember(Name="brand_name")]
        public string BrandName { get; set; }

        /**
        * The payee's phone number.
        */
        [DataMember(Name="display_phone")]
        public DisplayPhone DisplayPhone { get; set; }

        /**
        * The email address for the payer. Maximum length is 127 characters.
        */
        [DataMember(Name="email")]
        public string Email { get; set; }
    }
}

