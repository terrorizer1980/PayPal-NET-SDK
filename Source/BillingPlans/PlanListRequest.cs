// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// PlanListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7xWTW8bNxC991cM2EsLrD7cQw+6CYldF3BrtxFyCYzsaDmrZcIlGXJW9ibwfy+Gu5IdyQ0M2PDFgIfU8L03M2/2m/obW1ILFSy6qTWJVaHeUqqiCWy8Uwt1YRInWBtrjduA3EtTWHmojWWKwA0NQeAGGTAEwgjG5YNIKXiXqIAUqDJ1D94R+AitjwQ+P4EWvnQUe0CnIeDGOJQwBIzYElNMU1Wof+TK1T6kFh++qVUfBHriaNxGFeo9RoNrSztKuKEjNquG4CtFPzFO0y1pcF27pgi+zoBrExMLChrorGljMjWCRCy35GzHNQpD7qIjfch4Cm+pxs4ymATlvBQOyxixH0DPC/Uvob50tleLGm0iCXzpTCS9D1xFHyiyoaQWrrP2rngS54/JfH2c+D3XsWIepOTgHSAk4zaWMr8pnPkIdIttsFSAqaHcJy4zoZN5WQBh1QxapcbfJGByu/5Ywhat0fK3I/kFgvNu4miDbLZU5P+kDmAc04bi93qdvJpgiZG7dKTWWW7u9KC7D+oL6x4wH8GQ4pXwsme0H+Mu0yHuP502FTIluGmIm3E+96CNq2ynaeBVDrkMU5vKPH1jJLd4CbUhq9MU3u9qWPYS9hFK51+mPteFOifUFL+b7OtCnfnYHsaukJvDmDxBiQcMklJCA9khthf0Skp1MRjcgaZHKi7Hsah37fzGO0YxAk2MxiaoZT5y+0ta0Q53BvHhfLk6vVy+A2vc53T9y0z7Ks0wmJnfUtwaupn93CCTxzTJV359rpT3Vnhh3Gd4wAUu15+oeoRyfviYtwMUHEIjDspOIllk0s+n9fszJ0IK+IjhSYF+SGQo4cti+fF05ol61IDz+ZENj9YiPfeqLpLn/Gk489I7WnFy9eFmGHtmdH0tc9oaRwkafwMtun4kPH4keHe/QsZkx5b0f+lTXr9dIi1rrEJbddKoGeHT4L+Igd0VSsyB3OhBCkOwYsHGu9mn5KVlz5nDX8SN12qh/jhdqcHL1ELNtiezgH1LjtNs/MSaZI1mqlCnt4EqJv0uL5g3XpNa/Daf3/30HwAAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.BillingPlans
{
    /// <summary>
    /// Lists billing plans. To filter the plans that appear in the response, specify one or more optional query and pagination parameters.
    /// </summary>
    public class PlanListRequest : HttpRequest
    {
        public PlanListRequest() : base("/v1/payments/billing-plans/?", HttpMethod.Get, typeof(PlanList))
        {
            
            this.ContentType =  "application/json";
        }

        public PlanListRequest Page(string Page)
        {
            var strParams = Convert.ToString(Page);
            try {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PlanListRequest PageSize(string PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PlanListRequest Status(string Status)
        {
            var strParams = Convert.ToString(Status);
            try {
                this.Path = $"{this.Path}status={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PlanListRequest TotalRequired(string TotalRequired)
        {
            var strParams = Convert.ToString(TotalRequired);
            try {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
