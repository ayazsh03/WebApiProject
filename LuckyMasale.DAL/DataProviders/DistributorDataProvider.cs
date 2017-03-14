using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IDistributorDataProvider : IBaseDataProvider
    { }

    public class DistributorDataProvider : BaseDataProvider, IDistributorDataProvider
    {
        #region Constructors

        public DistributorDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
