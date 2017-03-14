using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class ProductReview
    {
        public int ProductReviewID { get; set; }
        public int ProductIDP { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
    }
}
