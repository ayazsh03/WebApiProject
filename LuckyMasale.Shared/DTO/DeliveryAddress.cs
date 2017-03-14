using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class DeliveryAddress
    {
        public int DeliveryAddessID { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set;}
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
    }
}
