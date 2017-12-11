// This class was generated on Mon, 11 Dec 2017 17:22:28 CST by version 0.1 of Braintree SDK Generator
// VerifyWebhookSignature.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/9RXXW/bRhB8769YsC8poI8ARgJEb0SkxgIUS5DktIVhSGtySV59vGP2llLYIv+9OEp0ZUuKlTp101ftLjkzt3ND/RnMq4KCXvCBWCUV/EI3mbW3MFOpQSmZglbwAVnhjaYLzH1n0Ar65CJWhShrgl4QwmozvN4Ou2YYmD6W5KQTtIKQGavNy162gilhPDa6CnoJakf+h4+lYorvfpiwLYhFkQt6V3cwnbAy6T4oLCVboE7tHrp5RuALrCTLQTIUmGA1QQ2lIwdiISVDjEIgGe1gRxNv2itbQoTG9/v2Ldl7zR0YfBLGSEAy5WCFuiRI2OZ123IS/jYJR+3wcn7eDkfvxktgcoU1jiAjjIlbsM5UlIFywBSRWlEMayVZPd7IaqyoREXoiX2VosLlA0FNqfXn1qOqRsSyKFkfFPXXzquXb6Aob7SK4JYq8N0bgNSBvl0bbTGuGexUGlWUg8vpqBbZ66rkadK+HUzn7cvp6P+irDAalyvnlDULFR8UeNgHm9Q4z+fzCeyOdOCtNYLKUAzK3FNiPg0vZu+Hs9lwfNEe9pdbHZpH7VKFnJzDlP4Dyk6lBzlvrNluLBkDuirPSVhFuysRFgUhuy9ynw3ffafkReV0kH3sDVLfOyqno4ff8rSvhkaIDcmDocRyjnL9IhMpXK/bFWu16yiSpGM57WaS6y4n0dnZ2ZsfHUX+5e1Xndc/nabpfPh+8PyiDlZkZF/TrXsXtC0/TKXG3XX9W3r88TiKmFDo1INeZ2Tu3Uf7iGGNDjZPjf+d839iRJ/og5rZQnzTIV02xOvUFVZpSkzxI8o8K/AVsXfgF7BvOxoXPTlh/jniR1Pl2TQdKXMLO0hgfPM7RQccrZW5dftONoAejMe9/aBsM+k6Hq7Ow/lgHM6gHr1+0Y1t5LpYqG6GQhZduy48XO/XT2RkjxBgcrbk6PByN8Xvcr8bcMe9afDvTLqj0pyD2KPrvuH0TDRcmefI1YE02FYg3tnDxHIN+4Dq8LNloE+YF5pasAyhwCr3Xf6fhmX1x9613Fl+C4rXJ5Bsgu9kh3uQ1iQqLXnzwVjZkqFPK9L+9TCxLKgBo8iWX3lUR8L7+vMPfwEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Webhooks
{
    /**
    * A verify webhook signature request.
    */
    [DataContract]
    public class VerifyWebhookSignature {

        // Required default constructor
        public VerifyWebhookSignature() {}

        /**
        * REQUIRED
        * The algorithm that PayPal uses to generate the signature and that you can use to verify the signature. Extract this value from the `PAYPAL-AUTH-ALGO` response header, which is received with the webhook notification.
        */
        [DataMember(Name="auth_algo")]
        public string AuthAlgo { get; set; }

        /**
        * REQUIRED
        * The X.509 public key certificate. Download the certificate from this URL and use it to verify the signature. Extract this value from the `PAYPAL-CERT-URL` response header, which is received with the webhook notification.
        */
        [DataMember(Name="cert_url")]
        public string CertUrl { get; set; }

        /**
        * REQUIRED
        * The ID of the HTTP transmission. Contained in the `PAYPAL-TRANSMISSION-ID` header of the notification message.
        */
        [DataMember(Name="transmission_id")]
        public string TransmissionId { get; set; }

        /**
        * REQUIRED
        * The PayPal-generated asymmetric signature. Appears in the `PAYPAL-TRANSMISSION-SIG` header of the notification message.
        */
        [DataMember(Name="transmission_sig")]
        public string TransmissionSig { get; set; }

        /**
        * REQUIRED
        * The date and time of the HTTP transmission, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Appears in the `PAYPAL-TRANSMISSION-TIME` header of the notification message.
        */
        [DataMember(Name="transmission_time")]
        public string TransmissionTime { get; set; }

        /**
        * REQUIRED
        * A webhook event notification.
        */
        [DataMember(Name="webhook_event")]
        public Event WebhookEvent { get; set; }

        /**
        * REQUIRED
        * The ID of the webhook as configured in your Developer Portal account.
        */
        [DataMember(Name="webhook_id")]
        public string WebhookId { get; set; }
    }
}

