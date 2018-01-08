// This class was generated on Mon, 08 Jan 2018 16:45:16 CST by version 0.1 of Braintree SDK Generator
// InvoiceRecordRefundRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/7xWTW/jNhC991cMuJfEkK18bLuob2mSxbptEjcxihZBsBmLo4gbiuSSo3jVIP+9oCTbkd2PABvs9WlmNO9xHjmP4hxLEmOhzINVGY08ZdbLoae8MlIk4oRC5pVjZY0YizP09wG4IAiMXAWwOaCBLjmBeQ2TkwQwQFuA5Agmpkn4+eriHDx9rigwzK2sE1Am05UkQHBYl2QYJDEqDXb+iTIGLjBCuTLU/nQZVhIXVgIaCZYL8l1eGIlE/FaRr6fosSQmH8T4+iYRHwgl+U30vfXlJjZFLnrYo5jVLioU2CtzJxLxO3qFc0195T6qKNcvVHfwlnazgmByEhWLVLosYAsl+vueZCIRR95j3f54LxGXhPLC6FqMc9SBIvC5Up6kGLOvKBFTbx15VhTE2FRaP920MRS4LbJicdn8BE4awbbJxIPp0eiAPpVJ07wyd13Pz/V/cecd8Lz1tdjHlfdksnq7QyxtZbjX4wrqd/kTBlqOUm49oNaQK4MmU6jhAXVF4Ekjk4RckZYBduao0cRJXk1kRQkQZ6PdV+P2b4OUdZyPraQev2wtRp/hIWhiJg/LCMhs9FPoXCMbQ15dwNuD/XevMVbJ/5JoZO11v0T6rbdnBpWLDjgHqe4UA+aRTLSHpEyVqAMEcuiR4/GtWSmzYtWcbMxA57x1XiFTX45XsdMLmEvkPvEO2L4F4gdYFGR6N8Gid2uu4nLrS2RQAQZ1XdeD4eDsbDAcSDmAwV+DZEOW64lh8oYYTpApnamS4H1T4WanYHbjNGVrdRgp4nxk/V1acKlTn2eHh4c/vgmUxT6H349+2B3FRKAvWDpNCdwe7O2/He4dDA/ewfRqdvu1Xn/hPBm7oWoH9FU9gggDhmAz1Rh6obho5G0l/UbdskcTsNFw8z3Y+vRfr8MU6ynq5e36LHUEyzbXDG+nR39Oj369XYXXjr4V3/i5x7IFtrltMIotwsRIlSFTiGZo3vH1gTV2cKgkcOFtdVcsKzQzGWccta7jyKvVY5Rru2idc92uMV2tm51U2iyk6FS6ik7fdMYLH3s7z+5yuwiVc9Zzu3ncnv4xO70831S5+dk/6R/92hWIr4v1MMfsfoFeQmZLh6zmSiuuX+Wcbp5iVHDWBGrrRDgRx9YwmW4DEOicjnIra9JPwRqRiA/M7qxhK8ZienE1E+0CJMYifdh/ptVSqvRxve08pZu74ukXRxmTvGp2w+YZGx/s7T199zcAAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Invoices
{
    /// <summary>
    /// Marks the status of an invoice, by ID, as refunded. In the JSON request body, include a payment detail object that defines the payment method and other details.
    /// </summary>
    public class InvoiceRecordRefundRequest : HttpRequest
    {
        public InvoiceRecordRefundRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/record-refund?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public InvoiceRecordRefundRequest RequestBody(RefundDetail Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}
