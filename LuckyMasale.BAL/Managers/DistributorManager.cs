using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IDistributorManager
    { }

    public class DistributorManager:IDistributorManager
    {
        private Lazy<IDistributorDataProvider> distributorDataProvider;

        #region Constructors

        public DistributorManager(Lazy<IDistributorDataProvider> distributorDataProvider)
        {
            this.distributorDataProvider = distributorDataProvider;
        }

        #endregion
    }
}
