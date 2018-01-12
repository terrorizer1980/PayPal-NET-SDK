// This class was generated on Mon, 08 Jan 2018 16:45:11 CST by version 0.1 of Braintree SDK Generator
// QrCode.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6TOP6vCMBQF8P19inDnwHvDwyGb6Cb4p4iLONw2tyWQJvEmHYL0u0tbrNTV8ZwL9/wecM6BQMGpEBuvCSRckA2WlvbYDgeQsKP8DluKFZuQjHegoMRIq39BrvKatDAtNiR8LVIONKXf4BqQsGbGPG39SSgI9cHZDKpGG2ko7p1h0nNxZB+Ik6EI6jorY2IzvvtAjksL6atZcr+EuM7a/tb/PAEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// base64 encoded image of type image/png
    /// </summary>
    [DataContract]
    public class QrCode {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public QrCode() {}

        /// <summary>
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue = false)]
        public string Image { get; set; }
    }
}

