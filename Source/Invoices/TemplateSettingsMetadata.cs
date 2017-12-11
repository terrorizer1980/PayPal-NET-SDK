// This class was generated on Mon, 11 Dec 2017 16:45:20 CST by version 0.1 of Braintree SDK Generator
// TemplateSettingsMetadata.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SOvUoEUQxGe58ipB7EejrBxsIfdLERi+zeb72BzJ0xySKD7LvLsO42U9p+5JycH97ME7jnDYbJJEGvyNT2GfSAlCIp3PGbuMrW8CjDcssd3yF2rlPq2Ba4gvIsiLNg+BNcc8e37jKfXt10/AIpT81m7vdigWX4OqijXIZnHyd4KoL790vkdhwN0tZFVUtBW3Xdt6I7SQR9V2SFU1YN2iuskAadsP/2tYPZ8eN49QsAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The template settings metadata.
    */
    [DataContract]
    public class TemplateSettingsMetadata {

        // Required default constructor
        public TemplateSettingsMetadata() {}

        /**
        * Indicates whether this field is hidden.
        */
        [DataMember(Name="hidden")]
        public bool Hidden { get; set; }
    }
}

