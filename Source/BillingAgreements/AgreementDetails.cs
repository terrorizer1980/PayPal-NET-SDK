// This class was generated on Mon, 11 Dec 2017 17:19:28 CST by version 0.1 of Braintree SDK Generator
// AgreementDetails.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xVW2vdRhB+768Y1JcGdLPdJo3eDKHgQuLQmEJrzPGc3dHR0NWusjvyiSj572Wlc2Q7liFp09gPfhXfjr7LXP5OzoaOkio53niilqyAJkE2IUmT39Ezrg29wTZCkjR5RUF57oSdTarkrCHAT9/lSZoce4/DVLhMk98I9ak1Q1LVaALFD+979qTnD2+968gLU0iq85lSEM92c5eHGpShsFKu7QwJ6UVetm/X5MHV0OEw8puewfwMaudBGg7XGv4rd9sb8zH9XAGeWmQ7Ib5AwPzs4QTUyIb0akdspVxvZVGEOEFzQ8r0cK8oPKACtmhmARqFFvmPsDmACAO0GoRbWuCeAls4P7FC3tICvEW5+KER6UJVFOKcCTmT1Lnzm6KR1hS+VkdHRy+/D6Qiieyn/PmzHH5xHugDxrZN4fKwPHiRlS+zw6Oz8ueqLKuy/PPyK7v22lkaQIaOYMvSgOq9J6sGUE4TvO/RcM2k4QpNT3fNNRhk9hbbxe44nspHE9GY0WirGM1UM/NkcJxRJqPDJx6s0aBVlF4H01M6Oh0cOPsNNtDOj8WeOZfGE2WqQY9KyMPJu9Psx8ODF7dtvO4ETVdk4u/zDocOTa5cW2inQsFWaOMxFi80e1JSeApS7AtlsVAonn2RYvH9v5uZfdp3Jc/CRkgOr3nTCKxj98OogfyY9A7HFMDwXwSXv7794xKkQQH0BNZJ7ApWaMwAdbSPXRzA2CQw2doZVASaFLdoZsxy9bM3r25UD/1a8xVr0pGTA2lcH9BqaXb9JQ2B39l0Y2ft/zX+eVpZeDvKFAIRnJ+8O4WY85RsVRTb7Tbn4Mb55uCKxrVUBEGr0eswp7gaU8wbab9KkBefEeWtCb13+0XUo1t+z7ODw/91+d3nmaUPslqzMWw393sWUbBDPaaDcfCYD4brZRyL6OxuuT8djKeD8XQwvtHBuPj43T8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * The agreement details.
    */
    [DataContract]
    public class AgreementDetails {

        // Required default constructor
        public AgreementDetails() {}

        /**
        * The number of payment cycles completed for this agreement.
        */
        [DataMember(Name="cycles_completed")]
        public string CyclesCompleted { get; set; }

        /**
        * The number of payment cycles remaining for this agreement.
        */
        [DataMember(Name="cycles_remaining")]
        public string CyclesRemaining { get; set; }

        /**
        * The total number of failed payments for this agreement.
        */
        [DataMember(Name="failed_payment_count")]
        public string FailedPaymentCount { get; set; }

        /**
        * The final payment date and time for this agreement, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-09-23T08:00:00Z`.
        */
        [DataMember(Name="final_payment_date")]
        public string FinalPaymentDate { get; set; }

        /**
        * A type for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="last_payment_amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue LastPaymentAmount { get; set; }

        /**
        * The last payment date and time for this agreement, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2016-12-23T08:00:00Z`.
        */
        [DataMember(Name="last_payment_date")]
        public string LastPaymentDate { get; set; }

        /**
        * The next billing date and time for this agreement, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-01-23T08:00:00Z`.
        */
        [DataMember(Name="next_billing_date")]
        public string NextBillingDate { get; set; }

        /**
        * A type for all financial value-related fields. For example, balance, payment due, and so on.
        */
        [DataMember(Name="outstanding_balance")]
        public MoneyTypeWithCurrencyCodeQualifiedValue OutstandingBalance { get; set; }
    }
}

