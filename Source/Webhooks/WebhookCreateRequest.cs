// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// WebhookCreateRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+xWwW7bOBC971cMuJckkK1kD3vQzUiyyALZtTf2tofAqMbi2GJMkyw5iisE+feCkmw4dpM26KEXn2w9Dsk37z0N9CT+xRWJTKxpVlq77BeekEkk4opC4ZVjZY3IxLiaxccZBaht5aErB60CkyEPbIEeyXDoi0T8V5GvR+hxRUw+iOx+mogbQkl+H/3L+tU+NkIu97E7+lxR4EntSGRPov0VH1saIhEf0CucaXrZzkEfQ0NgPaysp20PdvZARUt84D3W7dnn8U6UQ6Nrkc1RB2pJKE9yC4y8deRZUWS5ZXUdhYDm4YBYI9Inrh2FA3IDAxgJgJ1D5aKkTKaTNT6tS1WU8U/YuPHCjD5MdpfYAmq92a5MoSupzAIMrTcgBuCSakBPgFKSTCA4KtS8jjhgYPIqLOEkP8tPYa20hAK9bC7y5DQW1BTmO13lbQ8vT8rP8r3tMTgNv1A5Zz2T7EglcN+uPaLSUbgOn578voV6DdSL9/Vj8emed3++6R37as86U2n9nGz9C+yVWRx6p+SBZZOS4O+raFhsc2PETyZpj86tMkvYuRaGTWAP+Wlllm+nyrdvUc+Txij5/c1gcj0cjKHZOj1JpS1Cik6lJTJZDL1mIX2fwN9v6TWFK6+/KfH/d7fAJTKoAIU1c7WoPMkY8XYAgTWQa1ugLm3gHObWx8TbVQx8PhqOJzkYy2quCmwkXFEIuKDQnlpYw6i6Vw2UmVu/aure5eQruZo+x6LgrAn0o+PrOLeOc+s4t45z61fPrUtrmEz31SXQOd0RSR+CNSIRN8zuH+LSSpGJyFe0n28iE+njRbrLPaRdzKLV118cFUxyzMhVuLSSRPbH+cXzb18BAAD//w==
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
    /// Subscribes your webhook listener to events.
    /// </summary>
    public class WebhookCreateRequest : HttpRequest
    {
        public WebhookCreateRequest() : base("/v1/notifications/webhooks?", HttpMethod.Post, typeof(Webhook))
        {
            
            this.ContentType =  "application/json";
        }
        

        public WebhookCreateRequest RequestBody(Webhook Webhook) 
        {
            this.Body = Webhook;
            return this;
        }
    }
}
