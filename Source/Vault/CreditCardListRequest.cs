// This class was generated on Mon, 11 Dec 2017 15:04:24 CST by version 0.1 of Braintree SDK Generator
// CreditCardListRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/9xXUW/bNhB+3684sC9tYVtOg3aY3rK0XQN0bbYafVgWWLR4tthQPOV4cuIW+e8DKdtz7BTdUM8PezHE84n3fd/x7qgv6p2uUeWqZDRW+qVmM3A2iOqplxhKto1Y8ipXb22QAHPdOkEDnTtE9zCAEcHUOkEGqbAzgvVpwRga8gF7EBos7XQB5BGIoSZGoLS7dnDdIi+g0axrFOQwUD31W7Sdr00qv/iiRosmog3C1s9UT33UbPXE4ZIFejMWW+MO+tcJXkiQHuKwDReEQCoKGL109CYfUevpimURRLOkaAUYLQjaG4jL9NC5T3AaaUplo3SuxQH8TFJ1zwE0Ywx8ceYF2aNs7TMlrrVcPq5EmpBnmRC5MLAo0wHxLKukdhlPy+Pj458eBSwj1f7zwYsnA3hNDHir68ZhD4pnw6Mf+0dH/eHz0dFxfvQ8Px7+UUSFT5j1opN02FO/ozbvvVuofKpdwGi4bi2jWRvOmRpksRhU7lvn7nrfzshtpKbdOMo8tmaPmdEhUGlTcm6sVJ3KU11aZ0ULcb9hmluDBs5eAk3TLhPtr0CXJbVeDq5AG4Rq5AOosIrpFn+LsAoPZy8PxLxGLivt5QCEV6EiORityw1sAA1twI3D0Hp73WI8E1PqSnn98k1FUJEzYd3HBn+2w+FxOXFUXl23JJjW3W8ZhMnPOss7Esw7c7Zp78CsG1sE5EmA0SUGiRXCuV6ca3ePxXKv7cj7zZz1gjPk3dQ1erbbRE/g6Wdk6ifwdo5PwXqDt6vaimMjPj84Iw6Iexzs513wowrBt/UE+WsYYzISh+2jN8GZ9d762erA4XKYWTRQxJCH6qaBWMaTxQ65D8TyL2ppsgBAKxUyFN18W84xYijaxqwNh6RFbFJGv4uZ9aBDid7EbBGDwY2VQR7Ax1VfKHQoi9QD9H2fpEJ8sft3Z4sDabK+Xvznlxkbvn2BQShWl6vif36VmRA51H43JUKi3ZhXW22n5cwbW2rBADcVpuK6lwRGadl3WSu6raxgHYqk0tISm0lYCryfpnnZU29QG+R7N+nLnnpNXG/bzrVU27YYAoN0GOKW0dRx6mxr4U7TGTzVbN52XxBb+j0wUFYzY5+z4mILEEREu2iS+LuQPOgYewsU0OQTlrKN7cV3HrW31l/BBgB4n8LsgnXWX4UHZ9oGyP5yKpVw8eZk9Or9yQdI710+zgyVIdONzWiOPLd4kz2qtCDp0E8uT/ZM7KsDeuPgP0gn/b8xqJPnoW4PGzX4j8Alz/1U6V1PnZIX9MtCU7ppXGwnlnz2KVBsR29Eml9RKjIqV7+8GqmuYFWusvlRliZBtvEdHzm8um2wFDQfREsbTsmgyp8Nh3c//AUAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Vault
{
    /**
     * Lists vaulted credit cards. To filter the cards in the response, specify one or more optional query parameters.
     */
    public class CreditCardListRequest : HttpRequest
    {
        public CreditCardListRequest() : base("/v1/vault/credit-cards?", HttpMethod.Get, typeof(CreditCardList))
        {
            
            this.ContentType =  "application/json";
        }

        public CreditCardListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest ExternalCardId(string ExternalCardId)
        {
            var strParams = Convert.ToString(ExternalCardId);
            try {
                this.Path = $"{this.Path}external_card_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest ExternalCustomerId(string ExternalCustomerId)
        {
            var strParams = Convert.ToString(ExternalCustomerId);
            try {
                this.Path = $"{this.Path}external_customer_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest MerchantId(string MerchantId)
        {
            var strParams = Convert.ToString(MerchantId);
            try {
                this.Path = $"{this.Path}merchant_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        

        public CreditCardListRequest TotalRequired(bool TotalRequired)
        {
            var strParams = Convert.ToString(TotalRequired);
            try {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            } catch (IOException ignored) {}
            return this;
        }
        
        
    }
}
