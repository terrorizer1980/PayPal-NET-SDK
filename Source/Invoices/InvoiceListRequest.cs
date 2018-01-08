// This class was generated on Mon, 08 Jan 2018 16:45:15 CST by version 0.1 of Braintree SDK Generator
// InvoiceListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6xVwU4bSRC971eU6ohmbXYPe5ibBWxAIYEEK5cI2eWZsqeg3T101xgM4t+jnhkb2wMkEr5Zz1bXe6/eKz/hV5ozpih24STjnpGgmOAxh8xLqeIspnguQQPM2WcFWYX2t6EHQwdTMcoetOA1DlqQApUlkwex9XeeQ+ls4ASWroKMLISSM5kuwVkG52HuPIOrJ5KBu4r9EkryNGdlH3qY4LeIXa4hTH8+4XBZNuyVZ+wxwR/khSaGW1klzRgT/MzLFuhoG8DBI3v3t2dDKgs+ALE5P4Cb1ryjH/FzVzwmOPCelg2FwwS/M+UX1iwxnZIJHIG7Sjzna+DSu5K9CgdMbWXMc/JnCkZBHn8jY1gw2Go+YR/ZvmzCNQomPBNrxc7gXrSolTX+C+cwjjPGexY0cc4w2a4gdUpmlLnK6sivHnxX25nNJSPlAPcFa9GmrX4H6nfarIXdsPXgmKdUGQUJMK4570fmdYKnTDn7rTheJ/i/8/Nd7JK02MXiCA7acIhPRqgh3WAbwahXOWqLuWPm+8advxleOCILYjNT5bzh5jo3ra02h9PB8ORicAVG7G2AqfNgaSEziiM+6uVLgc+awV2BK0ZbQjfAnTJboMhnqwMUIDD5rIi5qIzusP7vg0E/F3sLGzTgYnLD2Su7qh3c0rFCulXuuj62/KDjeiXj0vNCXBXGG7vYyH4MfOB963zzQm0UekvdNt7V2ETutaMV/z7mpFl7qJrlZV6UvdB+Cvyc4JGzyrbtIFJZmnhlxNn+TXDxcJ2qll9YC5djip9Ohth0GVPsL/7pN3TFzvor4n1M8OSh5Ew5v1LSKhy5nDH99/Dw+a9fAAAA//8=
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
    /// Lists merchant invoices. To filter the invoices that appear in the response, you can specify one or more optional query parameters.
    /// </summary>
    public class InvoiceListRequest : HttpRequest
    {
        public InvoiceListRequest() : base("/v1/invoicing/invoices/?", HttpMethod.Get, typeof(InvoiceList))
        {
            
            this.ContentType =  "application/json";
        }

        public InvoiceListRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public InvoiceListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public InvoiceListRequest TotalCountRequired(bool TotalCountRequired)
        {
            var strParams = Convert.ToString(TotalCountRequired);
            try {
                this.Path = $"{this.Path}total_count_required={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
