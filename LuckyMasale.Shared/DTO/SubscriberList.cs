using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class SubscriberList
    {
        public int SubscriberID { get; set; }
        public string SubscriberName { get; set; }
        public string SubscriberEmail { get; set; }
        public string IPAddress { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
