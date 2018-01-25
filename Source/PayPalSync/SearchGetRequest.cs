// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// SearchGetRequest.cs
// @version 0.1.0-dev+27d306
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// Shows details for a transaction, by transaction date or transaction ID. To filter the transaction that appears in the response, specify one or more optional query parameters.<blockquote><strong>Note:</strong> If you specify query parameters, the `ending_balance` field does not contain a value.</blockquote><br/>To limit, or <em>page</em>, the data that appears in the response, use these query parameters:<table><thead><tr><th>Parameter</th><th>Type</th><th>Description</th></tr></thead><tbody><tr><td><code>page</code></td><td>integer</td><td>The zero-relative start index of the entire list of items that are returned in the response. So, the combination of <code>page=1</code> and <code>page_size=20</code> returns the first 20 items.</td></tr><tr><td><code>page_size</code></td><td>integer</td><td>The number of items to return in the response.</td></tr></tbody></table>
    /// </summary>
    public class SearchGetRequest : HttpRequest
    {
        public SearchGetRequest() : base("/v1/reporting/transactions?", HttpMethod.Get, typeof(SearchResponse))
        {
            
            this.ContentType =  "application/json";
        }

        public SearchGetRequest BalanceAffectingRecordsOnly(string BalanceAffectingRecordsOnly)
        {
            var strParams = Convert.ToString(BalanceAffectingRecordsOnly);
            try {
                this.Path = $"{this.Path}balance_affecting_records_only={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest EndDate(string EndDate)
        {
            var strParams = Convert.ToString(EndDate);
            try {
                this.Path = $"{this.Path}end_date={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest Fields(string Fields)
        {
            var strParams = Convert.ToString(Fields);
            try {
                this.Path = $"{this.Path}fields={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest PaymentInstrumentType(string PaymentInstrumentType)
        {
            var strParams = Convert.ToString(PaymentInstrumentType);
            try {
                this.Path = $"{this.Path}payment_instrument_type={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest StartDate(string StartDate)
        {
            var strParams = Convert.ToString(StartDate);
            try {
                this.Path = $"{this.Path}start_date={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest StoreId(string StoreId)
        {
            var strParams = Convert.ToString(StoreId);
            try {
                this.Path = $"{this.Path}store_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest TerminalId(string TerminalId)
        {
            var strParams = Convert.ToString(TerminalId);
            try {
                this.Path = $"{this.Path}terminal_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest TransactionAmount(string TransactionAmount)
        {
            var strParams = Convert.ToString(TransactionAmount);
            try {
                this.Path = $"{this.Path}transaction_amount={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest TransactionCurrency(string TransactionCurrency)
        {
            var strParams = Convert.ToString(TransactionCurrency);
            try {
                this.Path = $"{this.Path}transaction_currency={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest TransactionId(string TransactionId)
        {
            var strParams = Convert.ToString(TransactionId);
            try {
                this.Path = $"{this.Path}transaction_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest TransactionStatus(string TransactionStatus)
        {
            var strParams = Convert.ToString(TransactionStatus);
            try {
                this.Path = $"{this.Path}transaction_status={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public SearchGetRequest TransactionType(string TransactionType)
        {
            var strParams = Convert.ToString(TransactionType);
            try {
                this.Path = $"{this.Path}transaction_type={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
