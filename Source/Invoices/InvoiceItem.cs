// This class was generated on Mon, 08 Jan 2018 16:45:07 CST by version 0.1 of Braintree SDK Generator
// InvoiceItem.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/+xX32/bNhB+319x0DCgNRRZXpYNzluXYEAwtB22oC9F0JzJU3wDRarkyY029H8faMs/OMVos7lBCuTJ0PEofd93dx/pv7PLrqHsNLuwC8eK4EKozvLsDXrGmaFXWMfVLM9+pW77cE5BeW6End3Za9gSsFANbCvna4zrRZZnL7zHbvWhMs9+J9Svremy0wpNoBh437InvQn85l1DXphCdvp2AzGIZ3szBKdRKAHYB1KQl3OCuAAf5mRB5j1S5yGQX0T4HzBA492CNekCNvkrJsABRl3XdaOj0cuXo6OR1iMY/TXKAQNoqtiSBrbw9sIKeUsC5yg0vuSa4JflG66ezUWa0/FYnDOhYJKqcP5mPJfajH2ljo+Pp98GUhHv0Unx4/P/q5xtjfmYf1q+HZkSFZP4UMylfDtJB4Z75oLcAZaDcq2VFOk2OISpXJBYI4SGvCIrseRoAeu4BRZoWipiiYBusW4M5SAOQkOKqw4m5Xc5UCwpXE/K6wJemFheFF6Q6ZLU7TtdBSebXSfXh5uAs9Z7sqob6rL6cqLKJpRq8jMGAjf7k5TE1gY0Biq2aBWjWckBngwKaaiYjA7wbIYGraIcGuzqKKFuKQcSVTz/4tOtes5nTqdTrrZipAyPwZBE7dcZoJym3TmddXDxx2v44fvJT/cqjvj2v83YUtYE/TqSQu8bqG1iY70CzTcsgFUkEx1Lk+IaTYBADXqUWL7EfdaslpWNO7BpvGs8RyNL5DgE76sd5ratZ+SHzPuhS7hvY3ePa57Oaz+ib9Cw7huUA1Te1VBGnSZleRDvufqMQtr4s8ulD+yxx7h62A7bp/P7Fq2wdAm4neAegOuMu+U9mpRludb4nip/kskl3g5pyDK4ZbB6/hd4vP0yF4wne32y10dqr/uYs05oLx+Ho+4puNbH2/35A10qP98nBW8f0CbvexxFdB5l3/FTlOUk9tJ0Wkyn04cqemtZ3rnqXU0YWp/qPFwbkoo58ZLa52y6mVf/4/TyaDj0dX6vty4RN57VHUTW4UfjscOqPVnsV22xVx+/+QcAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Invoice line item information.
    /// </summary>
    [DataContract]
    public class InvoiceItem {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceItem() {}

        /// <summary>
        /// The date when the item or service was provided. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// The item description.
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue = false)]
        public Cost Discount { get; set; }

        /// <summary>
        /// REQUIRED
        /// The item name.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED
        /// The item quantity. Valid value is from -10000 to 10000.
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Tax information.
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue = false)]
        public Tax Tax { get; set; }

        /// <summary>
        /// The unit of measure for the invoiced item.
        /// </summary>
        [DataMember(Name="unit_of_measure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// REQUIRED
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue = false)]
        public Currency UnitPrice { get; set; }
    }
}

