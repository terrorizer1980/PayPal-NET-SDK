// This class was generated on Mon, 11 Dec 2017 13:16:27 CST by version 0.1 of Braintree SDK Generator
// Capture.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xZTW8bNxO+v79isLkkxnrXed2kqG9G06A+NAliIxfXUEbkrJYNl9yQQ8tqkf9ecLkrWV+x3ThCC+gkcDlDPpxnZjgc/ZVdzFrKTjKBLQdHWZ59QKdwrOkNNnEiy7NX5IVTLStrspPsFHpZYIfGo4jfiyzPTp3DWVruKM/eE8q3Rs+ykwq1p/jhc1CO5PzDO2dbcqzIZyeXcyDY2GB4Hcf8+zKai5qgxVlDhiGJ5DBVXMPYEX46DK1/PGienTKTdWgiOEdGzDaCu+TaER2KGh0KJgdn528Pf/j/8x9hUANhJV09LaUVvlSGaeIwLlBK5Uhw6chzOQgfRmFfPivgHc7eoQZpyYOxDD60rXUMqPWwtKKHnZ5dWDm8CVp/yVfIGUliVNqvW2IxsW4IlFLFYcScxADHNjDwGoXfn7KJqng0ddhuhBpnIc5CRVTAb3ijmtCAJjPhGpSH50cwJ9TnMK2VqEEZoYMkf/J7ODo6FkF3v5RGWqXROV2TAakmij2MqbIxjmoCSUI1qKG1ynCRdMpBaXmJiweKT+2wH1bRAe+5XTkc4BvJWHGhbYzUaKRWZjKqiDaSMgjsOYmQU7CThMom7T4dDIHUENdWgjV6VuyGQGV8cGjEZvbms3v6luiLBH2dwx3R52vVtmlmnb1hck/ezvLhYPKRVF5sLX1uEwOD5D68/n3Z0YcxW0a9mcV+si9/5qgVU+MLOKu6kaPPgTzPWQOtTC+TA9fKQ5twzSLhBweuh31wsA/ZnXDMeLORXsabPQOPwMDVfTjYGmRLERYNPyEJbIfnBxGMZ/OBK+C1deCoCkb6HBy1jjwZ9p1IvwrXyLf0e+lhUevURJmUdeKCew/41ofofRxAOEKmEatmcyEqkQnQSIgSMK3JdCcZehpWdG9nmYMycGaYnCFeUaqsa5ABPUiqlCEZZS/fv/4Zjo+Pf4Jz6loi8KJ4efW0Zm79SVmytdoXirgqrJuUNTe6dJWICk98Ujh8Ubx8tqtiXW40ztkrsNWSPR6xx3Pvd8S1VYJGJjRjclseE50IJJEu3hyKT/0lmO74R0Y7tlYTmg1w/aiKUT5adNCWAZ8ZqQQy+ehsXCe8jjShp65Z46hBZboiLqWPIatg4No69WfXDYLaaumjp8WpKBk1lPHsQlfTPH199qyAV1Rh0Byzy8fuVB8f2RBamU8juTjhyI7/ILGhYRcF1ztBpwYwgol+1hc0h440xmLt8tfTi1/enp5Dpzp0xLBVpb0md61oWj6pkcmiP+xEVqPl5XdyyRYdGR71nnVH5Aw1pjV9Qu+88lYcRW7G6GlXLztH6K0ZCSs3Z8Q033Uhk+8ldsedx6Yr8TZ6zzEZxkCj5IPdPXlNbncn6iBsPMuQtjqJAj6gDhHrV+/SNIrHT+P+XP31tfhewO0dFgb4+r25urqwTauJSd6xfo0efBCCvK+C1jOYKz5sv1SU3LndFD2kfQaFh23TomOFWs9GD9hwrnTHpt+pjr/Vt1+tIhf+vrUfGUN40cNPWbB7ucWcHq8EIxRquI4uOE9xlSItfSou6QYjozmMUaMRlM9ThwyUd+WGt/CY/63s/8DYZoGOpc1/W/R/KoU23tsHbw62V8E+RgGydflqbTiY7KFGmncCsI1ve6di6l0ye7Gjsjq08p+U1Y68DU6kcNfoGdJC/+36+urL//4GAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * A capture transaction.
    */
    [DataContract]
    public class Capture {

        // Required default constructor
        public Capture() {}

        /**
        * The payment amount, with break-ups.
        */
        [DataMember(Name="amount")]
        public Amount Amount { get; set; }

        /**
        * The date and time when the capture occurred, in Internet date and time format as defined in [RFC 3339 Section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /**
        * The ID of the capture transaction.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * The invoice number to track this payment.
        */
        [DataMember(Name="invoice_number")]
        public string InvoiceNumber { get; set; }

        /**
        * Indicates whether to release all remaining funds that the authorization holds in the funding instrument (FI). Default is `false`.
        */
        [DataMember(Name="is_final_capture")]
        public bool IsFinalCapture { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * The ID of the payment on which this transaction is based.
        */
        [DataMember(Name="parent_payment")]
        public string ParentPayment { get; set; }

        /**
        * The reason code that describes why the transaction state is pending or reversed.
        */
        [DataMember(Name="reason_code")]
        public string ReasonCode { get; set; }

        /**
        * The capture state. Value is:<ul><li><code>pending</code>. The capture is pending.</li><li><code>completed</code>. The capture has successfully completed.</li><li><code>refunded</code>. The capture was fully refunded.</li><li><code>partially_refunded</code>. The capture was partially refunded.</li></ul>
        */
        [DataMember(Name="state")]
        public string State { get; set; }

        /**
        * The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="transaction_fee")]
        public Currency TransactionFee { get; set; }

        /**
        * The date and time when the resource was last updated, in Internet date and time format as defined in [RFC 3339 Section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6).
        */
        [DataMember(Name="update_time")]
        public string UpdateTime { get; set; }
    }
}

