using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IProductCategoryManager
    { }

    public class ProductCategoryMapManager : IProductCategoryManager
    {
        private Lazy<IProductCategoryManager> productCategoryDataProvider;

        #region Constructors

        public ProductCategoryMapManager(Lazy<IProductCategoryManager> productCategoryDataProvider)
        {
            this.productCategoryDataProvider = productCategoryDataProvider;
        }

        #endregion
    }
}
