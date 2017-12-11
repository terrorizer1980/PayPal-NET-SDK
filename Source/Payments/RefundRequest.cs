// This class was generated on Mon, 11 Dec 2017 13:16:18 CST by version 0.1 of Braintree SDK Generator
// RefundRequest.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+yYUY/bNgzH3/cpCD9tBye5bgMG5K3AMKAPWw/roS9dETASbROVJZeiemcM++6DIztLLr7iit6CPuQpkPknTelHylL+Lm77jop1IVQlbzdCHxNFLcriLQrj1tEf2A72oix+pWiEO+Xgi3XxErILjC7LoixeimCfA16XxZ+E9rV3fbGu0EUaHnxMLGT3D24kdCTKFIv1u30q2IbkZ1LYPz9O5LYh6LBvyStkSQl3rA1shfDDInXx+VKLKuzr09RMEiFv+tnk3mkjRAvToKBREnj15vXi5x9f/AKTG5hg6f33KxtMXLFXqgWHACvLQkZXQlFXk3gxiOPqhyXcYH+DDmygCD4oxNR1QRTQuSk005fNXiU9mLxPzv1TPoCzsaTILp6uxH+G04VAa3kYDjlnGeA2JAU9Qfj/I6u50s2dYDeb6mCFwQoV0RJ+x3tuUwuOfK0NcIQX17AHGku4a9g0wN64ZCmu/0rX1z+Z5Ha/lEeO8+gNfSIPlmvWCFuqgtBuASwZbtFBF9jrMvusJqfjELdfKL8L0/uwGgrwia9bTRP4ShgPSugxIg1669jXm4poFsokuDAZUs7NThaqkL3H7WBqpJa0CRaCd/3yPADZxyTozTy9vfWC7wjfAOjzDM+ELzbcddlySm8yXuCdbT+clnxjOZpHjz6HYGBSXtrr29sdY9pqUHTzFEfjePzZZ81KbVzCq2o3Go/ae2rg2I+aErThCF3Oqx+AX13JmPbV1aVlz8JY8X4Wr+L9hcAzEHj/FAaPNtlRhw0LX5MFDdP1gwi2/X4gS/gtyHjJjSUIdUKRvMadZIyiDeqB/6ieggbhmn3edYaAlwr42ovoUwrAHoCfK4Pxf4sD2RLeoks0AEHIYSFUENnXjhbbXgnQdQ361JKwOUB2tpP1p8CGNj61W5JHjtc7CWRJLkyOkOJY44Lmw/iNyJ/Ab37SQhg/jzArjkg+zy7z3b8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * A refund request.
    */
    [DataContract]
    public class RefundRequest {

        // Required default constructor
        public RefundRequest() {}

        /**
        * The payment amount, with break-ups.
        */
        [DataMember(Name="amount")]
        public Amount Amount { get; set; }

        /**
        * The refund description. Value is a string of single-byte alphanumeric characters.
        */
        [DataMember(Name="description")]
        public string Description { get; set; }

        /**
        * The invoice number that is used to track this payment. Value is a string of single-byte alphanumeric characters.
        */
        [DataMember(Name="invoice_number")]
        public string InvoiceNumber { get; set; }

        /**
        * The refund reason description.
        */
        [DataMember(Name="reason")]
        public string Reason { get; set; }
    }
}

