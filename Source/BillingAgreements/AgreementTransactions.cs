// This class was generated on Mon, 11 Dec 2017 17:19:31 CST by version 0.1 of Braintree SDK Generator
// AgreementTransactions.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/5SPscrCMBSF9/8pwp3Dj5NDt4KzihQXkXLbnkokTepNOhTpu0sQSlGXrofvnvudJxVjD8oovwnQwUVVCLvAdTTeBdJ0ZjFcWey5Sxxp2iHUYvoEpEOnWIRH5VvFc0lclPyTpjwh71cbTSdwc3B2pKxlG5CCx2AEzRwcxfeQaBAou/yQXPR/O84a5QIrrQlxvb3y1R11/ByxXTvCDdZO1+nvBQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * An array of agreement transactions.
    */
    [DataContract]
    public class AgreementTransactions {

        // Required default constructor
        public AgreementTransactions() {}

        /**
        * An array of agreement transaction objects.
        */
        [DataMember(Name="agreement_transaction_list")]
        public List<AgreementTransaction> AgreementTransactionList { get; set; }
    }
}

