using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class Distributor
    {
        public int DistributorId { get; set; }
        public string DistributorName { get; set; }
        public string ConatctPersonName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Hours { get; set; }
        public string Description { get; set; }
    }
}
