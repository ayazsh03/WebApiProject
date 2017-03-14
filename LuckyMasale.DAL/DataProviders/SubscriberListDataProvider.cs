using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface ISubscriberListDataProvider : IBaseDataProvider
    {
    }

    public class SubscriberListDataProvider : BaseDataProvider, ISubscriberListDataProvider
    {
        #region Constructors

        public SubscriberListDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
