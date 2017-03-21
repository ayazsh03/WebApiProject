using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class PaymentInformation
    {
        public string invoice_number { get; set; }
        public string Currency { get; set; }
        public string Total { get; set; }
        public string Tax { get; set; }
        public string Shipping { get; set; }
        public string SubTotal { get; set; }
        public string Description { get; set; }
        public string SCity { get; set; }
        public string SCountryCode { get; set; }
        public string SAddress { get; set; }
        public string SPostal { get; set; }
        public string SState { get; set; }
        public string SReceiverName { get; set; }
        public string BCity { get; set; }
        public string BCountry { get; set; }
        public string BAddress { get; set; }
        public string BPostal { get; set; }
        public string BState { get; set; }
        public string BReceiverName { get; set; }
        public string CVV2 { get; set; }
        public int expire_month { get; set; }
        public int expire_year { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string number { get; set; }
        public string type { get; set; }
        public string EmailID { get; set; }
        
        public PaymentInformation()
        {
            this.Currency = "USD";
            this.Description = "This is the payment transaction description.";
        }
    }
}
