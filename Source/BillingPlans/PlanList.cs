// This class was generated on Mon, 11 Dec 2017 16:50:54 CST by version 0.1 of Braintree SDK Generator
// PlanList.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTwW7TQBCG7zzFaLmA5CacOORmARKHilQQcamqZmJP4qHr2e3MOpVBfXe02yYqMqBW7XVnvP6+nX9+udUYyS3cmUeBU7bkKvcdlXHj6Qv2ueQq95GsUY6Jg7iFq8GzJQhbiB7FZvAhSEIWg5YSsjfYBgXCpisNgNICglH55Pxzvfq0rL+BZ7myizfzNjQ2x8jzsCfdM93MX3eYKKCdlJa3M1e5WhXHO9R3lftK2C7Fj26xRW+UD64HVmqPB2caImliMrc4P0qeslzBAxdYbn5Q8xfl8uOptwBmjqyhdD2QpRMlj4na52u9f6qWDN7fVn8McCpSBvRfkbsRviyLJWXZTWlSSOgvOVE/ZVp1BKUOMvQb0iMbsEDqqGTuuVF4EmfEHT2SM3ceOJUsBjGaQW5d59ql8U9aHzIDe/QD5V0h7VnIoAs30KOM98IYI6FCkPsdwt3hsgcPuC5r9c/rDVAJBqMWUoAGfTPkoBbCx+G/xFNf3L76DQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingPlans
{
    /**
    * A list of plans. Contains details for each plan and a set of [HATEOAS links](/docs/api/overview/#hateoas-links).
    */
    [DataContract]
    public class PlanList {

        // Required default constructor
        public PlanList() {}

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * An array of plans.
        */
        [DataMember(Name="plans")]
        public List<Plan> Plans { get; set; }

        /**
        * The total number of plans in the list.
        */
        [DataMember(Name="total_items")]
        public string TotalItems { get; set; }

        /**
        * The total number of pages in the response. The `page_size` request value determines how many plans appear on each page. The `total_items` and `page_size` request values are used to calculate the total number of pages in the response.
        */
        [DataMember(Name="total_pages")]
        public string TotalPages { get; set; }
    }
}

