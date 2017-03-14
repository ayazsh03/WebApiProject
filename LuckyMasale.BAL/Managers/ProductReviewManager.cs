using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IProductReviewManager
    { }

    public class ProductReviewManager:IProductReviewManager
    {
        private Lazy<IProductReviewDataProvider> productReviewDataProvider;

        #region Constructors

        public ProductReviewManager(Lazy<IProductReviewDataProvider> productReviewDataProvider)
        {
            this.productReviewDataProvider = productReviewDataProvider;
        }

        #endregion
    }
}
