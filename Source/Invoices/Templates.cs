// This class was generated on Wed, 13 Dec 2017 14:32:27 CST by version 0.1 of Braintree SDK Generator
// Templates.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7zTsU7DQAwG4J2nsDxHiIkhWySQGCpaQcSCGNzEIaaXu8N3RapQ3x1dqqaFNAMIdfXvRJ/j+BPLjWfMseTOG4ocMMMnUqGl4XvqUoQZ3nCoVHwUZzHHmYQIroGOtWrJRoj7hy8xw0KVNru3XmX4wFTPrdlg3pAJnArva1Guh8JCnWeNwgHz58FT1LVyOKGhXdBDT7OGDhB7MHp1jRj+Ibz+rdCujdlmAzNEFfs6VnJHYqaJu/gMvpnYFRwZYL584yqOwUbsauwtW4a7orydF4/Qd0Bsqbd+SM2gnLZeA1WpP0DjFGLLh/8hTZgKysE7G/57ukXrLI9n8ak8/fH7GOy6W7KeYwf70xpD49HRfbcWFigJknfquv7metlefAEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// List of merchant templates.
    /// </summary>
    [DataContract]
    public class Templates {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Templates() {}

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
        public List<Template> TemplateList { get; set; }
    }
}

