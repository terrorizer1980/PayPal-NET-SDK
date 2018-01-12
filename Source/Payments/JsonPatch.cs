// This class was generated on Wed, 13 Dec 2017 14:31:50 CST by version 0.1 of Braintree SDK Generator
// JsonPatch.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7SST0/zMAzG7++nsHKupvfc2yROHDYEExeEmJd6a6Y0Do47VKF9d5SMbRIDjb/H2k+d32M/z2Y2RDK1WScODxHVtqYytygOF54m2OWeqcwFJSsuquNgajOGy5vpBIoceLEmq6AMGKMfIKKoQw99bFAp5YZQ4l4spZGpzFgEh92r/ytzTdhMgx9MvUSfKBceeyfUHApXwpFEHSVT3x14k4oLq1PWpXD3IS+7oCSZSFsCzxazAFwo34qyIoWGbd9RUMij4Kl1ts1/dLyhItug72kEe05YspT6PCvmkGHL2J96Db332+qsYY4ndmctHTEyu+UuelL6EpJK/z2iiNp+4gR49gCox/XvLRThX+14F+VTR+Xk7665dA7ZH0GuzYXeRAEapgSBFWRHA/gao9/gv9/+ewEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Payments
{
    /// <summary>
    /// A JSON patch object to apply partial updates to resources.
    /// </summary>
    [DataContract]
    public class JsonPatch<T> {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public JsonPatch() {}

        /// <summary>
        /// A JSON pointer to the location in the target document from which to move the value. Required for the `move` operation.
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// REQUIRED
        /// The operation to complete.
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue = false)]
        public string Op { get; set; }

        /// <summary>
        /// A JSON pointer to a location in the target document at which to complete the operation.
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// The value to apply. The `remove` operation does not require a value.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public T Value { get; set; }
    }
}

