// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// JsonPatch.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/7STT4vbQAzF7/0UYs4m9OxboKcWktKGXsqyUcZKPGE8mtXIWcyS777M5B/eLIT9d9STRvyen/xkFkMkU5tt4nAfUW1rKvMPxeHK0wy73DOV+UXDpfhByYqL6jiY2kzh59/5DMpb4NWWrIIyYIx+gIiiDj30sUGllBtCiXuxlCamMlMRHA4I3yvzh7CZBz+Yeo0+URYeeifUnIXfwpFEHSVT/z/DJxUXNtfga+FuBH8UXjfALihJRtSWwLPFPAAulFpRNqTQsO07Cgp5FTy2zrb5Rcc7KmM79D1N4AQOa5aiL/PEEjJ9WftR86H3fl/d/AIcR/5LOXa/aOlCla1Y7qInpTcRqvTvA4yo7QjxKNyKCG8GhHqJ5+SpDH5VBofbv7ZYTmLk8aRcJ1E6599nAllbCr04HmiYEgRWkAMf4PHwPsPR3f7bMwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// A JSON patch object to apply partial updates to resources.
    /// </summary>
    [DataContract]
    public class JsonPatch<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public JsonPatch() {}

        /// <summary>
        /// A JSON pointer to the location in the target document from which to move the value. Required for the `move` operation.
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue = false)]
        public string From;

        /// <summary>
        /// REQUIRED
        /// The operation to complete.
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue = false)]
        public string Op;

        /// <summary>
        /// A JSON pointer to a location in the target document at which to complete the operation.
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue = false)]
        public string Path;

        /// <summary>
        /// The value to apply. The `remove` operation does not require a value.
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue = false)]
        public T Value;
    }
}

