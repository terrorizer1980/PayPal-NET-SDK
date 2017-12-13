// This class was generated on Wed, 13 Dec 2017 12:24:23 CST by version 0.1 of Braintree SDK Generator
// TemplateSettings.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6zRPWvzQAwH8P35FOJm89A5W6FLh77Qhi6lJIpPzgnOuqukEEzJdy/OWwe3UGhGy/rLP0sfYT5UCrMwp75mdIJncmdZW2jCCyrjKtM99mNLaMINWatcnYuMmUTgp5wdc/9DE65VcTgMvmrCE2F8kDyEWYfZaCy8b1gpnguPWiqpM1mYvf5MgjtyjOg4tUW2mnFYVKWOlKSl32mhP468HHtVSiaUqTFxjCQT161EbtHJYJvIEyl4YoOOKUdgg0Psrz7Z5Lx72zVnprmyrKfK/XcXMj58t8EDa3wNXVFAGU5SgeVpvYtxo8t9wzZxm8AL9FihLapktUhkWcPxZvB1M7vQX/77BAAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The template settings.
    */
    [DataContract]
    public class TemplateSettings {

        // Required default constructor
        public TemplateSettings() {}

        /**
        * The template settings metadata.
        */
        [DataMember(Name="display_preference", EmitDefaultValue = false)]
        public TemplateSettingsMetadata DisplayPreference { get; set; }

        /**
        * The field name for any field in `template_data` for which to map corresponding display preferences.
        */
        [DataMember(Name="field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }
    }
}

