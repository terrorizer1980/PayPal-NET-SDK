using System;
using System.Runtime.Serialization;

namespace PayPal.Core
{
    [DataContract]
    public class RefreshToken
    {
        [DataMember(Name = "refresh_token")]
        public string Token { get; }
    }
}
