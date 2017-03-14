using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface ICategoryDataProvider : IBaseDataProvider
    { }

    public class CategoryDataProvider : BaseDataProvider, ICategoryDataProvider
    {
        #region Constructors

        public CategoryDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
