using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using BraintreeHttp;

namespace Paypal.Core
{
    public class RefreshTokenRequest: HttpRequest
    {
        public RefreshTokenRequest(PayPalEnvironment environment, String authorizationCode): base("/v1/identity/openidconnect/tokenservice", HttpMethod.Post, typeof(RefreshToken))
        {
			this.Headers.Authorization = new AuthenticationHeaderValue("Basic", environment.AuthorizationString());
			this.Body = new Dictionary<string, string>()
			{
				{"grant_type", "client_credentials"},
                {"code", authorizationCode},
			};
			this.ContentType = "application/x-www-form-urlencoded";
		}
    }
}
