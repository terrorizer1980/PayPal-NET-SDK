// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// ShippingInformation.cs
// @version 0.1.0-dev+27d306
// @type object
// @data H4sIAAAAAAAC/+xX32/bNhB+319x0B5WA7KVtkMf/JamWNEVbYMm2YsXtGfybN1CkSp5qqMO/d8HUop/xEEbbUWAAX4x4ON9p7vjx4+8v7PztqZsmp2VXNdsl/DKLpyvUNjZLM/+QM84N/QWq+iV5dlrajd/XlBQnuvkPM3OS4JwE4c3cSZZnh17j233raM8e0+o31nTZtMFmkDR8KlhT3ptOPWuJi9MIZvONllyVRuCUxcEDRxr7SmE/TRxvbDJdmPbTfoYQhe07oL2frBiKUE59IHGS49sScOCyegwgRcOrBNoAsHCeUALbIW8TdVuYkzgoveYo7paodegXFWj8JwNSwvOmjZGo5DiKWcF2UJdOks/rmlBPNvlfpcUS7vTot6wv6lxASxWw5IS39zKyTbGfM2/n5hrrPj2g3KadhPcXdhPdCYrN1YlelRCHl6dvYOnj589Gz+GCLl8VGinQhE3a+nTZhWaPSkpPAUp+vDj6BuKEUiJAqzJCi+YAkhsRecDzoOnZST3n83R0VM1N05dfWqcUPrf/aog3tllZ3nrhKadudi2w/lW2PjpxJiXnlDguefECA7QIeN6B3v5vI+1MQFanYh02/fi9R2+IfJXA9tUl7h6bOgzGdCuip+M2x1SKqkNfYIdpSPg48mTj/tpn5RsEVbOG73i3pY47+P+QmMjx70zhjTUnhXBo5OL0xFUJKXTOczRXoFCr/NUjPIuhPHceU0exKMNqOK2hb7rxe22Pwg/DVt6vEPMG8s+Ixfsg0BcB7dIjVuLw2/OA11jFJ8cbFPNyecQxBNJV31wMFA8/1NJT/ZKerJX0ru6k7hJYm0g5ay+R3WhYaEcsEYvFVlZl/vvyrxD7u5ZZyfy+8qya9/fxv5yiOs5rEpWZTyTseAvXHf0j/V+avgzGrIygfO2ZoXGtOD7vPvDEE9MVJN0weB2ZOjuku0oZ0Qw23K5fFSK1GFaFGQnK77imjTjxPllEf8Vp5s6Rg/U0iAou828sdyhz/eR4QRfi3C6YOHiDJIZkh7RVo+Sg5OStno7gffbPd8WDuAdnsZdZAtuTeBAmzBTmB37ZZR/i0OS/hlvUKMcZs89fmEzCD9PkAg+QYt62MdVgkTwK6t5GJYjIkEFTTsMGhER+jvWaAdB/4qICH1D16zcIGyVIBF8XiIbtHoQXHrQKI/Mml1YFtJwFl3CoEBNwNEE3uA1V00FhuxSkkT8egSB7dLQeN4KwfptEn7I6by8x/nsrtadA7o2feP93vn0b6AAGIJTjLE7Sbik5ADpXn4gmYnvkZ0iesN+CZ4U10xWfgnDH63fT/CeM0h3N6JvP9y09MNdY8k33Q6TymFSOUwqh0nlMKkcJpXDpHKYVA6TymFS+d9OKpdff/oHAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// The shipping information.
    /// </summary>
    [DataContract]
    public class ShippingInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingInformation() {}

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public SimplePostalAddress Address;

        /// <summary>
        /// The shipping method that is associated with this order.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method;

        /// <summary>
        /// The recipient's name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [DataMember(Name="secondary_shipping_address", EmitDefaultValue = false)]
        public SimplePostalAddress SecondaryShippingAddress;
    }
}

