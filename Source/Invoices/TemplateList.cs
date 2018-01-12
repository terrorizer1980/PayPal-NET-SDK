// This class was generated on Mon, 08 Jan 2018 16:45:03 CST by version 0.1 of Braintree SDK Generator
// TemplateList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yTQUvzQBCG79+vGOacTzx5yC2gIFhs0eBFPGyTiRm72ayzWyFI/7tsa7ddEw+K9JjnHZLn3Z28YzlYwhw9dVYrT/81O48ZPihhtdR0q7oQY4Y3NBweLslVwtZzbzDHGTsPfQMdSdUq42H/NneGGRYiath95jzDO1L13OgB80ZpRwG8rlmojmAhvSXxTA7zxyhY1LWQc2M1tQvIJY7HdFo2TgCbg7mVvmFNX7wvfupt1lpvsijvvLB5HrtTp1in4hFNW+/iEyjP2KzgyAHmyxeqJlZDs1mlFfYkbVC2BNdFeTUv7mE7Ab5VW/s3rgmEwsLUoKow76DpBXxLh1UKnQMQcrY37q/7Ltre0LidDTitF9H0DW1jMOtuSXKKiyo/D2jsHo8u0T+maYPCgApeocV3f/DvbJ82/z4AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// List of merchant templates.
    /// </summary>
    [DataContract]
    public class TemplateList {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public TemplateList() {}

        /// <summary>
        /// List of addresses in merchant profile.
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// List of emails in merchant profile.
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue = false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// The HATEOAS links that provide related actions for the templates in the response.
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// List of phone numbers in merchant profile.
        /// </summary>
        [DataMember(Name="phones", EmitDefaultValue = false)]
        public List<Phone> Phones { get; set; }

        /// <summary>
        /// An array of templates.
        /// </summary>
        [DataMember(Name="templates", EmitDefaultValue = false)]
        public List<Template> Templates { get; set; }
    }
}

