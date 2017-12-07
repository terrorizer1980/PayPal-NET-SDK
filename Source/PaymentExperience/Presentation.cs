// This class was generated on Thu, 07 Dec 2017 14:41:28 PST by version 0.1 of Braintree SDK Generator
// Presentation.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/8xU34/jNBB+568Y5QWQutEdEiD61rse7HKnbtV24QGhZOpMYx+ObWacdrNo/3dkJy27sBIPSOhePjnz8/s84/xR7IZAxbxYMwm5iNF4V8yKn5AN7i2tsEveYlYsSRSbkP3zYqcJJA6WAF0D4UkyBGTsKBJLWcyKBTMOY49Xs2JD2Nw6OxTzA1qhZPi9N0zNxbBmH4ijISnmv1zYSWTj2n/y2jO6pnLp4+8MF2BxTxaixgj+SMymIYGoCfa9GEcikBLBuGxc47BGC6iU710E/8wasCUp4a1GRhWJwZJro87irenMKF3m8Pqrb0GMay1d7YdIgDZodH1HbBSoc/p/vhnXW/s4+9frsV6hpUr5hl6c4OgHfxgFjnf1TPbQkYtA94HYkFMEjZFgcZASFnBEa5qEPYERqBd39QzqxS7hm3cZNwnfLjJeZ1wlXGbvu23CH94k/D5H3uTc1YeE6xGzZZMqe4b6blunzl9fXe4SkrrUHq34idLBM1h0bZ9VjQMWgjxZNiRzqBuslu9TaU3VTe5kmupmmQ4fsfpxnQ7OV6vbdAixGpVwX2UqtRyrbdYQdbXLwh50NWp70NX1+4nug652P9f/27RbX5kO25cew93mA0Sfh5viIMf9NcSOGoMQhzBOsmzNIWkpP4Z2klIG19YlpLXJuZ8LdHhvur6Dk2miTnmvv3sFwdyTlfwyzn5NptUxBXxz9pfnFVPsg4wVp/1DJrDILfElKFhUJDD4np+wh2lZow9phdNRIUdgOho6pTp4qcCkfNeRa6Ymg+9BomfKaWM57wBBSPVM8MX1brfefglCfExEbqMmPhmhGZxoD3v2JyGW83MAhI5EUpVcXmlSv/k+Tu9KeRfROHDeXU0NTKTuk/uj/Pr42Z8AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PaymentExperience
{
    /**
    * The style and presentation parameters.
    */
    [DataContract]
    public class Presentation {

        // Required default constructor
        public Presentation() {}

        /**
        * A label that overrides the business name in the PayPal account on the PayPal pages. Character length and limitations: 127 single-byte alphanumeric characters.
        */
        [DataMember(Name="brand_name")]
        public string BrandName { get; set; }

        /**
        * The locale of pages that the PayPal payment experience displays. A valid value is `AU`, `AT`, `BE`, `BR`, `CA`, `CH`, `CN`, `DE`, `ES`, `GB`, `FR`, `IT`, `NL`, `PL`, `PT`, `RU`, or `US`. A 5-character code is also valid for languages in these countries: `da_DK`, `he_IL`, `id_ID`, `ja_JP`, `no_NO`, `pt_BR`, `ru_RU`, `sv_SE`, `th_TH`, `zh_CN`, `zh_HK`, or `zh_TW`.
        */
        [DataMember(Name="locale_code")]
        public string LocaleCode { get; set; }

        /**
        * A URL to the logo image. A valid media type is `.gif`, `.jpg`, or `.png`. The image's maximum width is 190 pixels and maximum height is 60 pixels. PayPal crops images that are larger. PayPal places your logo image at the top of the cart review area. PayPal recommends that you store the image on a secure (HTTPS) server. Otherwise, web browsers display a message that checkout pages contain non-secure items. Character length and limitations: 127 single-byte alphanumeric characters.
        */
        [DataMember(Name="logo_image")]
        public string LogoImage { get; set; }
    }
}

