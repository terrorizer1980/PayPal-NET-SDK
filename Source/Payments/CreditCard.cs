// This class was generated on Wed, 13 Dec 2017 14:31:38 CST by version 0.1 of Braintree SDK Generator
// CreditCard.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xYUVPbOBB+v1+xkz5c6SR2oHd94I1S2nIdCgOh95Bjko21xFtkyZXkhHDT/36zsklCk05Jj+aFwdJ+8rfr3W9X+bfVm5XU2m9ljhSHQYZOtdqtT+gYR5o+YiGbrXbrDfnMcRnYmtZ+q//m6Oz86PCgd/TmCg6gBoOAEzhEAyOCypOCYOG6MgoQSpwVZEICl54WjxECbHwgVEmr3TpwDmc1pW67dU6oTo2etfavUXuShS8VO1LzhTNnS3KBybf2+3NnUClH3q86MmKt2YwHC4OHfvVygsYGGhtgs0y/8Y5uAxlFCq6tA59zWS5Bns4RHxyb8aofGYfZWvKyAQYL+r8cTKX11/aPidjKBDcbZFbRWkL9MLWdLEeHWSAHxxen8HL31avOLgjk6nmqbOZTNoHGDgWXKnaUhdSRD2lzfEdsfboDIccArMgEvmbyEMTl2gasA0djtib5p+p2X2YjbbObL5UNFJ/rv5kPzppxvfLRBtqvl9PldegtHSuvjl/5nSMM8NpxQDbAHmqk7Newd6+bsxZLgEaBsWHF9vLDGltfFw2b6FewZUfThDQoW8gr5bP6SCWGoSFYV5QAhod7w1XahzkbhKl1Wk25WctsUaKTzwiVyawJzmpNCkrHGcHzw8uzHSgo5Fa1YYTmJpZpOzqTOet9Z2SdIgfBofGYyWfzTdTTb8O+SR4GV/1cGmo2tLs2/67Z+QCyD/Y6hum+SOGtdUC3WJSa2mCqYkSuDT44olD76i1Yk2zNgb0VB07jP6iTmJGeMmvUI3zxFQdqA5boQlTZe+d+zqmfVwdjXYGa72JhD3zAUK3X3HutfQCAGpDAOYXKGVJgjZ7FBC5xRs7DtbMFvHZ4x3pLHpW5NeuFLu7MI80G+kfJ7t5LoVtguHqeh1D6/TSdTqcJhyphIxqXpb3O+dFhJ9p29rrd3e5e5zgls5PACd5yURWgyYxDLorzZxfmUuq35bH1AfX3Bb7ej3rThmnOWWQqyXnHZS1DkptfKp6gji20Nys5Q61n4Bp+jSiJcomqTznk0nMXJ8sRaB6cckEE/bOFySLCZJIp33BJijGxbpzKU3q28GNnS6GT/P1OV3xM84vweeuTECFcXsSqiAGRGC8iEg1syGkpklI6SxFelmvgBwoi34wN2Lm0eFocsw/9AzeWpmtwE9LP8B6104Z+Xacb4UcRIuBDNKg2e3kWIQI+Noo3w7IgIjSgnm0GFYRA/8ISzUbQz4IQ6AndcmY3whYRIuBejqzRqI3goQHttCWz+peGAym4EBO/0UGVx7XS9UcXPJuxps5oFmj7MvaI5tO0m+3wCbK9jo1sSA2ub+3D96cnR4PT88Hfp+cfhm0Yvjt+2xs+dWe/eszkP5nsrXcgd0SdePWzlesoHjdXQ5igZlW3dsmWJ450TE9yq0zptmRHg8KakK9lHA1qXtGobkDGgiZUcq+7I2cT+IS6IsnlOHYMd4fi43B3b/i0I+KP/JgRuvWj7iLcSx6J+XZm2DhqD+SWsv5qKimQW63I/e6buXyLN1WNjycntr+Cm2ZzM1CLlw/s6DNlYe114GZVrA4MoJAReZDRiXzoONIoUt1/f9A7Oj24gAi9l2wsObUTchOmafosx0AWfSeafDsEvfpVd4A4Ea8P+uJno2ZwXioyUxXkOFvqFPX4f1+bvsSMvHSrsjJZqGK2J3BSebkaGxm7pT5lximsqrSNGtk0pPngOZoBYZY/oCIKnMCLc1Ly3ngfd+RLazz55MVWSum73WGV5zxgwwl7lJZQoA/kxESeFPtMUmAYO/sQC7p9EsG6+vrbfwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// [DEPRECATED] A credit card. Can be used to fund a payment. Use a payment card instead.
    /// </summary>
    [DataContract]
    public class CreditCard {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCard() {}

        /// <summary>
        /// The billing address in a payment. Can be extended for shipping address.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The three- to four-digit card validation code.
        /// </summary>
        [DataMember(Name="cvv2", EmitDefaultValue = false)]
        public string Cvv2 { get; set; }

        /// <summary>
        /// REQUIRED
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth { get; set; }

        /// <summary>
        /// REQUIRED
        /// The four-digit expiration year.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear { get; set; }

        /// <summary>
        /// The card holder's first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The card holder's last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// REQUIRED
        /// The credit card number. Value is numeric characters only with no spaces or punctuation. Must conform to the modulo and length required by each credit card type. *Redacted in responses.*
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// REQUIRED
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}

