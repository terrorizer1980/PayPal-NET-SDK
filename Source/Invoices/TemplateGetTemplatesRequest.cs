// This class was generated on Wed, 13 Dec 2017 12:24:30 CST by version 0.1 of Braintree SDK Generator
// TemplateGetTemplatesRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7yUTU/bTBDH78+nGM15n4T20INvEdBSiZa0RFwq1Ey8Y7yw3nVnx7QR4rtXa5MQSKJK9OXmnR3P/ubtf4cfqWEsULlpPSmPrli/rg4JDR5xKsW16mLAAk9d0gTkPTQsZU1B/y+FSdnC+qcRzGoG75JCquP3BFozcEPOJwNkrXBKnD+DhbaOgSF0zYIlQSWx6b1XwaGVWDnPIzT4qWNZTkmoYWVJWHy5w9myzfBJxYUrNHhB4mjh+SGpyrG320lkvOEKNIKwdhLAhf5l4dTGkHgEF+Q7BpdgTt7PIQrMQww8H8F5y6Wrlg/njRgx+GUfZVULCNSwgfdHQ7aWK+q8AqmKW3S5VmhwIkLLIZMDg5+Z7FnwSywq8omz4VvnhO3aMJXYsqjjhEXovL+/NHjCZFmeVOfS4NsozXPblLR+bstPcNKBIYfMpqEOg21d6dnGZDwr9s5ZgVg9NvNxQn4z68fOT4Zx2qZZz9lerLVHbv2ugdsgfPOivphfDuiwFXsRh+t/wHfqwg1sMMDZ4ppL3Qb2LtzsXqiTyez4bHIOvQdoTT3rrbN5p3yvEFRm/wRVlCdbkraW789mN80is51Lrz37i/9Umv5+D1artQ26X44nASgTZN592/Uyrst7g4cxKIcHWUBqW+9Kyi+Pr1MMaPBEtf3AWkeLBb47nuEgL1jg+PbV2IXb6EoXrsZrtDEaPP7Rcqlsz5W0S4fRMhavDw7u//sJAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Invoices
{
    /**
     * Lists all merchant-created templates. The list shows the emails, addresses, and phone numbers from the merchant profile.
     */
    public class TemplateGetTemplatesRequest : HttpRequest
    {
        public TemplateGetTemplatesRequest() : base("/v1/invoicing/templates/?", HttpMethod.Get, typeof(Templates))
        {
            
            this.ContentType =  "application/json";
        }

        public TemplateGetTemplatesRequest Fields(string Fields)
        {
            var strParams = Convert.ToString(Fields);
            try {
                this.Path = $"{this.Path}fields={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        
        
    }
}
