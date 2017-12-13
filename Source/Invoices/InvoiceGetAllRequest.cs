// This class was generated on Wed, 13 Dec 2017 14:32:30 CST by version 0.1 of Braintree SDK Generator
// InvoiceGetAllRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6xUQU/bTBC9f79iNEfkL6E99OBbBLQg0UJL1AtCycSexAObXbM7DgTEf6/WNiHYqVSJ3KIX7857b9+bZ/xBS8YUxa6cZDxYsE7IGEzwmEPmpVRxFlM8l6ABluyzgqxC+3kYwNjBXIyyBy14g4MWpEBlyeRBbP2f51A6GziBtasgIwuh5Ezma3CWwXlYOs/g6olk4L5iv4aSPC1Z2YcBJvgzYpcbCNPrZxyvy0aA8oI9JvibvNDMcKuspAX35Izg4Im9+9+zIZUVH4DYnB/BzWuqRoLG3329mODIe1o3Uw8T/MWUX1izxnROJnAE7ivxnG+AS+9K9iocMLWVMS/Jv5GeBHnqMx8XDLZazthHgm9+u4b0jBdirdgFPIgWtZjGZeEcpvHa6Z41zJwzTLavQZ2SmWSusjrxrxd25ZzZXDJSDvBQsBZtjOqjUB9tQxS6KRrAMc+pMgoSYFrT3I+ymwRPmXL273J2k+BX55dd7JK06GJxBAdtOMQrI9SQbrCNdWft6/W929m/3YmEI7IgNjNVzlvmbZLRumhzOB2NTy5GV2DE3gWYOw+WVrKgOOKj1l13RfU1yZvaThktUBz9LtAUIDD5rIgvXhntEPzywdSei72DLRpwMbvlTPusa7N2trBv59Tyo05rr6el55W4Kky3TN7KcAxu4H2r+us+2eriTi1NZnbtlbjHl6RZu0uaJ8m8KHuh/RTuJcEjZ5Vt2xmksjRxK4izw9vg4m45VS2/sxYuxxS/nYyx6R6mOFx9GjZ0xS6Gr8SHmODJY8mZcn6lpFU4cjlj+vnw8OW/PwAAAP//
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
    public class InvoiceGetAllRequest : HttpRequest
    {
        public InvoiceGetAllRequest() : base("/v1/invoicing/invoices/?", HttpMethod.Get, typeof(Invoices))
        {
            
            this.ContentType =  "application/json";
        }

        public InvoiceGetAllRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public InvoiceGetAllRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public InvoiceGetAllRequest TotalCountRequired(bool TotalCountRequired)
        {
            var strParams = Convert.ToString(TotalCountRequired);
            try {
                this.Path = $"{this.Path}total_count_required={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
