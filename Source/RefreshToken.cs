using System;
using System.Runtime.Serialization;

namespace Paypal.Core
{
    [DataContract]
    public class RefreshToken
    {
        [DataMember(Name = "refresh_token")]
        public string Token { get; }
    }
}
