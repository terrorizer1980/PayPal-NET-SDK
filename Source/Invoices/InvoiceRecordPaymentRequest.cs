// This class was generated on Mon, 11 Dec 2017 16:45:25 CST by version 0.1 of Braintree SDK Generator
// InvoiceRecordPaymentRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7xW0U/cxhN+//0Vo80LnMyZhF9b1W8UiEJVwA2oaoVQMucd4w3r3c3uGOoi/vdqbZ/vjru0qXLi7TT37e4333wznkdxjjWJTChzb1VBU0+F9XLPYVuTYZGIYwqFV46VNSITZ+jvAnBFEBi5CWBLQAPD6QRmLZweJ4ABHCo5hVNT6EYSIAw3giRGpcHOPlHBwBXGUKkM9dfOYTVxZSWgkWC5Ij+cC6BMh/v58uIcPH1uKDDMrGynIhG/NuTbHD3WxOSDyK5vEvGOUJJ/Hn1rff08liNXK7FHcdW6qE5gr8ytSMRv6BXONK2q9kHJNaWuKoLT46hPpDsAgS3U6O9GgUQiDr3Htn9nPxHvCeWF0a3IStSBYuBzozxJkbFvKBG5t448KwoiM43WTzc9hgL3l4yk80HK4065dfJRtTXa+UqZwn8iOASWGS4kPGq8J1O06zywts0Gq/2EgeY2Ka0H1BpKZdAUCjXco24IPGlkklAq0jLAzgw1mujD0W0NJUBcTHe3lsiXvFAsElxN5AA0MZOHOQIKG1siDMaXXddcXsD/37z+YRuOSP6Va6feGtG+ENC4aNNzkOpWMWAZqUcPSypUjTpAIIceOdZkkYMyYw5dueIJdM5b5xUyrSa/Fd9/RZ4SmTZ2ZvwDHioyK935MM6tEVNaXyODCjBp27ad7E3OziZ7EyknMPlrkjxT4PrUMHlDDMfIlF6pmuBtd8PNTsXssjRla3WYKuJyav1tWnGtU18WBwcHP74KVESOe99Nv9/91s77Sif0c3ajRuMojm61fhjJU5g/Cw+Kq06/jye/X528Pz/85eN4iFtHL+NlYzfU+KL7gXoKhxABgCHYQnXDYqQ9cH0hpdmjCdgV+B++F92kgxzbHPVCzMXRjfLnh3/k3yT+drKKz27Mawn0oty+xGdZp9i24wajzC2U2j70A+C6X4bAU9kYebOTSluEFJ1KR3T6apgd4cOwOfXg3fkCExrnrOfwvE96WK9G99hYxKV/4tgZLogfOethhsXdA3oJha0dspoprbjdip43TxEVnDWB+ntiOBFH1jCZYbkQ6JxWBUYx00/BGpGId8zurB8jmcgvLq9Ev0qJTKT3r5e0mkuVPi72pqd0beM8+dNRwSQvuw3zyEoS2Zv9/af//Q0AAP//
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
     * Marks the status of an invoice, by ID, as paid. Include a payment detail object that defines the payment method and other details in the JSON request body.
     */
    public class InvoiceRecordPaymentRequest : HttpRequest
    {
        public InvoiceRecordPaymentRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/record-payment?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceRecordPaymentRequest RequestBody(PaymentDetail Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
