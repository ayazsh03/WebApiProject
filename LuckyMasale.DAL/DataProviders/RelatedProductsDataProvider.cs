using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IRelatedProductsDataProvider : IBaseDataProvider
    { }

    public class RelatedProductsDataProvider : BaseDataProvider, IRelatedProductsDataProvider
    {
        #region Constructors

        public RelatedProductsDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
