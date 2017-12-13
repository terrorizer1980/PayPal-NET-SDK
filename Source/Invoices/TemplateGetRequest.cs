// This class was generated on Wed, 13 Dec 2017 12:24:30 CST by version 0.1 of Braintree SDK Generator
// TemplateGetRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+xc3XPbRg5/v78Cw87NJD5GlpwmN/abK7tXzzSxr3b7cJ2MDJGguM1yl91d2uZ1+r/fYPmhD1KOWzNqe6OnxPslAAvgB2Ah/RK8x4yCk8BRlkt0NFqQC8LgjGxkRO6EVsFJcJ3qewsxORTSQqINIDQbQpiXcHE2CsLg3wWZ8goNZuTI2ODkxw9h8A1hTGZz9Gttss2xK3Tp2tgvwU2ZM3HWGaEWQRj8gEbgXNIG0TMRd2i+SQkuzkAn4FJqqfXE36ciSsFpsKm+b9hiBk6NwbL6zHEYfEcYXypZBicJSks88HMhDMXBiTMFhcGV0TkZJ8gGJ6qQ8tcP1RqyrjqEB3nI5lpZqsZapm5qkrpsdXi5UHdaREItWj5+E7X1wCq5S9nOtZaEqktFVFinsx5aYhGhIwv3KbmUDLhU2KWAhQWEjEyUonKvIkPoKIbqsCX58F6rVxuDFtAQ2NI6ymBBigxvfS6n/mLCT7MbU4KFdL+HX1awenvL+Qqrp8vBCBWkeEeg1XLLUHe6wem3Qn2EFV7gcv4TRa7LuRTqo+21n29Ob84vr8EvAJeiA1K8cck9Rrx803jePpP0bfau+J8+Qlt6eMXAcmzsFK7JOaEWtkuXXc5sOM56wrsdQvY6/Zf9digiz9DhI44yrqY3JNhs5tkdeBaUUt/PcjROoJzlWGaknmZ4BMK7QgJ/Brua+hiojxnBRQK3nq7bsF2dFdbBnCBHEYNQkBRSVivZk9+GfUdvHGwHVquvhSQ4dQ6jtGZ/U0rtXFevvhXWMbQlQlJtmew7qy0UM7atcDSwrn0lpGQsulCJ7pI9r2Znoprt2qqpP6qVt6FI5IKUA8pQSMA4NmQtoIoBVQna70YJ9dHAR5sMeXQE10Wea+Osd6nLo7SS5Y68UhT1M/u1Ng2PFiwTNS8rFkNPrDaQaUPrXPN16pUIhVgIMJ2eQKTzsglnlHYiYevYFIEsO8cVKiZTaXMkclRuYLFMKxQ/zXTRp8ZbwgjWhBr/0e9kbjHPZen/o1rdZSstdQFCRbKICRAkzkmGftDb9XJm7cDhHNm0MIZUVPbYaMP0OnNfoSXQHm6raFlKSIRCFbFDuUNZsKpKHxklgmRs4cUcJaqIwsbfQFxQCOSi0cvBGNmqwUsG1xl5DZKcIwPNCog0S5qTgUQoin3wf30JXx5N/jlEBP1pa/PS6xBa61CRs/a8h1gshANMXI0aMUUiQ8lmmKNBx3ey5EGolgd/XbwD89zo3AiGxTXmB8kTnsCn1/InmI1fNwg2rVI11bbHlmNho16F92Rp61iqCDmZyPtgw4Zc0+nvbQTsFOkBs1xS6B1cTpFISpiM/x4CKb6w28n4dgSn0pFR6MQdyXJt6fJMncCbdteb273F7y3+L2DxqsjmZLp81maz1bjCdeuqDeoHlCKuNUxYSIzOYMwymYzHg7uFizpku3CUdRkQjrL+RFLW8apfwcQ1mC3UWqAK55wjNYEhZ8uRVg6Fqu95Mh5XZ+wotJN6oWeF6ffDnETA9999y4yhAnrwDksCbwKR4WLoTPRdU0a4WAbAXZqbYkN/UNqeMS+sUBxmr0TTdSaR54SGo8lHkojfagWfdkkYx6IK9PspP23nV0kOwRZRypbRMpTqwgydrT2R6Fk/ap9WKN26mtuNbbcVJgxM82mVAvQSXU/0gFi9qwGzwlLspVvnXk1yJpTPvSvg8pjuSMWMbtrAdSrynFfXh40+P54J18WyqXDlb68I/W6c8qGRKWeMGR1ajlpcrVYNhixPcGJC0aSnhKAIJk1C2dz6C1qMoAKoEKwzRM6HJC93R+pRh9TLpgDA03DUS7MthKMQMHfwRR1E7cgF5KlW3fu+4tFakmws56PJ0Wuo3NauCNPWoexXx/+IvArs2HR/LsQdSjZkYaGwBUpZLss0bNCV0oqm1uRL2C6lrIrnG3TfWBVrULpeXNHiP9JCLok9jaGEgzUNqXP5yeEhqdG9+ChyigWOtFkc8l+HV0sudiQ366pXma0GHFfPSN9fg19qQ1+qYpVcESWv0L5s2Ypl8HBsGwcNFM62FsyXLxI6y1GVS/T8DBX0bWT6StXj5K0Vs4b1QVe13W4QleBDL0n5ikHvAM8ew5IqIahhBCtc9lr5Yjp9GW7kauejydsvR+Clig8iKzK+87mflqQWLmXTnU7/obCJrixM3lQJ1a7CqOazZ21u1OW4pa+Bp14+TzfXcQZhhXWW2WznYrJOVH/Vont/Nn3p7dgWc/5o3lqf8OL6/cs/VoJPMfpEGOueYPF+3S7NXOKT6OJln4OsLXbeD9t7S99b+p/e0h0+bOt4WbYf4EPdlbODS72nuRXuE/ZdL9qZlNo6SEZZTzUBciPu0BHMtf74kcjnq7y0zdKbAwYW4vbaciYU69ysKm3O4p6q577OvK8zP/dlSekeUz3lXI2axoEcy+dj3yYO19p3Q6andlzr5sxVsz2oXG/nBU0FYPONuHkhuuVFM1fmdFu9E0eoOBVt5+PCt8LwNAPBnYgI7shY/Px433x0L5M8AfcprVVeW9aFZdNlfOL/8dKmrwUhKVxhqgNGcFZ3OmboNx2UZVkevDp49+7g1UEcH8DBfw/CDTX98UI5Moqc33x4IzLi3D5D9+FFnZ87raUdCXKJz85Tl8lDk0SvX78+/sKSbwR79Wb0dld1l/aOt3SEmYxdSN1JsV2au4IjX+0gFXXJ/a6Z8f1Xy4L21WUbADnNOfDjbT3PlXNbtO1/+7X19Cyqprsib1b0PFbhwlea1p6C94+1exD984PojS8HdQPwrgXgw1pj2l699+r9140Rt6SXhqwuTES7Sy23t3zjw2d42/s9vRlMifFxV28vxmg8nrBeHB+Pjo+Ph7nAD3243d+P2+L21obcFrdXOwEaTew06Q7n2Pbv0/v36f379P59ev8+vX+f3sSk7ndD/siH6k88rXWJ/ZO9sXUJHPax7cNTvmDp8GEWoYwKn3nMfHg829pR/n/+7a9HpeSbY624oydKpVDCQW6Y+rqv1nJQusM6XH/Xb/UdXulrcXazZrurRxWn2T3vU+V9qvzsTGu4nyHYkWmyY5jpZJYR2sL0Y4N3HjqBek0r1+X3139o8tmfC1ROuDKsWqzDZUl3KBQJplo5UvXPJwSY57L+luPhT9Y3u3/jXP6OXKrj4CT41/lNUP1uRHASHN5NDkXzQwmH7Y8KHP6ycj2/BmFw/pBT5Ci+dugKO+Xo8+RoPP71b/8DAAD//w==
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
     * Shows details for a template, by ID.
     */
    public class TemplateGetRequest : HttpRequest
    {
        public TemplateGetRequest(string TemplateId) : base("/v1/invoicing/templates/{template_id}?", HttpMethod.Get, typeof(Template))
        {
            try {
                this.Path = this.Path.Replace("{template_id}", Uri.EscapeDataString(Convert.ToString(TemplateId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
