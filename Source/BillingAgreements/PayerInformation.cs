// This class was generated on Wed, 13 Dec 2017 14:32:59 CST by version 0.1 of Braintree SDK Generator
// PayerInformation.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xXUY/TRhB+768YuQ8lkhMfUPGQt+NQEa2AiLvrS4qOye4knt5618yOCabqf6927eYCF8QFoXuJlPV8s9/MfPt5/U9x0bdUzIsF9iTwwq+DNKgcfFEWf6Iwrhy9wiaFFGXxjKIRbvPzebEXDbgKnYLWBKaLGhqSWVEWpyLYDzuclMUbQvvau76Yr9FFSgvvOxayu4WFhJZEmWIxX+64nXPTOoJFiIoOTq0VivE2vxU7x35zhbuAz+meQhwStUOiMQ62rDWYgBJpuhFkTxbWTM7GGTwL4INCFwnWQQA9sFcSn4u+yTGDyzFiheZ6i2LBhKZF5RU71h6Cd33KRjHnM8Ersoe2Dp5+XKOiCvvN7c4Y1v5WOy7SrBI3j81xHFS6Lyj4zrl/y2/zCJ1X6a9MsHSQz1K3YWpqFDSa5Hj+Gh4/fPJk+hAS5O2DygYTqzSCjeQRVJaFjFZCUasx/TTFxmoCWqMCW/LKa6Y4qHOIgSAgtOHgZ391JyePzcoFc/2+C0r5//Brokrwm2HlVVCaD8vV/jpc7KVNW2cdPBdChafCec4cYUCm5wPs+dMx180SoLdZHl/GXv5xIDYmVVpgn+vS0E4dfSAHNjRpyzTVmKnkNowEB6EmwLuzR+9u0z6r2SNsgzi75XEtK1nSGKHzSbkSnCMLrbAheHB2uZhAQ1oHW8IK/TUYFFvmYoyEGKerIJYEVNBHNGlscex69WXb70WGjj09PKi/NUtUSM8hrHObdgf8tyBAHzEZSAm+a1YkJUQVIh1qjQGCn91bAY9uFfC6HUxplhUZyQRv71BL7FipBGxRtCGvu+K+r6gDBnXHqgZb/ro5jLadnpewrdnU6Vylwj5xO0g41fW+4w/oyOsMLvqWDTrXg4z8RkEn1SdHyNaP+5lhcPn9LOdEsFzchLx9UKu2cV5V5GdbvuaWLOMsyKZK/6rFTR2Te2pdVNSvOOpdjDPDd7aZX3RweQ55GbKD0F5HckDQmvY6OYM3+x3eP+rAn6kvzYw9hJ0sI92kmcPyVDbJsD0eQ/pn/B81KWH5VPATu6PwqwxJ4DP0aI/b3GRIAr/wlo/DckJkqKLrj4MmRIL+ji36o6B/J0SCvqSPbMJR2CZDEviiRnbo7VFwHUGTMilreelZycJ5ColHJeoiTmbwEj9y0zXgyG80G8KvJxDZbxxNV70S7G4T8Yecxbd3OI3UILvD963xbvxLhBy0s+T7sYn8ertKN4NvsRtehEffDL+fmsM7MkuB90msTR9GV2wP8lpgv0A3xRh5kz4bXjwbb1w/7jNoVN1P/wEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// Information about the customer.
    /// </summary>
    [DataContract]
    public class PayerInformation {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public PayerInformation() {}

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue = false)]
        public SimplePostalAddress BillingAddress { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The PayPal-assigned ID for the customer.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId { get; set; }
    }
}

