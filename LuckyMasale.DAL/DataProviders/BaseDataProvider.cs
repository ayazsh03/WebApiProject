using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IBaseDataProvider
    { }

    public class BaseDataProvider : IBaseDataProvider
    {
        #region Properties

        public IDataSourceFactory DataSourceFactory { get; private set; }

        #endregion

        #region Constructors

        public BaseDataProvider(IDataSourceFactory dataSourceFactory)
        {
            this.DataSourceFactory = dataSourceFactory;
        }

        #endregion
    }
}
