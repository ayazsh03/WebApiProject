using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class OrderProduct
    {
        public int OrderProductID { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public float? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
