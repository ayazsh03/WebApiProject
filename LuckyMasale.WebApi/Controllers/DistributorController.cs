using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class DistributorController : ApiController
    {
        #region Properties

        private Lazy<IDistributorManager> distributorManager;
        
        #endregion

        #region Constructors

        public DistributorController(Lazy<IDistributorManager> distributorManager)
        {
            this.distributorManager = distributorManager;
        }

        #endregion
    }
}