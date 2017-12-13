// This class was generated on Wed, 13 Dec 2017 12:24:18 CST by version 0.1 of Braintree SDK Generator
// Tax.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6yTQW/VMAzH73wKKyeQqqoDJNR3A3bZZUMw7YI4uImzGaVJcBy0CvHdUfbYm0Yn8RA9VXLT5vfz3/5hLpdMZmcu8dZ05gqFcQp0jnMrms6cUrHCWTnF/Sng6JPM2Cq96cxbEVz2Pxk685HQXcSwmJ3HUKgVvlUWcofCB0mZRJmK2X0+XP++ilC0y5oB51SjrkjeYSFI01eyCj4JYAjgOWK0jAG+Y6gEQgGVHHim4Ao8nzBgtNRBxmWmqOAqdUBq+xebiRQVjtdrDfsg+FjkFQRSJYH7E2CTI8ACjjxHcjAtcPbpAl6/PHnzTw1XqX9gxhrCz+6vrHfdW4Hug4CaQROcg+NrVkDf0PWGwJHlGUOBQhkFtWXy4MDx4HAXV/sCc5aUhVHpsfwWll+O8GS3HvCbNjYlVbEEZ6f/O+BHNjy2x1MoirfQXm6be6zzRLLGyCSWnti1exJBpR6uMLD7vWFcwEuaYeiH4aTNxTj24zhuE+CzXwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /**
    * Tax information.
    */
    [DataContract]
    public class Tax {

        // Required default constructor
        public Tax() {}

        /**
        * Base object for all financial value related fields (balance, payment due, etc.)
        */
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /**
        * The resource ID.
        */
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /**
        * REQUIRED
        * The tax name.
        */
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /**
        * REQUIRED
        * The tax rate. Valid value is from 0.001 to 99.999.
        */
        [DataMember(Name="percent", EmitDefaultValue = false)]
        public double Percent { get; set; }
    }
}

