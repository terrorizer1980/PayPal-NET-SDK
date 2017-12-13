// This class was generated on Wed, 13 Dec 2017 14:33:02 CST by version 0.1 of Braintree SDK Generator
// AgreementTransactionsRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7yUT28aQQzF7/0Uls/bbNpDD3uLQtpE6h/aol6iCJkdw040zEw8pu0K8d2r2U02QEgrcuhxHsZ+P/vBGj/TkrFCWgjzkr2eqJBPVKsNPmGBI0612JifWOFHmzTBdgnMgwB5GBoUMGvhanQCkwBz65QFtOHd72hDChQjk4D13efCKQafuIAUubbztlNDN5gcJCVRIG+AvQFDynC3YmkhktCSlSWdYIFfszYeJKyu1zhpYyZMKtYvsMAfJJZmju/J2Ztp7veEddLw47Aw712SX/SPHZwAzibNBs5EqO0nnhb4jcl88a7Fak4ucRbuVlbYDMJYQmRRywkrv3JuU/zTcLeK5y33m/q/pm8KvGQyLDurvynwfZDlvjYmbY470ZCtqTUHma9GD6xDaZfLX42tmwfSHfyjsFVWz1DnGk7aN8lilvog99rAdjYYm+z+wPZYn/CdeaBsNBM+0r2Y5cAJrw+Y3Or/t3tslU3zjo93D2F2y7XuQ7x7WQ43BZ4Hr+zvT4IUo7M15UnlbepgLlXjJ9YmGKzww8UE+0hiheXPN2WkNltM5cw6Z/3i9eA6levtIG7KvX/Ki9+Ra2XzXUlX6TwYxurt6enm1R8AAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.BillingAgreements
{
    /// <summary>
    /// Lists transactions for an agreement, by ID. To filter the transactions that appear in the response, specify the optional start and end date query parameters.
    /// </summary>
    public class AgreementTransactionsRequest : HttpRequest
    {
        public AgreementTransactionsRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/transactions?", HttpMethod.Get, typeof(AgreementTransactions))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }

        public AgreementTransactionsRequest EndDate(string EndDate)
        {
            var strParams = Convert.ToString(EndDate);
            try {
                this.Path = $"{this.Path}end_date={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public AgreementTransactionsRequest StartDate(string StartDate)
        {
            var strParams = Convert.ToString(StartDate);
            try {
                this.Path = $"{this.Path}start_date={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
