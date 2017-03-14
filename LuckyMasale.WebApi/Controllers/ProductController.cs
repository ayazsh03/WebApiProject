using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        #region Properties

        private Lazy<IProductManager> productManager;

        #endregion

        #region Constructors

        public ProductController(Lazy<IProductManager> productManager)
        {
            this.productManager = productManager;
        }

        #endregion
    }
}