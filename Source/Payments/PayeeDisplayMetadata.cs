// This class was generated on Wed, 13 Dec 2017 14:31:43 CST by version 0.1 of Braintree SDK Generator
// PayeeDisplayMetadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7STT4vbPBDG7++nGHTJu2DZ8bak4Ftp97CH/mEbeglLmFiTWCCP1JHc1JR+96Jskl26LhSaHj2eZ/R7Hmm+q+UYSDUq4Ei0NjYGh+O6p4QGE6pCfUaxuHH0Hvvcpwr1lmIrNiTrWTVq2REcZdqzG+Gkha0XSB3BYXSpCvVaBMeH8+aFuiM0H9iNqtmii5QLXwYrZM6Fj+IDSbIUVbM6k8YklnfPyTaCbNacP6YYM4XMImyGaJlihNz5t1Q8OPejOKOd4gudZ3pO+OvvaUiaRTh0AA/9huTfJ9f6gZOM69abaaxV2nvddijYJhK4/TTXL+rFQtdwlEKW3v/fpRRiU1WGvpLLBGXAMaArW99XxrexspxoJ5hnV8YKtakSiqk6ztF5TqyuwG8fn84sno658HX9Lo+H3CeTsKxPlp/eUQGWYXVT1ouXx4rlHQSHnLegx/SYzX6/L20aSsvZelst9d3NG32Q6ut5Pa9rfXt1EaP3f2CVerRu0unhD6Axkpfl6S5LCe/wm+2HHhzxLnVgI9TXr+D8QuKF+P/7CQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// The display-only metadata for the payee.
    /// </summary>
    [DataContract]
    public class PayeeDisplayMetadata {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public PayeeDisplayMetadata() {}

        /// <summary>
        /// The payer's business name.
        /// </summary>
        [DataMember(Name="brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// The payee's phone number.
        /// </summary>
        [DataMember(Name="display_phone", EmitDefaultValue = false)]
        public DisplayPhone DisplayPhone { get; set; }

        /// <summary>
        /// The email address for the payer. Maximum length is 127 characters.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }
    }
}

