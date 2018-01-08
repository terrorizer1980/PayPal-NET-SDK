// This class was generated on Mon, 08 Jan 2018 16:45:17 CST by version 0.1 of Braintree SDK Generator
// InvoiceSearchRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+xZS3PbNhC+91fsoJdEI0tJ3KZT3VzbmbhNbDd2e4k90opcikhAgAWWTphM/nsHfFkUSTdNXPWgnDizD3C/D69d7EdxigmJmZD6xsiAJo7QBrEYiyNygZUpS6PFTLyQjh1URg44RoYEOYihdIDASiYrcQInGjgm+PXi7BQs/ZWRY1iaMB+D1IHKQgKERem1ALN8QwGX47mUAhnJYnjqjCvG4veMbH6OFhNisk7MXl+PxXPCkOym9JmxyabsHDnelL0qA7zMUxKzj6L8iouahD/RSlwqqkjyMMRY/EZ5W9Dm6qRkqUaQNr/0GA6sxbz8zSP/ewzPtMrFLELlqIxHWgobwbk1KVmW5ANuAlwaowh1N0L/R3lDYSvKNeFmpKEMkMnBu5g4JgtsQEnHkJANYtS8V/vezr0s59eSS412NIGTCBZsM1qMG2ExiAOjVX7HUKVrAXTAN9MDTjpTquuDSt3afSXZ/g+fxg3jjq3Uqy7hlKBULbZrSZvqy5hAaskSFShivxzARAWThQNgGFpyWwtbh/PAEvro5iEytSH0aLtwSIdQW4G3gsjYAlF9mMBRJU2QQToY5Xmej/ZGL1+O9kZhOILRh9EY0EFIkdTFJMPrE81kNXHhPL2UCcGzYoTrBzFzOptO2RjlJpI4mhi7msacqKmNgv39/Z+/dxT4ePZ+nDx9uEUuw4z6aVxT9DMYZrTr5FWI+wncUA6QuNsEppgnpLmfwA1lP4GV0S4QeZhZSzrIu1Qq847snA2jmmNiMs0tMnvVbTp/QUd1TuNZ9BdSJDXqwJ/7N6gyf3EqZAohkqRCBw+WqFAHNL6dg4zGQBxMHt5bvjC0eIKKi0MTthdOcEtSG+F+dXtBbQGB8Snd7eQvczi5OIMfnjz+6V/NnE8hvmgHFLS2oq8l7dDLOYMs9VnOKYRyJRkw8mD8ag8pkAkqB458ysZ++lpLukbV7A9MU2tSK/3uaNFxH7ivPwO5zpIl2Rb0RtSXfpR5aWlyz7uq+e9GiCmu2nNTCbrhmShyxA25VfZsyWWK3RajnTv5oRtyLe3G7bXgtdsJfWgtWApkKv1Bv8yc1OTcXHvNOpBhm89OVpshoB4C/BBbBxlJ6/guhC2DL4BX+P8/2BTeDW1d/wXIvPs2gTlGy3dUG/36LrDC7lvF0TDWW3N0VEM87njdUfI0WHn0qgep3HUaB+uPXvUQjTtUg9xBJ2duk8JSNJzQlSYTuDR16rHMK+G4elXNgWPpqgoEHaAG9HAmnhCg95ikisawuKr+dyVm8PpKvDp+9sfp0fHRlbhe3DMFg0+YZYEV+Fx9busB1xkZMPjHp82YoHCFwtVn74S2+565rWozS9O7qs1e9bdq81u1+R9Vm9efvFm5BzbaIfU1qKTjLiEtLnobRz4FrbsAa+/4h6ibltDt5mz6DNUu1SE8P7g8Pju4ACX1W1fwofFGroo08P56KlXbpguwjqgFdE3YBnxQnawedIMFXbso3Ij66VceMi+kfgtrYcBZcSj0vHB5BtuPWpWke7t0WV9oes+LYkoWqaUbaTK3WJuLtaM0UwyO7hun1Eyrvrp97UoYuip6MZZLrnwNaE3YWoNzoBn51XeE33CHRjPpqv0oME2Vv7Sk0dM3zvi78Tlz+pI4NqGYifOzi0tR9jHFTExvHk/LeKVeTZu+7fH7lAKm8KK4x4ujdvbk0aNP3/0NAAD//w==
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
        public InvoiceSearchRequest() : base("/v1/invoicing/search?", HttpMethod.Post, typeof(InvoiceList))
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
