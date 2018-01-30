// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Payee.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/7xVT2vbThC9/z7FsJf8ApZkpyUF30qTgyltQxraQwhmvDu2Flaz6uwqrij57mXlf5GdkNKaHPXmj+a92X37S920NamxqrElUgP1DcXizNFnrBKsBuojtbuPCwpabB2tZzVWNyVBVwjL0oOQJntPAWJJMG/YBEA2MG/c3Dq3gr0YklwN1HsRbFf/Hg7UNaH5wq5V4zm6QAn40VghswWuxNck0VJQ49vt1CGK5cXh2FShdb3ZN8ghgS4CaIxQCIAheG0xkoGljWU3dEfxJMAVtlfoALX2DcccJvNVWPy9NWT2OtkA7ONBQ+R2r9Fg9xPQyODZtRsxN6nf0TmKKakijiGHCyukI2ghYyNoFLMNAgqBIbZkwDQE0a/i2le1s8iaQFbyrnr94za4ce5h8OJKKhJdIsepNb3F9PEn1sNa2jrJ11cNJhcw97LT7sg8up5TY0PtsJ1WFNFgxENez+btKD6bcsh2nZR1Z2CTeVyeL9+emSCbKaePxzR68NNGICcBZk2wnC5AyjzyUjYa1qXnJ9xqP7ybfT/yjI+dBOgygJtq9hpG1R1laafam/7Ae4HDeW/j0me6REEdSWDydZi9GZ2fZyNYl0Iqvfu/jLEO46IwdE8ujZbX2Nbocu2rwngdCsuRFoKpd2E6WymEQizWfbLUJxSn4Oc9N1yHX8k+VgvpSbSFDsWxnG1UeLzPAViG28t8dP52jVheQO2Q0xWrMO7kWi6XuY1NbjmpoYub7PryQ9aVZmfD0XA0yianR+F+9wfs//49e2wdksMn/GmrpgJHvIhleqNGZ+9ge4zCkRjdPfz3GwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payee who receives the funds and fulfills the order.
    /// </summary>
    [DataContract]
    public class Payee
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payee() {}

        /// <summary>
        /// The email address associated with the payee's PayPal account. If the provided email address is not associated with any PayPal account, the payee can only receive PayPal Wallet payments. Direct credit card payments are denied due to card compliance requirements.
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue = false)]
        public string Email;

        /// <summary>
        /// The encrypted PayPal account ID for the payee.
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue = false)]
        public string MerchantId;

        /// <summary>
        /// The display-only metadata for the payee.
        /// </summary>
        [DataMember(Name="payee_display_metadata", EmitDefaultValue = false)]
        public PayeeDisplayMetadata PayeeDisplayMetadata;
    }
}

