// This class was generated on Wed, 13 Dec 2017 14:33:09 CST by version 0.1 of Braintree SDK Generator
// SimulateEventRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/8yWUW/bNhDH3/cpDtxLByhSu2AFpjejSZEMXZ3V2V6CID2Lp4i1RGrHk1OtyHcfKMmGI9uIh6ZZnwSQJ/L35/2PvC/qPVakUuVN1ZQoFNOSrKhInZDP2NRinFWpmg3THhDuaF44t4AuMoZzC1IQ/DabvgemvxvyAnOn2wh8TZnJW0DwWNUlQY1t6VDHKlJ/NMTtBTJWJMRepVfXkToj1MTj0beOq/HYBUoxHvvQb37Z1qTSL6r/rsnhdBD2F7LBeUkj4UePC69cthipV5GaMGPbb/YyQKCe2rJVaY6lp57KMOn1wAW7mlgMBew1phc29nYbr9vmRkLQGO2yoJ4CLFYUw2w4bmcJXN4lxTfz8MecdB/pY3jrGAizYpWrCGp2S6MJnC37n/+7NOFmpMw2ZXkfPSqv4XKnrj8/vIPccSdifeJW1850lsvBVUaEdPQg4vwEjO+EBayvTc6BEobNb4zeqeT8ZJWMIXAbP4h9au7r+xDla2c9jSpiTyFs0U8eeh2sE5ObDMP0tzd+xoRCN2Kq3c7XoabRaggRcFeQfWiWLWS4Qw/9qjoCY+Hq3AqxJRmtlTuuUK5fFCK1T5NEnCt9bEjy2PFtUkhVJpxnx8fHv/7oKQtrH/0Sv/7pmfx20I0gBQoIm9tbYtKPnMyzgi+JfaDdzz5EhBRtcv8PxIeW9Lc/03fGLmCDBKbzT5TtqOLS2IXfLmULGGAC93DvHzGFd03D1dnk8nQ6mUH36/WLRLvMJ1ibpEAhh/6omxjb+/VXKnJ7BDB513C229yrye/S3yu4/bUZ3umVddZSVnkQt9fuT9NsHCjDN1WF3O54DoYZ0Bs+XD3SO069bzU+d61fBB8nof2rQhQ2Ujg2/2xdy/HHp3r63jgrZIdeUGFdlwNV8sl3l8+ZSP07SeG0StXFdHap+qZSpSpZvko2hfhkq0c8/VxTJqRngtL4N06TSn9++er+h38BAAD//w==
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
    /// Simulates a webhook event. In the JSON request body, specify a sample payload.
    /// </summary>
    public class SimulateEventRequest : HttpRequest
    {
        public SimulateEventRequest() : base("/v1/notifications/simulate-event?", HttpMethod.Post, typeof(Event))
        {
            
            this.ContentType =  "application/json";
        }
        

        public SimulateEventRequest RequestBody(SimulateEvent SimulateEvent) 
        {
            this.Body = SimulateEvent;
            return this;
        }
    }
}
