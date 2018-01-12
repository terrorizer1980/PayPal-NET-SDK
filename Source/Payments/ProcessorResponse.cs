// This class was generated on Wed, 13 Dec 2017 14:31:46 CST by version 0.1 of Braintree SDK Generator
// ProcessorResponse.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8SUQU/cPhDF7/9PMfLlD1IgPe8toud2xaJcEFrN2m+JJcc2M05WoeK7V2G7WypKW5WWHu2MMvN7z/M+maspwyxMlmShmmQt0JyiwlSmZfG8CfjA/VxjKvMeasXn4lM0C9OQTSHAzkdKW8o89YiFDr84EwQucLT1CE5JUAaJ81lST/yk/m6AlnNTmUaEp/1M7ypzCXYfY5jMYstBMV/cDV7gjhdLSRlSPNQsro80WsTH2+cE7EZvsbbJ4RnMVQfqIbbjWGhfSClSl3ZUEnUcXQA52OAjlLZJSGAHmRsdQPS1BHEI4aH6OcaoLzNcN84JVKmF+K23/OjOatKCnk6adnV6c9KVknVR1w4jwtz+PPOUOZzb1Nc7bDhn/fqxdslqbQOreltz9nXTri6/eHyRHLQ+PXpO82BvpIMdxx/ocNG2f4VU91L+C2BYv9Zh0/tS4L5Lfdzjsyxp9A6OeChdEn+/fwiHsd9o4kO7l31a8rTkQDFJz8Hfw32rbEW7ztuOvNItImSfJ3N+lKe4/ytphp0f/CucKTL8HuaYWX/Vj9Yrz9QQaobSIZbjkkIeY0cLl+HPhMnNw3+fAQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A collection of payment response-related fields returned from a payment request.
    /// </summary>
    [DataContract]
    public class ProcessorResponse {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public ProcessorResponse() {}

        /// <summary>
        /// The merchant advice on how to handle declines for recurring payments.
        /// </summary>
        [DataMember(Name="advice_code", EmitDefaultValue = false)]
        public string AdviceCode { get; set; }

        /// <summary>
        /// The [Address Verification System (AVS)](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) response code.
        /// </summary>
        [DataMember(Name="avs_code", EmitDefaultValue = false)]
        public string AvsCode { get; set; }

        /// <summary>
        /// The [CVV](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) system response code.
        /// </summary>
        [DataMember(Name="cvv_code", EmitDefaultValue = false)]
        public string CvvCode { get; set; }

        /// <summary>
        /// The processor-provided authorization response.
        /// </summary>
        [DataMember(Name="eci_submitted", EmitDefaultValue = false)]
        public string EciSubmitted { get; set; }

        /// <summary>
        /// REQUIRED
        /// The PayPal normalized response code, which is generated from the processor's specific response code.
        /// </summary>
        [DataMember(Name="response_code", EmitDefaultValue = false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The processor-provided Visa Payer Authentication Service status.
        /// </summary>
        [DataMember(Name="vpas", EmitDefaultValue = false)]
        public string Vpas { get; set; }
    }
}

