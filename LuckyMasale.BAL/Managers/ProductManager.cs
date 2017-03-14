using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IProductManager
    { }

    public class ProductManager : IProductManager
    {
        private Lazy<IProductDataProvider> productDataProvider;

        #region Constructors

        public ProductManager(Lazy<IProductDataProvider> productDataProvider)
        {
            this.productDataProvider = productDataProvider;
        }

        #endregion
    }
}
