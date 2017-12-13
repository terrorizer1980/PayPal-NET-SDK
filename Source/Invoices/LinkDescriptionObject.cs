// This class was generated on Wed, 13 Dec 2017 14:32:21 CST by version 0.1 of Braintree SDK Generator
// LinkDescriptionObject.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUT2/UQAzF73wKa04ghaZCiMPeKv6oh4pd7QYuVQ9OxukMnZ2Z2o4gQv3uaJKytCISf1Tt1XaS33t+znfTjJnMylz4eAPvSDr2WX2KsG6/UKemMp+RPbaBPuK+DJrKPBgzK9M4gsvzs+b9+mwHwccbuXpe29RJjdnXDpUSysupUb8ApoBKFjSBOgKm24FET0xlzphxnGlOK7MltOsYRrPqMQiVwu3gmeyhsOGUidWTmNXlQYco+3j9OzbFbppYot+T9Qg6ZgIf4avznSt8MrR7r2BRsdSfEDcOIdxVf2R2TP0i8KftBaT+nmj28+ECCvwgkxgZWinMUaHDEOSfyJWH/wOfDP0LuytAAUu9j2ShHWH74S28On39pgJ1qGCnR1uSSemsDPmajuX/ntQlu6jhvGk2MPenUJRPQZ/40U6K40dCZQqLnBNKOef7e5v9AyZJA3f0M0XF2xPYuTQECy1BiocWfVOKluzs/6/3jZke7W6zQdyVyDnVLKu6zhlR5h+BKEaLbKV2YyaeAnCUIKrXsBzCOU2l/SQburp79gMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The [HATEOAS links](/docs/api/hateoas-links/) related to the request.
    /// </summary>
    [DataContract]
    public class LinkDescriptionObject {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkDescriptionObject() {}

        /// <summary>
        /// The media type in which to submit data in the request.
        /// </summary>
        [DataMember(Name="encType", EmitDefaultValue = false)]
        public string EncType { get; set; }

        /// <summary>
        /// REQUIRED
        /// The URL of the related HATEOAS link to use in subsequent calls.
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// The media type, as defined by RFC 2046, that describes the link target.
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// The HTTP method required for the related call.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// REQUIRED
        /// The relation to the target resource of the link. Should be one of the extended link relation types defined by PPaaS in https://ppaas/docs/standards/hypermedia
        /// </summary>
        [DataMember(Name="rel", EmitDefaultValue = false)]
        public string Rel { get; set; }

        /// <summary>
        /// The link title.
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue = false)]
        public string Title { get; set; }
    }
}

