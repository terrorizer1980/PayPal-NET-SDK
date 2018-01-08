// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// WebhookGetRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6yUQXPTPBCG79+v2NF3aTtOXDhw8C3TBtqZQkIT4NDJ1BtrE6tRJCOtGzyd/HdGttOkCVAKHPVqV3r21WofxAdckkjEiqa5tYvunFhE4px85lTByhqRiFFuVx4kMSrtYWYdILTxEUwruDzvikh8LMlVQ3S4JCbnRXIzicQFoSS3r761brmvDZHzJ9qDGFdFQPPslJmLSHxGp3Cq6SnyrZIHxOOc4PIc7Aw4pw1rTb7KVZYDW/C5XW1qCvg957BqbjyNxDWhHBhdiWSG2lMQvpbKkRQJu5IiMXS2IMeKvEhMqfV60sSQ5+aQIAbJF9Z4arTHkr40RIc1HVQyMATWwdK6bR12ekcZv4y6FXaxtw7378kw1IsDIgp7t1wV5A/gegYwAASjyyK4ymSgzvBhtTW7nIa8KUFlS7cppAvj3S22gFpv0pXJdCmVmYOh1UZEHx60AnQEKCXJCHxBmZpV9UOjZ3LKL+AoPUmPYaW0hAydrC9yVGjMqA5Md6pKmxqenpSepHvpWnmu+XxZFNYxyRYqgptm7x6VDsa1+uTo/0epU0udcF83BB/vvd2bP+m46Nkf8rs/4287aQ/nSpkF7FwLg7phD/m0Motfd5VrvlTHkcZg+c1Fb9wf9EZQp06OYmkzH2Oh4hyZLPpOvRG/zODnS/qZw6XTP7T40/UVcI4MykNmzUzNS0cytHh4fjJgDaTaZqhz6zmtR5MymV2Ghk+Hg9E4BWNZzVSGtYVL8h7n5JtTM2sYVfvVQJmZdcs67p9MsnUkzqxhMu0oE1gUugWJ77w1IhIXzMV74txKkYh3/bFoJrhIRHz/Kt5F93HbZT5+2I7stYhE/1tBGZMcMXLpz6wkkbw+PV3/9x0AAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Webhooks
{
    /// <summary>
    /// Shows details for a webhook, by ID.
    /// </summary>
    public class WebhookGetRequest : HttpRequest
    {
        public WebhookGetRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", HttpMethod.Get, typeof(Webhook))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
