using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class RelatedProducts
    {
        public int RelatedId { get; set; }
        public int RelatedProductId { get; set; }
        public int ProductId { get; set; }
        public int? Status { get; set; }
    }
}
