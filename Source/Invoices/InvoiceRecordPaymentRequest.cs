// This class was generated on Mon, 08 Jan 2018 16:45:16 CST by version 0.1 of Braintree SDK Generator
// InvoiceRecordPaymentRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7xWX08ctxd9/32KK+cFVsMOCb+26r5RIAptgW1AVSuEkrv2HcbBYzv2HegU8d0rz8zOMrtBTRXE2+rMtfecc//43otTrEjMhLa3TkuaBpIuqB2PTUWWRSYOKcqgPWtnxUycYLiJwCVBZOQ6gisALfSnM1g0cHyYAUbwqNUUjq00tSJA6G8ERYzagFt8IsnAJSao0Ja6a5dhFXHpFKBV4Lik0J+LoG0b9/P52SkE+lxTZFg41UxFJn6rKTRzDFgRU4hidnmViXeEisI6+taFah2bI5cj7F5cND65Ezloey0y8TsGjQtDY9c+aCUy8Qs1Pbxh20VJcHyYzErc+1PADioMN4NbIhP7IWDT/eluJt4TqjNrGjEr0ERKwOdaB1JixqGmTMyD8xRYUxQzWxvzcNXFUOTukkHBvPf1sLVxU0mycKShB8Y65qMkxv/EuAceU14ZfFCHQFY2m8SwcnVbiCtqAzQm9xNGWtZV4QKgMVBoi1ZqNHCLpiYIZJBJQaHJqAhbCzRoU+EO5VlTBsRyuv1s2p4qHtlrPnCKRvrkyoyxwj0wxEwBlhEgXWqu2LeQavvv/Az+/+b1D89RTtm/imhtHbFfImPqXc6g9qnqT0Hpa82ARRKTWkKR1BWaCJE8BuSUvpUqbQdVbWbTCfQ+OB80Mo3teJY2+grlCnksvAc2Oz99gLuS7Kj774YhOcQULlTIoCNMmqZpJjuTk5PJzkSpCUz+nmRrllweW6ZgieEQmfILXRG8bW+42iqZ/SzP2TkTp5q4mLpwnZdcmTwUcm9v78dXkWTiuPPd9Pvtb23kryyWbqiPTBugTduGpyDVuAv9kzCFJRO401y2ln48+uPi6P3p/q8fh0PceHqZDrBurQ56YCzorP2BZgr7kAIAY3RSt8No0NGTf6FscEAbsS2C9Qds49MXn7N2yMIcmzmalfGro19M1Xz/z/k3Jep5BKe/fVJy/3FT9KOgFyW+QfYpgo9dTTNi2M20vYbCuLtu2lx2ax4EKmqrrrZy5WTM0et8iM5f9YMqfuh3wi54e7maxdp7Fziud2AX1tnT/tmQ8kdf0ozrL0ivsQuwQHlzh0GBdJVH1gttNDfPYvDVQ4qK3tlI3T0JzsSBs0y235QEem+0xGRm/ik6KzLxjtmfdANqJuZn5xeiWxLFTOS3rx95tbQqv19thA/5xi599JcnyaTO2925ffdnb3Z3H/73DwAAAP//
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
    /// Marks the status of an invoice, by ID, as paid. Include a payment detail object that defines the payment method and other details in the JSON request body.
    /// </summary>
    public class InvoiceRecordPaymentRequest : HttpRequest
    {
        public InvoiceRecordPaymentRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/record-payment?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceRecordPaymentRequest RequestBody(PaymentDetail Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
