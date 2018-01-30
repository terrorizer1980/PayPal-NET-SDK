// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// PayerInformation.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/+xZzXLbRgy+9ykwyqHxjChKcpJOfEucn7qZxB7/tAfXI6+4kIhmucvsgpGVTmb6Gn29Pklnl9QPTamxEo+agy6ZCMC3BEAQWHz+s3U+zbF10MrFFO2A9MjYTDAZ3Wq3fhWWxFDhO5F5k1a79Qanix8v0CWW8mB80DpPEcIhsHRIp9VuPbNWTMundNutUxTyWKtp62AklEMv+FCQRTkXnFiTo2VC1zq4nPsnpLToXNOrISlFejxYGCycbOqaPlc2UNkAaRA+kAw1d+BQaBgi4A2jlihhZCy4lPJ8CXJ/QTq2pMfNGBPiaS2wStCMxitAiwy/1SldKPW5/WXPTKHZTgeJkVj3sK5oenrJExMlqbAiYbRwdHYM+70nT6IeeMjVw1iaxMWkGcc21FIsyWLCsUXHcXV85G1dvAecCgaSqJlGhA7Y56K0AWPB4thX4+9Ft7ufDJVJ3n8oDGP4Xf6bOLZGj0vJO8N4UIrjZTmcLx3rHx3q4bVFwfDcEgvSQA5KpNeXsNfPq7MWIhBagjbcsL14s8LWQeFQ+tL0cbHJI4UfUYE0mX+kf98uuBLSUDnYgQuHAXB92L9uun2YkhYwMVbJCVWyxGS5sP79QqETo9kapVBCbilBeHh4cbIHGXJqZBuGQr+HRFjZDsEk1jgXDY2VaIGt0E4k/rW5Kuvx7bRvUqBsi6+rT0Uae7XCnEmaFTki6xi8HswoJG72gcMrYwFvRJYrbIMusiHaNji2iFxG7wxs2O2+KaR+I6R+I6Tj8B+hOqFqHSZGyztE5wpibIPIhWXfA+fhfl2YX99atB8iij6Fj3/gWHBR7+5rDJovdtbaawAoAR04RS6sRglGq2n4CsIYczCyJoPnVnwitaWQ89ToehudSVbMWq+ZvxzScPmy0+vvQzl7rx6mzLk7iOPJZNIhLjqkfetM4vPo9OVhFGyjfrfb6/ajoxj1XgfeihvKigwU6jGnvpE97sK8Q7tt5cA4Fqo5UOryFfkI+tDe2jBJKQkR+Dr/RHnZ9XyZfyjoo1Bhtp9Pc0qEUlOwld9VD/SN0g+RCXHqLwOLk/0RQtdOOUOEy5OFySLzqDsTek85ShIdY8ex/xWfLOLY21JKfaXXkzmTrBjLd5m+AT6fvT5pAi7OwhcVUuSzvshRMDCc4lJu/We3lPPleQFUa0/+LZIGM+9bDhfHHMDlMzv2U1+LTZx+IGaovTZclt/4RvhhgHjwodBCbvbwJEA8+EhL2gxLHhGgLNR0M6hHeOgvIhd6I+gfHuGhb/GGErMRNgsQDz5PBSmh5UZwrkB7bV9ZlxeaGCWceRO30UGFEyub3KMuONJjhdFwyrj9hrdist1hllXTazsuslcvO1gJmu55hf9OV98trn8+fvtycHw6+O349M11G65fH706v77vq8XVHSIakuV0IG/3xZp41a5oOQUZulzZpMJVoRy/R5rRauRSf3sMszHKdQh5FEZBypmK7SjZ399/+sBh6HzR486TvdsZ6z192o26j6Je//q7X+lCMn50zdWuG81Xu8USsuGKt6XoMROkamHPJOvjDRaLkm+2mF7/p+33lbDODPxuWAunJl4fU7kMbZFJUGKVt8vS9c56q236mpGUCpve1uXr/S3ttulxRe/J+pV6IWz6eiKmJ0JFwjka++0IdWKnuZ+9Jct39OJ7XIqqBC8vR6s+yP7/sdh4nwaNUVoTr1vzvHpb1xGhCp4xwEtXkmXx+sQvzO7b3Yp0HawlgldYLLnfVDaDmLO8ldHSHhn4N1Huk7f53zplvCODd2TwjgzekcE7MnhHBu/I4B0Z/L2RwRYTygn1imWroWom1itmLWNuDoKBU3L39QfxHa29o7V3tPaO1t7R2pvS2q4YjeimnvSZ6D+W9mCyraSLm9s81Fy0xsV//vrbAYsbOHrRgbMiz43lWYedM1WzBbxaScIFbqshNamduvzLwZU0z/YjvPr8w78AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payer information.
    /// </summary>
    [DataContract]
    public class PayerInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayerInformation() {}

        /// <summary>
        /// The billing address in a payment. Can be extended for shipping address.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public Address BillingAddress;

        /// <summary>
        /// The birth date of the payer, in [Internet date format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `1990-04-12`.
        /// </summary>
        [DataMember(Name="birth_date", EmitDefaultValue = false)]
        public string BirthDate;

        /// <summary>
        /// The payer's [two-character IS0-3166-1 country code](/docs/integration/direct/rest/country-codes/).
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        /// <summary>
        /// The payer's email address. Maximum length is 127 characters.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email;

        /// <summary>
        /// The payer's first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName;

        /// <summary>
        /// The payer's last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName;

        /// <summary>
        /// The payer's middle name.
        /// </summary>
        [DataMember(Name="middle_name", EmitDefaultValue = false)]
        public string MiddleName;

        /// <summary>
        /// The PayPal-assigned encrypted payer ID.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId;

        /// <summary>
        /// The payer's phone number. Maximum length is 20 characters.
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue = false)]
        public string Phone;

        /// <summary>
        /// The phone type.
        /// </summary>
        [DataMember(Name="phone_type", EmitDefaultValue = false)]
        public string PhoneType;

        /// <summary>
        /// The payer's salutation.
        /// </summary>
        [DataMember(Name="salutation", EmitDefaultValue = false)]
        public string Salutation;

        /// <summary>
        /// The extended address, which is used as the shipping address in a payment.
        /// </summary>
        [DataMember(Name="shipping_address", EmitDefaultValue = false)]
        public ShippingAddress ShippingAddress;

        /// <summary>
        /// The payer's suffix.
        /// </summary>
        [DataMember(Name="suffix", EmitDefaultValue = false)]
        public string Suffix;

        /// <summary>
        /// The payer’s tax ID. Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="tax_id", EmitDefaultValue = false)]
        public string TaxId;

        /// <summary>
        /// The payer’s tax ID type. Supported for the PayPal payment method only.
        /// </summary>
        [DataMember(Name="tax_id_type", EmitDefaultValue = false)]
        public string TaxIdType;
    }
}

