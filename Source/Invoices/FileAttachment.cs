// This class was generated on Wed, 13 Dec 2017 14:32:18 CST by version 0.1 of Braintree SDK Generator
// FileAttachment.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zOsUoEQQwG4N6nCKkHsd7uQKxE5ThtxCI3k3UCs5k1m/VY5N5dRuEQXLDwqsCf/OT7wN0yMnZ4I4Vh404xD6yOAZ/IhPaF72hoBxjwmqdoMrpUxQ53maFvLfpqcQKvQAqi71UiQzVwHsZCzpcYcGNGy/ezq4BbpnSvZcGupzJxC95mMU6n4MHqyObCE3bPJ+bkJvr6W6dtrAnbAmoPnn9AG/u/Jp1LOYY/YbOVVdfj9naVFeCQJWaIpLBnSPWgpVLidBbvy/HiEwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The file attached to an invoice or template.
    /// </summary>
    [DataContract]
    public class FileAttachment {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FileAttachment() {}

        /// <summary>
        /// The name of the attached file.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The URL of the attached file, which can be downloaded.
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue = false)]
        public string Url { get; set; }
    }
}

