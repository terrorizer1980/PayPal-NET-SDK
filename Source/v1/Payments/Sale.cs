// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Sale.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/+xb3W/byBF/718x0BVobEhUrrlPv7nnuCfUuQtsx0CRBtKIHIrbLHd5u0vJuqL/ezFckuKXHCd2dEHhJ4Ozs9TM/Gbni+v/jK63GY1ORhYljcajGzQCl5J+wZSpo/HoH7TdPZyRDY3InNBqdDK6Tgh4HziDymLIZIjIoZA2GI1Hp8bg1r//+Xh0SRj9quR2dBKjtMSE33JhKKoJr43OyDhBdnTytpYMU50r15etpu8krEl9OTPcpqQceJYxbIRLYGkI30/y7OOkdSbfK6x1RqhVX9gwN4ZUuG2J2yD2BX7rEkM0CRM0GDoyMLv6dfLNX7/+HqptEOqI3j2bRjq0U6EcrQzyC6aRMBS6qSHrphXzhJnt9CiA17h9jRIiTRaUdmDzLNPGAUpZvVrQQy2icin/O+5gOC99o2+e3cLOOjta3zgYRYIfWQ/PBrjUuQPXg/rxHHEftisRu/nGYNYSv0ntK8CrwKsQEwXwCm9FmqcgSa1cAsLC18+hht6OYZOIMAGhQplHZE/+lT9//iLMZfGX/JMU/umK1qQgEivhLCwp1oYKs0QUihQlZFooF/g902pT+xXXH8m+0dXvYcyues+fm1YKPBCijrPtwylBFUmhVvOYqAVVZ6GPVsXwBBaL7OMFRRBrv7uMKNW5S8klOgKt5DY4DLJC2dygCtuwNql9TOvVJ1BboDJsdyN7IFBtIrLMr+wwbRAHapFy8QnRg8XUyuTzSNiwV48Nrd4NG1ScTyfyywuzNl867VC2Md4RB6AtF8tarFZFOEptALO4eDL0W07W1VCCFKrkGYNLhIXMC7tlLzg+NqUux8dPp/wgwDu8bWHun/twO7x9QuQREHl3H0x6J3H/MWydQYZiRRE4XXVLRLDc1g8mgHNtwFCcq8iOwVBmyJJytmAp3+ISdI39JXf1Um3ESigfrPiFTz7x0F76Pi6xFLJoY3BliDhHzEXU8pA9DH2HmZ2B9rG53AL1lgDeWIoALWNOhriCdhrolsLckQ/XjXnQgVJTKAl5Ze5E2u4Cuit9ZSN0BKgiYA7YJKQKzemnhML3rdmWsEC3GYXOH5/i1WMQCt7OlCOjyHVeFmuTonv3LHEusyfTqdNa2kCQiwNtVtPEpXJq4vDFixc/fmWp+JHJt8F3RwFcksuNKrN/KUqZ+W0AnXK9lnlRssx9cbBgiZmWoVwcCglD6GgAhxb9QyiU3mdR0ucx8KOOt/bZgm7DBNWK5gZd2xrdlb49Kg5gjrJw6hytnZMUXiAUhEZbO6kHhLklCNGSZQ8xBAgpGX6tK861BYRlviXDWxGUVpPMiBTNdjdj9D+MzjM+sg/Fabx/Jthe3JmuTR8YnJ4bzCN4hQpXRcSCcyE5aj87f3V+VM1LQ4nWinAap3FzdjpZ5SKi6fmr86s8ZUtMjx5/or3PXaKGLu1JaJPe1zj2+jXYDnTW/Q93s0yTulfY2dlhjmApjGOuASFL+l4xef0wgirsBMySsFc0Xg8OVW12IP5g2dD9LPS4NpRCvZ833H2ul/+mcOAbETO2o0dFaQt/qgBZOha/7EYnhiRyhn378+n1y19Pr6DYWsUPzMRUr8msBW2mXyXoSKOdFCzd5PLd40eKxFDcHmF7Qh+SUKeZJC7MuOp38ObyIoBrDSm+p7L59mqGKOWY2ZfcfPNKOWAovpQVuYe189n4zeUMHKWZLHPTfXLwd99+//wogJmv8X258ufFGBbPFuMioS+OFo2eoMg8maFJZnRI1gq1CoA1WrCuRWXDr3hPW6gAYl21oqo7KcAArE3gdfT6INh8aRlp7ohQygNFTG/TFnQ1qQ/ez9fXrysYqqEHF56D4B1IA0PtrtM/D6RhNr8XkEtnDqQfdJFvf/zhh7pM++aoagstmTVZbjlQcYxhz8ACXg90rjBdilWucyu3ZRpckvcPSykqJ0JbRSbeFsAVEby94DdclhLanXSbzSYQqLCQjcuElSrq7invnVQqdR+DW1bj6GAhOUPDlX5Z8bcw6S3dFaqreaJWpbm7dSYftSVaig6TCKsWJtEymhtCq5XtaDfIcFdEL3i8s5RTVN5syzMUikywBeJcRewarqyn2/bhHWAdutwWbdXPLy/OFg8N9Z9iEy/DfpPU633U27qW2nT7iLqbbPAUGicko0O1kXUjqyMaVLVcGBh2NTy3npXriIa75gN2zGUi02ZuyGZa2YELN4M8DeWHljuOD6GW0sdQdv7KBNWGuq6JBfERMPWgwegUsMFflEGfv+vBaC1CmoddoNv0Ps51K+sZOX4lesPpsfhcX0zopFDkKwlD3NIKtdpNUQ7jyLi2A7rtiAOZ8zSKDFkLN2RELEKfQK+21lEKz05vro52qSqiNUmWKfA+G4Q6nW5oiVlmd4vtlpdL19Obq8vSIX7yF4NqBymuFR1qWLRe943TIA4Y56ebm8+ivvX2/SOsQKGY23yZCueoXRt2VwbutVURgevktYgoAsxdoo343ftNpdDBykP/c31Yuyt9XcrUrLifkOJ3itpo1F8JLKxIkfFRjKOWaxriLxZsRiGfnAeg+cnlyzrDdm4uCfeC7kZYZDOQgdPcJcSVa3n8udUMqUrZBysyjXY+l8xJipVYCinctpuThlkGPgeTlMRdXbUDJJ9RbikpjincfSBujTm/4Gn3sPL9cdPdfPexFLN+yFADddxi+Je9rV5ezP4++9vFywVoA4vXp5fXs9OLi3/Oa/qXbfucCwBL81wJN6+/RnXHkXey3dUYNQvJonUItfEBpfrQKezDBl0PCbPc0gwF2Sa9Wxn61SIYeo12vfIm2faU5lhDDGxGKuLSqaij1mS4F/ySPcNQSCLrff5skQebI16G2Vkj0+wK4tkZqDxdUvk9RDRLZ21gVVxhyS2ZwjlExME73jZbyEfWvnF9fEj/NRPmA7fkh1b71uCOf/cZyA9Y/eRFSoiFQhUKlLBGmXd7Cn+BgG4xzSSNYYkSVUjj2pJRTn7iZzU8/MTc//L9QKn5/3ID/9PPSgFgu2ApKQPX7st/nsgzdvHjX473X4uwlKFBp80Y0EJEseCDUnzJLa34sXarUx5mmdGZERycWkgEB7pnUcTF9iU4t+8zbu//YwrWxy1F9weCxg/3br33156CwFMQeAoC9wwCeRYN3nNp0+9928iQ1bkJCTZoQSKXEsWLoj/++sv+/vFP/wMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The sale transaction details.
    /// </summary>
    [DataContract]
    public class Sale
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Sale() {}

        /// <summary>
        /// REQUIRED
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount;

        /// <summary>
        /// The ID of the billing agreement. Used as reference to execute this transaction.
        /// </summary>
        [DataMember(Name="billing_agreement_id", EmitDefaultValue = false)]
        public string BillingAgreementId;

        /// <summary>
        /// The date and time when the eCheck transaction is expected to clear, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Returned for eCheck payments. Supported only when the `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="clearing_time", EmitDefaultValue = false)]
        public string ClearingTime;

        /// <summary>
        /// REQUIRED
        /// The date and time of the sale, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime;

        /// <summary>
        /// The exchange rate for this transaction. Returned only in cross-currency use cases where a merchant bills a buyer in a non-primary currency for that buyer.
        /// </summary>
        [DataMember(Name="exchange_rate", EmitDefaultValue = false)]
        public string ExchangeRate;

        /// <summary>
        /// The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
        /// </summary>
        [DataMember(Name="fmf_details", EmitDefaultValue = false)]
        public FmfDetails FmfDetails;

        /// <summary>
        /// REQUIRED
        /// The ID of the sale transaction.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// REQUIRED
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [DataMember(Name="parent_payment", EmitDefaultValue = false)]
        public string ParentPayment;

        /// <summary>
        /// An array of reasons that PayPal holds the recipient fund. Set only if the payment hold status is `HELD`.
        /// </summary>
        [DataMember(Name="payment_hold_reasons", EmitDefaultValue = false)]
        public List<string> PaymentHoldReasons;

        /// <summary>
        /// The recipient fund status. Returned only when the fund status is `held`.
        /// </summary>
        [DataMember(Name="payment_hold_status", EmitDefaultValue = false)]
        public string PaymentHoldStatus;

        /// <summary>
        /// The transaction payment mode. Supported only when `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="payment_mode", EmitDefaultValue = false)]
        public string PaymentMode;

        /// <summary>
        /// A collection of payment response-related fields returned from a payment request.
        /// </summary>
        [DataMember(Name="processor_response", EmitDefaultValue = false)]
        public ProcessorResponse ProcessorResponse;

        /// <summary>
        /// The seller protection level in effect for the transaction. Supported only when the `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="protection_eligibility", EmitDefaultValue = false)]
        public string ProtectionEligibility;

        /// <summary>
        /// The seller protection type in effect for the transaction. Returned only when `protection_eligibility` is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported only when the `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="protection_eligibility_type", EmitDefaultValue = false)]
        public string ProtectionEligibilityType;

        /// <summary>
        /// The ID of the transaction that corresponds to this sale transaction.
        /// </summary>
        [DataMember(Name="purchase_unit_reference_id", EmitDefaultValue = false)]
        public string PurchaseUnitReferenceId;

        /// <summary>
        /// A reason code that describes why the transaction state is pending or reversed. Supported only when the `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="reason_code", EmitDefaultValue = false)]
        public string ReasonCode;

        /// <summary>
        /// The receipt ID, which is a payment ID number that is returned for guest users to identify the payment.
        /// </summary>
        [DataMember(Name="receipt_id", EmitDefaultValue = false)]
        public string ReceiptId;

        /// <summary>
        /// The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="receivable_amount", EmitDefaultValue = false)]
        public Currency ReceivableAmount;

        /// <summary>
        /// REQUIRED
        /// The sale transaction state.
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;

        /// <summary>
        /// The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="transaction_fee", EmitDefaultValue = false)]
        public Currency TransactionFee;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime;
    }
}

