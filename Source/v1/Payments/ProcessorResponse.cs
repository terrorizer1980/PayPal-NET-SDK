// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// ProcessorResponse.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/8SUz27bMAzG73sKQpe1gBvvnJvR3QZsQVP4UhQBIzG1AFlSSdmBO/TdBzXNH9cFNqxbe+RHwubvI8Wf6nqIpOYqctAkEnjFJDF4IVWoGtni2tF3bHONKtQ3Go7BVxLNNiYbvJqrCnRwjnQOIWwg4tCST7D/3gWTw0QGNpacEWBKHfscc2gBT+rvO5I0U4WqmHHYNfilUFeE5od3g5pv0All4b6zTOYgLDhE4mRJ1PzmgCaJrb+b4qDpraaVDoZGZGN9DHndELTEukGfYFcIwUMTtpACNOiNIzCknfUksAkMTLrj3MAeUN5K5jvnHovf4/XyCttRnILdVMYwiUBNbDdW49Mol4MkauGsqpfnt2dNSlHmZWmoJ5d7mkUcIrqZDm25pTXGKMdkaYKWUjsUsbrEaMuqXl49L8RlMCTl+WFBIDf2Tubovp+acyK+Ys5lXf8XfNn5+xEukLYr6datTYnMyIqXmakfh4NxETn01pAB7FIT2D7s9mYP9E4s+99Nx/oyM2VZ4LBABz5wi84+kBlPo4BtY3UDVuCOPPHuiuWrlU6N+CwgkXR+OW+YZuLu7wzoI8qI+1n4o9HVVjDbQAxVlxry6fD8iZ+unCRM3b+5XbePn34BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A collection of payment response-related fields returned from a payment request.
    /// </summary>
    [DataContract]
    public class ProcessorResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ProcessorResponse() {}

        /// <summary>
        /// The merchant advice on how to handle declines for recurring payments.
        /// </summary>
        [DataMember(Name="advice_code", EmitDefaultValue = false)]
        public string AdviceCode;

        /// <summary>
        /// The [Address Verification System (AVS)](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) response code.
        /// </summary>
        [DataMember(Name="avs_code", EmitDefaultValue = false)]
        public string AvsCode;

        /// <summary>
        /// The [CVV](https://developer.paypal.com/webapps/developer/docs/classic/api/AVSResponseCodes/) system response code.
        /// </summary>
        [DataMember(Name="cvv_code", EmitDefaultValue = false)]
        public string CvvCode;

        /// <summary>
        /// The processor-provided authorization response.
        /// </summary>
        [DataMember(Name="eci_submitted", EmitDefaultValue = false)]
        public string EciSubmitted;

        /// <summary>
        /// REQUIRED
        /// The PayPal normalized response code, which is generated from the processor's specific response code.
        /// </summary>
        [DataMember(Name="response_code", EmitDefaultValue = false)]
        public string ResponseCode;

        /// <summary>
        /// The processor-provided Visa Payer Authentication Service status.
        /// </summary>
        [DataMember(Name="vpas", EmitDefaultValue = false)]
        public string Vpas;
    }
}

