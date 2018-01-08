// This class was generated on Mon, 08 Jan 2018 16:45:19 CST by version 0.1 of Braintree SDK Generator
// TemplateListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7yUT2/TQBDF73yK0Zy3SeHAwbeoLRRRaKBRL6hSJt5xve161+yOC1bV747WTty4CSCVP7fkebz+vdk3c48fqWLMULiqLQlPrImCCo855sHUYrzDDM9MlAhkLVQc8pKcHOSBSVjD5sU4gUXJkF6HWPpvEaRk4IqMjQpI68AxcvrpNNSldwyuqVYcIhTBV1315nCogy+M5Qkq/NRwaOcUqGLhEDH7co+Ltk7MUYJx16jwkoKhleW1l8Kw1REVvud2Le04Sqx9HYiHwNIEB8Z1GIFj7V3kCVySbRhMhCVZuwQfYOm84+UELmrOTdGu/2+d4Z1tu1M2jQFHFSt4d9xb11xQYwVIJJhVkxqHCmchUNvbOlT4mUmfO9tiVpCNnISvjQmsB2EefM1BDEfMXGPtw5XCUybNYdSqK4VvfKieanOS8qmWPsFReoZ0ZJL6PvTa0PaNsYN1VJ50/9d9T0kCXzxe9WN+/rANj7mY9WHbRRtSOGLcVvfDDhUpIftCusX9+lnXp34b6n6SRuCDtJ+6f/wfkM+Mu4UtBjhf3XC+JxrWuNuxhY2yO5yns8XJ+ewCugqQkjr6O6PTfNpu9VCe6iMUPowmLu4M8t/1O0/ba9ddt9TG9gZp/w2N1+C/v6jFukG77EPrRvjb6tjBzAElruTiZxP8PNqrB4VH3gm79S5Cqmtrckpfnt5E71DhqUj9gaX0GjN8e7LAfqdhhtO7l1Pj7rzJjbueDmhTVHjyveZcWF8ISROPvGbMXh0ePrz4AQAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Invoices
{
    /// <summary>
    /// Lists all merchant-created templates. The list shows the emails, addresses, and phone numbers from the merchant profile.
    /// </summary>
    public class TemplateListRequest : HttpRequest
    {
        public TemplateListRequest() : base("/v1/invoicing/templates/?", HttpMethod.Get, typeof(TemplateList))
        {
            
            this.ContentType =  "application/json";
        }

        public TemplateListRequest Fields(string Fields)
        {
            var strParams = Convert.ToString(Fields);
            try {
                this.Path = $"{this.Path}fields={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
