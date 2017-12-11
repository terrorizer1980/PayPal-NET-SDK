// This class was generated on Mon, 11 Dec 2017 16:45:17 CST by version 0.1 of Braintree SDK Generator
// LinkDescriptionObject.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7yUT2/UQAzF73wKa04ghaZCiMPeKv6oh4pd7QYuVQ9OxukMnZ2Z2o4gQv3uaJKytCISf1Tt1XaS33t+znfTjJnMylz4eAPvSDr2WX2KsG6/UKemMp+RPbaBPuK+DJrKPBgzK9M4gsvzs+b9+mwHwccbuXpe29RJjdnXDpUSysupUb8ApoBKFjSBOgKm24FET0xlzphxnGlOK7MltOsYRrPqMQiVwu3gmeyhsOGUidWTmNXlQYco+3j9OzbFbppYot+T9Qg6ZgIf4avznSt8MrR7r2BRsdSfEDcOIdxVf2R2TP0i8KftBaT+nmj28+ECCvwgkxgZWinMUaHDEOSfyJWH/wOfDP0LuytAAUu9j2ShHWH74S28On39pgJ1qGCnR1uSSemsDPmajuX/ntQlu6jhvGk2MPenUJRPQZ/40U6K40dCZQqLnBNKOef7e5v9AyZJA3f0M0XF2xPYuTQECy1BiocWfVOKluzs/6/3jZke7W6zQdyVyDnVLKu6zhlR5h+BKEaLbKV2YyaeAnCUIKrXsBzCOU2l/SQburp79gMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * The [HATEOAS links](/docs/api/hateoas-links/) related to the request.
    */
    [DataContract]
    public class LinkDescriptionObject {

        // Required default constructor
        public LinkDescriptionObject() {}

        /**
        * The media type in which to submit data in the request.
        */
        [DataMember(Name="encType")]
        public string EncType { get; set; }

        /**
        * REQUIRED
        * The URL of the related HATEOAS link to use in subsequent calls.
        */
        [DataMember(Name="href")]
        public string Href { get; set; }

        /**
        * The media type, as defined by RFC 2046, that describes the link target.
        */
        [DataMember(Name="mediaType")]
        public string MediaType { get; set; }

        /**
        * The HTTP method required for the related call.
        */
        [DataMember(Name="method")]
        public string Method { get; set; }

        /**
        * REQUIRED
        * The relation to the target resource of the link. Should be one of the extended link relation types defined by PPaaS in https://ppaas/docs/standards/hypermedia
        */
        [DataMember(Name="rel")]
        public string Rel { get; set; }

        /**
        * The link title.
        */
        [DataMember(Name="title")]
        public string Title { get; set; }
    }
}

