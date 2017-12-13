// This class was generated on Wed, 13 Dec 2017 14:32:31 CST by version 0.1 of Braintree SDK Generator
// InvoiceSearchRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+xZT28btxO9/z7FgL9LIshSErcpqptrO4iLxHZjt5fYkEbLWS0TLrklZ51sgnz3gvtPtlZSkkpQD8pJAMUZvvf473H2szjHlMRIKHNnVUQDT+iiRPTFCfnIqYyVNWIkXinPHupOHjhBhhQ5SqAKgMgpJqdwAGcGOCH4/eriHBz9nZNnmFpZ9EGZSOeSAGFSRU3ATt9RxFU+n1GkYlWmp05e0Rd/5OSKS3SYEpPzYvT2ti9eEkpyi60vrEsX2y6Rk8W2NxXA6yIjMfosql9x1YjwFzqFU021SIFGR5qzSpQGcNaOECAfOYdFlfVJGA3lhdGFGMWoPVXDK0eybbh0NiPHigK+Fs/UWk1ouoDCiOqO5BJQUkXI5OFDQpyQA7aglWdIyUUJGj5oYuezqqqZc+QzazwN4CyGCbucJv22sUziwRpdrElVhZacVsTmZkWQybXuxqDW834b6hpG+NJvxfXslJl1taUUle4Ie50QKKNYoQZNHOYZbFzqVgYASunI7wykkePIEQZ0Y4lMSwGTkdD0gtALYutKzM22h5O6NUUG5aFXFEXRO+i9ft076EnZg96nXh/Qg6RYmXLS4O2ZYXKGuAweXquU4EWZ4fZRwpyNhkO2VvuBIo4H1s2GCad66OLo8PDw1/97igKeg58Hzx/vUC2Z03qhZE77rlHN+Cs67bdGGRYpGV6vUd1pH7Q6zp0jExVdtbT9QG7MllGPMbW54Y5ev6GnxgsEmcJxHyuDJgrn7B3qPFxLGpkkxIq09PBoihpNRP25yDn1gTgaPN7axbtqAURzsg+JHNaXAjQ9ILLB8cwncVrA2dUF/PTs6S/fNQPhHv5Xi7VUrwO0mgjIs2AMzkGqmWLAOEAPa1RSpFLUHjwFQ8NhTh4sxIZDu6oxy5zNnApr+gH5bbC8/QaeJk+n5FZc2JVFq7pseeG34y7gyXC2/GCwceyJW+Fq3+jI55r9DsGNvfq0HGH4F8K/uwG5akYdRSpT4ZCd5l4Z8n5swj/f4cnaFNCkgJBi5wRi5TxvgL6M/2+ga9wIeQjfJXDP6PgbPHHZ74crbhVb64srsfbcGVc6fdUb11rtu05f9ceVTnvkkNfoxblfa1yqLgO4ts1NPC3qxn5dNyuAE+Vrr4we0AAG7IPAHugjppmmPkxu6vFuxAje3og3py/+PD85PbkRt5Mt811ZtaqeAlEwoGPXJPyGClZCUIZCGRocJ6Hrlq129a7Js+zHu+bHu2azd83tl9CtWrkLVei6sOy71JeW54P1aiqy92qqx2jawvt8B7U133orGQkvj65PL46uQCvz3pf0Dd6pWWmPtlfKrkl1Oak524fcjuqDLPBrYaN/+CRZAPh8w03/Spn3cA8GXJR7eEltI4i19Ojuyjkx9JEnpdaTzNGdsrmf3BP53kGWawZP22alDNNs2Wvw3oG8lEu1Zqq35INpuPcdaMU3m41P4rBBjq1hMvVXGoFZpsPVoKwZvvM2XDAvmbPXxImVYiQuL66uRfW5R4zE8O7psMKrzGzYft46/ZhRxCSvysvw2EoSo2dPnnz53z8AAAD//w==
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
    /// Lists invoices that match search criteria. In the JSON request body, include a `search` object that specifies the search criteria.
    /// </summary>
    public class InvoiceSearchRequest : HttpRequest
    {
        public InvoiceSearchRequest() : base("/v1/invoicing/search?", HttpMethod.Post, typeof(Invoices))
        {
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceSearchRequest RequestBody(Search Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
