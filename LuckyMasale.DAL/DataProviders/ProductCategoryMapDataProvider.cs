using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IProductCategoryMapDataProvider : IBaseDataProvider
    { }

    public class ProductCategoryMapDataProvider : BaseDataProvider, IProductCategoryMapDataProvider
    {
        #region Constructors

        public ProductCategoryMapDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
