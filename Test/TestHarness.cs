using System;
using PayPal.Core;
using BraintreeHttp;

namespace PayPal.Test
{
    public class TestHarness
    {
        protected static HttpClient client()
        {
            var environment = new SandboxEnvironment("AdV4d6nLHabWLyemrw4BKdO9LjcnioNIOgoz7vD611ObbDUL0kJQfzrdhXEBwnH8QmV-7XZjvjRWn0kg", "EPKoPC_haZMTq5uM9WXuzoxUVdgzVqHyD5avCyVC1NCIUJeVaNNUZMnzduYIqrdw-carG9LBAizFGMyK");
            return new PayPalHttpClient(environment);
        }
    }
}
