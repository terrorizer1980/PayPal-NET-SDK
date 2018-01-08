// This class was generated on Mon, 08 Jan 2018 16:45:06 CST by version 0.1 of Braintree SDK Generator
// CustomAmount.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTT2sWMRDG736KISeF5cV/ILy3Wi9FaEWLF/Ewm8y2I7NJnEwKQfzustv3T2MPVdrb7pNkeH7zzPxyly2T27rTWizNcDKnGs0N7isq4yh0jvNy7Ab3kdrx5wMVr5yNU3Rbd3lN4G8L4FoALAHmLG39iMDxJrGnDZxN0FIFjl5qIEAQHEmGVZxrsTsnXcGNG9yJKrZbuy8H95kwXERpbjuhFFqEn5WVwkH4pCmTGlNx2293QFUp+nafEffsR9KD1PO+x0KQxh/kDaakgCIwccToGQVuUCqBkqBRgIlJQoHnIwpGTwNkbDNFg1BpADK/efFkbMWU49V9Mr9jPk2BOj5/bEZP+AaEzEhhfwN8WlIpEGjiSAHGBmdfLuDt61fv/isc0/qX/1hFfg8PQqxt7dzvld76bgJrXmbvHAJfsQFOC4xdEwTyPKMUKJRR0Zb4jlQcD1RrsssLzFlTVkajvh1Pwf39H8jXHenI98pDa7jee+zu7Hw++wMAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
    /// </summary>
    [DataContract]
    public class CustomAmount {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CustomAmount() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The custom amount label.
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue = false)]
        public string Label { get; set; }
    }
}

