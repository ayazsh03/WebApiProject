using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public bool? Availability { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Weight { get; set; }
        public bool? DisplayOnHome { get; set; }
        public string MainImage { get; set; }
        public string Image2 { get; set; }
        public int? Status { get; set; }
        public bool? OnSale { get; set; }
        public float? SalePrice { get; set; }
        public string ProductRecipeFile { get; set; }
        public string Ingredients { get; set; }
        public float? Price { get; set; }
        public float? INRPrice { get; set; }
        public string BarCode { get; set; }
    }
}
