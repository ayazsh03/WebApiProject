using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IProductDataProvider : IBaseDataProvider
    { }

    public class ProductDataProvider : BaseDataProvider, IProductDataProvider
    {
        #region Constructors

        public ProductDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
