using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IContactUsDataProvider : IBaseDataProvider
    { }

    public class ContactUsDataProvider:BaseDataProvider,IContactUsDataProvider
    {
        #region Constructors

        public ContactUsDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion
    }
}
