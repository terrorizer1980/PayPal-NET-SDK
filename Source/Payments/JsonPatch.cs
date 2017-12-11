// This class was generated on Mon, 11 Dec 2017 13:16:29 CST by version 0.1 of Braintree SDK Generator
// JsonPatch.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7SST0/zMAzG7++nsHKupvfc2yROHDYEExeEmJd6a6Y0Do47VKF9d5SMbRIDjb/H2k+d32M/z2Y2RDK1WScODxHVtqYytygOF54m2OWeqcwFJSsuquNgajOGy5vpBIoceLEmq6AMGKMfIKKoQw99bFAp5YZQ4l4spZGpzFgEh92r/ytzTdhMgx9MvUSfKBceeyfUHApXwpFEHSVT3x14k4oLq1PWpXD3IS+7oCSZSFsCzxazAFwo34qyIoWGbd9RUMij4Kl1ts1/dLyhItug72kEe05YspT6PCvmkGHL2J96Db332+qsYY4ndmctHTEyu+UuelL6EpJK/z2iiNp+4gR49gCox/XvLRThX+14F+VTR+Xk7665dA7ZH0GuzYXeRAEapgSBFWRHA/gao9/gv9/+ewEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /**
    * A JSON patch object to apply partial updates to resources.
    */
    [DataContract]
    public class JsonPatch {

        // Required default constructor
        public JsonPatch() {}

        /**
        * A JSON pointer to the location in the target document from which to move the value. Required for the `move` operation.
        */
        [DataMember(Name="from")]
        public string From { get; set; }

        /**
        * REQUIRED
        * The operation to complete.
        */
        [DataMember(Name="op")]
        public string Op { get; set; }

        /**
        * A JSON pointer to a location in the target document at which to complete the operation.
        */
        [DataMember(Name="path")]
        public string Path { get; set; }

        /**
        * The value to apply. The `remove` operation does not require a value.
        */
        [DataMember(Name="value")]
        public object Value { get; set; }
    }
}

