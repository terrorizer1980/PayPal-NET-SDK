// This class was generated on Wed, 13 Dec 2017 14:31:23 CST by version 0.1 of Braintree SDK Generator
// FlowConfig.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xUwW7bSAy971cQOmudAHszsIfdZDctECRG6qaHtpDpEWUNPOKoHE5doci/F2PZjpU4CZK2uUnDRw753ht+z6ZdS9k4+9/5FZx4ruwiy7NrFItzRxfYpGCWZ6cUjNhWredsnE1rgiplmHVGFEwBaFGwISUJoyzP/hHBri9/nGdXhOUluy4bV+gCpYMv0QqVu4OJ+JZELYVs/HHXWFCxfKCnOfKy0G9ctMSl5UURxR3ssyExNbJCsErw/uoc1ENpQ+uwA6yUBBBSNVBBDhUJtNg1xDqCtwxnJA1yl8NXdLYEz66DygtoTXBmxbfYbfHQkNa+BC+H623iP8sNR+du8icJctjz0uKCCk3YQ+ykAPgKNmhI6H2CPK8nnWA3QddTmKaPgQRMTWbpo45g6tPJGsme/9yg0RgfWQe1cwik6YLZv9Y5y4vZIPtupl9YfiD/PMVmr0SmkEbhIootatW26JU8yOib6XSydYJuJvMgVFoho+spTQzqG5IUQOhrJ2eO4BpdJLABZmf/TWfJSbPJ5bvpa42ZZC3QrKe5O9tEKBBrALJaU/8APsXj479MUPG8WH/TiWe1HKmPHO2H0jT3EybYwYVfHcJv/dWvGvUD7kZ9xlyOevSd31OqMDpNVD6ryfy2S+PLHkF7tPxthrm3oBF8qImh8xFKD+wVlpzaTqvSMrrdFsAmeTtPJqc2GcIGKDftpklzWNXW1DvLhHue2Xsp26Lrd7uyWr9Al3lU9bzpf3CXcdYsn83gsAQypP276B/4kIQnRLxl9Akq0054XLSmsXpPssSlqb3fLJ9nmfO3KfXInS8Q6uFq+UAPG6AVbygEKsE2DZUWlVz3SxbP55s/fgAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PaymentExperience
{
    /// <summary>
    /// The flow configuration parameters.
    /// </summary>
    [DataContract]
    public class FlowConfig {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FlowConfig() {}

        /// <summary>
        /// The merchant site URL to display after a bank transfer payment. In Germany, valid only for the Giropay payment method or bank transfer payment method.
        /// </summary>
        [DataMember(Name="bank_txn_pending_url", EmitDefaultValue = false)]
        public string BankTxnPendingUrl { get; set; }

        /// <summary>
        /// The type of landing page to display on the PayPal site for user checkout. To use the non-PayPal account landing page, set to `Billing`. To use the PayPal account login landing page, set to `Login`.
        /// </summary>
        [DataMember(Name="landing_page_type", EmitDefaultValue = false)]
        public string LandingPageType { get; set; }

        /// <summary>
        /// The HTTP method to use to redirect the customer to a return URL. Value is `GET` or `POST`.
        /// </summary>
        [DataMember(Name="return_uri_http_method", EmitDefaultValue = false)]
        public string ReturnUriHttpMethod { get; set; }

        /// <summary>
        /// Presents either the <strong>Continue</strong> or <strong>Pay Now</strong> checkout flow to the customer.<br/><br/>Default is <strong>Continue</strong>, or <code>user_action=continue</code>. When you do not know the final payment amount, accept this default flow, which redirects the customer to the PayPal payment page with the <strong>Continue</strong> button. When the customer clicks <strong>Continue</strong>, the customer can change the payment amount.<br/><br/> When you know the final payment amount, set <code>user_action=commit</code> to choose the <strong>Pay Now</strong> flow, which redirects the customer to the PayPal payment page with the <strong>Pay Now</strong> button. When the customer clicks <strong>Pay Now</strong>, the payment is processed immediately.
        /// </summary>
        [DataMember(Name="user_action", EmitDefaultValue = false)]
        public string UserAction { get; set; }
    }
}

