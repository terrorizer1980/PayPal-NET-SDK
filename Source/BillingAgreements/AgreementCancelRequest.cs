// This class was generated on Mon, 11 Dec 2017 17:19:32 CST by version 0.1 of Braintree SDK Generator
// AgreementCancelRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6RTwW7TQBC98xWjOZu6IE6+VQ2oQaIJJOKCqnTsncRbbXbd2TFgRfl3tHZwi4NAiNNqn2b2vTdv9oC3tGcskHbCvGevFxX5ih1mOONYiW3UBo8FXvdwBILSOmf9DsaWDMoO5rMLmHvQmuH9anELwo8tR4UymC4D6yvXGgbycD/2baKS8saceILcQygfuFL4ZrVOtaFnJwc+KIPWpDBUlxx7KmGKwcM2SH8dtDtKXUDe9ODIB7QPbTq8gaoVYV91F5jhx5alW5LQnpUlYvHlLsMbJsMyRd8F2U+xJWn9C3bAddekoUYV63eY4WcSS6Xj6bA31pwNel0zzGcQthPxGk72kuQrEeoGlssMPzGZhXcdFltykRPw2Fphg4VKyxkuJTQsajli4VvnjndDDUcdHhklX418qxQOzMZw/mRjGuSZqSswT/ef3oYMFPruM8P/ZPMEPPf59xjSUv12/JOtespgUFrV5Hf8v/qGHI6pKjbBRx7eSXCG18Er+1M4SE3jbNVvdf4Qg8cMb1SbD6x1MFjgcrFa47CIWGD+9VXeUJcEx/z0WV+OHmJ+eL5+x3z872+/N1wpmxR8G6+DYSxeX745vvgBAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.BillingAgreements
{
    /**
     * Cancels a billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with an optional note that describes the reason for the cancellation and the agreement amount and currency.
     */
    public class AgreementCancelRequest : HttpRequest
    {
        public AgreementCancelRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public AgreementCancelRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor) 
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
