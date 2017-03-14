using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LuckyMasale.BAL.Managers;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class ProductCategoryMapController : ApiController
    {
        #region Properties

        private Lazy<IProductCategoryManager> productCategoryManager;

        #endregion

        #region Constructors

        public ProductCategoryMapController(Lazy<IProductCategoryManager> productCategoryManager)
        {
            this.productCategoryManager = productCategoryManager;
        }

        #endregion        
    }
}