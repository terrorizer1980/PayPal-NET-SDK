// This class was generated on Wed, 13 Dec 2017 14:31:54 CST by version 0.1 of Braintree SDK Generator
// CaptureRefundRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+xb30/cuBN///4Vo/Th26Lshpa7nm7fUGlVTmrhCqp04tAyG082Lo6d2hOWVcX/fnKcLPuT0pauuFOeUOyxM57P/PJnw5foPRYUDaIUS64s9S1llRZRHB2QS60sWRodDaIP9bADhEZQQInTgjTHMJrC4UEfDjVwTvDHydF7sPS5IscwMmIag9SpqgQBarjAwlSaL8CMPlHK/SiO/qzITo/RYkFM1kWDs/M4eksoyC6PvjG2WB47Rs4Xxr5Ep9PSH8mxlXocxdFHtBJHihaPOpSrxzzNCQ4PwGT1UZaPCmwg2MfrvW8tTsOrduPoA6E40moaDTJUjvzA50paEtGAbUVxdGxNSZYluWigK6VuzoMMOQ6bzPQOrxg2NlzVf2V+8Qz7jY4tCN+kazMwr+ytQQN2qwrNxleN2VouiMQwkZzDyBJe9qrSPZxqG7GurCWdTtcqd8a5JeqlOVpMmSwcnhz1fnnx/Ddol0FqBJ0/TYRJXSI109ii3yAR0lLKiSXHSSvc88IuedaHY5weowJhyIE2DK4qS2MZUKl2a0nuIZwoXgJnKIhRKrdqiduJVUOgENI/ep2DGODIVFxHwSKEPx+yscx4OLFYrlXVz4KfhYyoD+/wWhZVAYr0mHOQDp7vwgxQF8Mkl2neZiA3+Lva3d1LK1X/pfCkZHg6oSvSIORYsoMRZcZSbQBBqSxQQWmk5n5Yk7SLFrc4/UbxiWnfh5l3wHu+LmkP8INgLLnQJkRy1EJJPR5mRGtBaQU6TLzKIdhJQGbC6iYdtIFUEOdGgNFq2t8OgFK7yqJO16M3m+3gW4DPA3Q3hluCz+WyLMPMKnrtZAfe1vJha/KhkC7d2PrMAwOtZBdejy87umrEhlGtR7GZbNqfmdaSqXB9OAw3hfa+06IGSupGJgbOpYMy6DX1gO/s2EbtnZ0uZLeCMeP1WngZrzsEHgCB8/tgsDHIFiLMG35Mwl+2m+sHEYymswfbhzfGNpdcF4Ol0pIjza4WaXbhHHlufSPdbmqsHEsdso7fsPOAH2Yz7uEAYg74dW7Q8BZzYn34iKoiDwhC2BZMBk7qsaLeaMoEqMocdVWQlekcZFvrrK+MTGmoq2JEdkN7XYtAEAmOKR1UrvFxi+llUyNCCXz0h7aE7m4Ig8QCkg+UZaIP5EqjHS2RZoG3IDGcEZhLSt+lLlvUDlM/MSNAapzQehmurCbR5qCL46OTU0jC0gtIUamOYusoto5i62pjR7F1FFtHsXUUW5cPO4qty44dxdZRbB3F1lFsHcW2PYrt3t82OVS0wHuMyBfSACJtq+1KLSHTkGWxvm8WyASoBXgJmOSkm1pQ0zYTdBB2EDFIDWeHmslq4qV1mbEF8vnTnLl0gyRhY5TrS+Ksb+w4yblQic3Svb293584qs3R+7X/8tm2jFA5NsWa77gyS9TzykMmSd2W81RJH4v/h8rRlnT8Dup2S/eurzn6KsX3OKjhv0xlwUz0jB/24FpML30YHh40dPGj4YKV1JfDOXiH4QPO1WN7wVUKbF8DemW88k0n17OkfOjC2dv909dH+ydQL22pQCxlYq7IXkmaJE9yZDLoerXIcmC+/EkIlmhJ87Bpm7/iZ21zbXRTyeqedD7DSgcjdFvLrXey9DU9Pyvgy1r+zFIwRxev/641s6YYWkpJXpEY3kF8e2Pe0sjBH+sciUpBJjXqVKKCKx9AM2erM6kL/Q1dY1EqimGECnVK8QxEUVFc1w9n4McTRsehf91ba5TWM+fN7xpV6VvLnfc7mxsxRyVaZGNjQAeCMqlJhM6gMdm3GmlWc7H010srfWOxYPb+A3d294uPuYjdSBl38dHFx38vPjZSTKj+Ndcex8jrwaxnFlvXrdXfmiIYtqboKm+XWbrM4serUnwfSeFMZVOqaQqFjiFs9Ii5ivObOHplNJPm9pOHslQyDWh9CteJt8zlu/oXhGgQHR+dnEbhn/CiQZRcPU+aQHZJQ0UlX245qZtk9nXO6+uSUiZxwsiVe2UERYMXu7s3//sHAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Payments
{
    /// <summary>
    /// Refunds a captured payment, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class CaptureRefundRequest : HttpRequest
    {
        public CaptureRefundRequest(string CaptureId) : base("/v1/payments/capture/{capture_id}/refund?", HttpMethod.Post, typeof(DetailedRefund))
        {
            try {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public CaptureRefundRequest RequestBody(RefundRequest RefundRequest) 
        {
            this.Body = RefundRequest;
            return this;
        }
    }
}
