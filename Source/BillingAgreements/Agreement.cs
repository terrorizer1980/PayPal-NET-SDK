// This class was generated on Mon, 11 Dec 2017 17:19:28 CST by version 0.1 of Braintree SDK Generator
// Agreement.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.BillingAgreements
{
    /**
    * A billing agreement.
    */
    [DataContract]
    public class Agreement {

        // Required default constructor
        public Agreement() {}

        /**
        * The agreement details.
        */
        [DataMember(Name="agreement_details")]
        public AgreementDetails AgreementDetails { get; set; }

        /**
        * REQUIRED
        * The agreement description.
        */
        [DataMember(Name="description")]
        public string Description { get; set; }

        /**
        * The PayPal-generated agreement ID.
        */
        [DataMember(Name="id")]
        public string Id { get; set; }

        /**
        * An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        */
        [DataMember(Name="links")]
        public List<LinkDescriptionObject> Links { get; set; }

        /**
        * REQUIRED
        * The agreement name.
        */
        [DataMember(Name="name")]
        public string Name { get; set; }

        /**
        * An array of charge models to override the charge models in the plan. A charge model defines shipping fee and tax information. If you omit this parameter, the agreement uses the default shipping fee and tax information from the plan.
        */
        [DataMember(Name="override_charge_models")]
        public List<OverrideChargeModel> OverrideChargeModels { get; set; }

        /**
        * The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
        */
        [DataMember(Name="override_merchant_preferences")]
        public MerchantPreferences OverrideMerchantPreferences { get; set; }

        /**
        * REQUIRED
        * The customer who funds the payment.
        */
        [DataMember(Name="payer")]
        public Payer Payer { get; set; }

        /**
        * REQUIRED
        * The plan to use to create an agreement.
        */
        [DataMember(Name="plan")]
        public Plan Plan { get; set; }

        /**
        * A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        */
        [DataMember(Name="shipping_address")]
        public SimplePostalAddress ShippingAddress { get; set; }

        /**
        * REQUIRED
        * The date and time when this agreement begins, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The start date must be more recent than the current date. The agreement can take up to 24 hours to activate.<br/><br/>The start date and time in the create agreement request might not match the start date and time that the API returns in the execute agreement response. When you execute an agreement, the API internally converts the start date and time to the start of the day in the time zone of the merchant account. For example, the API converts a `2017-01-02T14:36:21Z` start date and time for an account in the Berlin time zone (UTC + 1) to `2017-01-02T00:00:00`. When the API returns this date and time in the execute agreement response, it shows the converted date and time in the UTC time zone. So, the internal `2017-01-02T00:00:00` start date and time becomes `2017-01-01T23:00:00` externally.
        */
        [DataMember(Name="start_date")]
        public string StartDate { get; set; }

        /**
        * The state of the agreement. Value is:<ul><li>`Pending`. The agreement is awaiting initial payment completion.</li><li>`Active`. The agreement is active and payments will be scheduled.</li><li>`Suspended`. The agreement is suspended and payments will not be scheduled until the agreement is reactivated.</li><li>`Canceled`. The agreement is canceled and payments will not be scheduled.</li><li>`Expired`. The agreement is expired and no more payments remain to be scheduled.</li></ul>
        */
        [DataMember(Name="state")]
        public string State { get; set; }
    }
}

