// This class was generated on Mon, 11 Dec 2017 13:16:18 CST by version 0.1 of Braintree SDK Generator
// ProcessorResponse.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8SUQU/cPhDF7/9PMfLlD1IgPe8toud2xaJcEFrN2m+JJcc2M05WoeK7V2G7WypKW5WWHu2MMvN7z/M+maspwyxMlmShmmQt0JyiwlSmZfG8CfjA/VxjKvMeasXn4lM0C9OQTSHAzkdKW8o89YiFDr84EwQucLT1CE5JUAaJ81lST/yk/m6AlnNTmUaEp/1M7ypzCXYfY5jMYstBMV/cDV7gjhdLSRlSPNQsro80WsTH2+cE7EZvsbbJ4RnMVQfqIbbjWGhfSClSl3ZUEnUcXQA52OAjlLZJSGAHmRsdQPS1BHEI4aH6OcaoLzNcN84JVKmF+K23/OjOatKCnk6adnV6c9KVknVR1w4jwtz+PPOUOZzb1Nc7bDhn/fqxdslqbQOreltz9nXTri6/eHyRHLQ+PXpO82BvpIMdxx/ocNG2f4VU91L+C2BYv9Zh0/tS4L5Lfdzjsyxp9A6OeChdEn+/fwiHsd9o4kO7l31a8rTkQDFJz8Hfw32rbEW7ztuOvNItImSfJ3N+lKe4/ytphp0f/CucKTL8HuaYWX/Vj9Yrz9QQaobSIZbjkkIeY0cLl+HPhMnNw3+fAQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * A collection of payment response-related fields returned from a payment request.
    */
    [DataContract]
    public class ProcessorResponse {

        // Required default constructor
        public ProcessorResponse() {}

        /**
        * The merchant advice on how to handle declines for recurring payments.
        */
        [DataMember(Name="advice_code")]
        public string AdviceCode { get; set; }

        /**
        * The [Address Verification System (AVS)](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) response code.
        */
        [DataMember(Name="avs_code")]
        public string AvsCode { get; set; }

        /**
        * The [CVV](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) system response code.
        */
        [DataMember(Name="cvv_code")]
        public string CvvCode { get; set; }

        /**
        * The processor-provided authorization response.
        */
        [DataMember(Name="eci_submitted")]
        public string EciSubmitted { get; set; }

        /**
        * REQUIRED
        * The PayPal normalized response code, which is generated from the processor's specific response code.
        */
        [DataMember(Name="response_code")]
        public string ResponseCode { get; set; }

        /**
        * The processor-provided Visa Payer Authentication Service status.
        */
        [DataMember(Name="vpas")]
        public string Vpas { get; set; }
    }
}

