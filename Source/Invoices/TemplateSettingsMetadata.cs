// This class was generated on Wed, 13 Dec 2017 14:32:26 CST by version 0.1 of Braintree SDK Generator
// TemplateSettingsMetadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SOvUoEUQxGe58ipB7EejrBxsIfdLERi+zeb72BzJ0xySKD7LvLsO42U9p+5JycH97ME7jnDYbJJEGvyNT2GfSAlCIp3PGbuMrW8CjDcssd3yF2rlPq2Ba4gvIsiLNg+BNcc8e37jKfXt10/AIpT81m7vdigWX4OqijXIZnHyd4KoL790vkdhwN0tZFVUtBW3Xdt6I7SQR9V2SFU1YN2iuskAadsP/2tYPZ8eN49QsAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The template settings metadata.
    /// </summary>
    [DataContract]
    public class TemplateSettingsMetadata {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateSettingsMetadata() {}

        /// <summary>
        /// Indicates whether this field is hidden.
        /// </summary>
        [DataMember(Name="hidden", EmitDefaultValue = false)]
        public bool Hidden { get; set; }
    }
}

