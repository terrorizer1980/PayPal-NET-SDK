// This class was generated on Mon, 11 Dec 2017 16:45:22 CST by version 0.1 of Braintree SDK Generator
// Templates.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7zTsU7DQAwG4J2nsDxHiIkhWySQGCpaQcSCGNzEIaaXu8N3RapQ3x1dqqaFNAMIdfXvRJ/j+BPLjWfMseTOG4ocMMMnUqGl4XvqUoQZ3nCoVHwUZzHHmYQIroGOtWrJRoj7hy8xw0KVNru3XmX4wFTPrdlg3pAJnArva1Guh8JCnWeNwgHz58FT1LVyOKGhXdBDT7OGDhB7MHp1jRj+Ibz+rdCujdlmAzNEFfs6VnJHYqaJu/gMvpnYFRwZYL584yqOwUbsauwtW4a7orydF4/Qd0Bsqbd+SM2gnLZeA1WpP0DjFGLLh/8hTZgKysE7G/57ukXrLI9n8ak8/fH7GOy6W7KeYwf70xpD49HRfbcWFigJknfquv7metlefAEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * List of merchant templates.
    */
    [DataContract]
    public class Templates {

        // Required default constructor
        public Templates() {}

        /**
        * List of addresses in merchant profile.
        */
        [DataMember(Name="addresses")]
        public List<Address> Addresses { get; set; }

        /**
        * List of emails in merchant profile.
        */
        [DataMember(Name="emails")]
        public List<string> Emails { get; set; }

        /**
        * The HATEOAS links that provide related actions for the templates in the response.
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * List of phone numbers in merchant profile.
        */
        [DataMember(Name="phones")]
        public List<Phone> Phones { get; set; }

        /**
        * An array of templates.
        */
        [DataMember(Name="templates")]
        public List<Template> Templates { get; set; }
    }
}

