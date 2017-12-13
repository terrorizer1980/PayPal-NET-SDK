// This class was generated on Wed, 13 Dec 2017 14:31:57 CST by version 0.1 of Braintree SDK Generator
// PaymentListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+RXX08jNxB/76cYmReQluwCKlJXOlWn4+ghtVda0lYqQmRYT7K+7to+e5awOvHdK9ubBJKcem1RXu4JdmzP/OY3f/NJvMeWRCks9i1pHjXKs8jEGfnKKcvKaFGKH5VnD8MVD1wjw5wcQeUImSTc9cA1wXX6Xty82d8b/rtNBwdQYdMAapl0oCNQGlD34BmZRjCuCQIE8LWZ+6j0udnwpEVJwCaetuSqGjXDvDbQ4l+UHgU7IxgbmKqGyW1TZC2hC+bDmSNvjfaUQW86qFCDt1SpaQ9GExgHrXEEJhKCDXzsyPXRD4szpTGIwaLDlpicH8EVEVyfR9tKz9Zu3uzn0lQ+R6tyc0/uXtE834s6D1dKDkYiE78E4eVSJsrrT2Lc2xAxpZlm5EQmfken8K6hIZSV6fRmDAOzumvvyIGZgmJqfeAwkr1GQjD82jnsk6UiE78Syp9104tyio2nIPjYKUdyKbh0xpJjRV6Uumuax2wJ1HPgYBMnaXnLqqWtUElLkCGXYrKolmBqUhgd6lkMf0iRzfgpDdcXmslp4k0NLfLNfs1sfZnnbEzjR4p4OjJultfcNrmbVicnJ9/teaoCmsNvR6cHIzg3DugBW9tQBhPP6DhCf3VcHJ0eFieHxen46KgsirIo/pzsiD+LPdGtkhv8pbxbq541okLJIlxif4nNIXqvZprkqpouzlKVKEma1VTRUhvtKj28cXx71294d2Ucf4lvQy8KYdolYuNkLMp/DVppkOQr0jJ0jKhmV7hjPm9JpFCIF2ehXwSk8VrA5sibzlW00Tfgj5p0+Owa9rFVW5yRXDXVzlN8MdH0ECxO4B6bjgATN5MFkkmo78poVrojmCuu43l4BZ44IBqsvDBFn22qAzIt6WErTfEc4vmCr9W8SW12BOPeqjCZ+sTIko0nyqPnH7rWhr84TCFVgTVexSmz4jzFoFaejevhDj1JCBfYQ4WO17pWaJgRI3KKJlVGyzgI4gxOk2BFbLacgJPvn+B7dTzZaVZ+dkAkZ7aPiK9lRtxk4h2hJPdsQ7jJxLlx7brsErlelwUT5DlhCCqDKLGUZMsoLRa5Id02w7URpNcaMDgYcur56pXSr2nIxVXu/1LxoiuRI+5cGIVKA2FVD6n0pOHAexPGysKRBj0vW1663KpZzVDjPcGU5uQW21aNi0SMrJNct5723xYfVNu1Q2tUHibHxa6KbujL/zAJYh+mhuIvBvjNx1KbEa8ON1h7WfhDPm3diWKifVE2roE6/W81+JiJN0Yz6aGMBFrbqCpu+vkHb7TIxDtm+xNxbaQoxQ9vxyKVoyhFfn+UL/DkK7fePliqmOQVI3f+jZEkyuOiePzmbwAAAP//
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
    /// Lists payments that were created by the [create payment](#payment_create) call and that are in any state. The list shows the payments that are made to the merchant who makes the call. To filter the payments that appear in the response, you can specify one or more optional query and pagination parameters. See [Filtering and pagination](/docs/api/overview/#query-parameters).
    /// </summary>
    public class PaymentListRequest : HttpRequest
    {
        public PaymentListRequest() : base("/v1/payments/payment?", HttpMethod.Get, typeof(PaymentHistory))
        {
            
            this.ContentType =  "application/json";
        }

        public PaymentListRequest Count(int Count)
        {
            var strParams = Convert.ToString(Count);
            try {
                this.Path = $"{this.Path}count={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest PayeeId(string PayeeId)
        {
            var strParams = Convert.ToString(PayeeId);
            try {
                this.Path = $"{this.Path}payee_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartId(string StartId)
        {
            var strParams = Convert.ToString(StartId);
            try {
                this.Path = $"{this.Path}start_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartIndex(int StartIndex)
        {
            var strParams = Convert.ToString(StartIndex);
            try {
                this.Path = $"{this.Path}start_index={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
