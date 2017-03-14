using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IProductReviewDataProvider : IBaseDataProvider
    { }

    public class ProductReviewDataProvider : BaseDataProvider, IProductReviewDataProvider
    {
        #region Constructors

        public ProductReviewDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion

        #region Events



        #endregion
    }
}
