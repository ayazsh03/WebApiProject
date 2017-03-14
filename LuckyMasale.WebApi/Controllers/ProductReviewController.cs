using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LuckyMasale.WebApi.Controllers
{
    public class ProductReviewController : ApiController
    {
        #region Properties

        private Lazy<IProductReviewManager> productReviewManager;

        #endregion

        #region Constructors

        public ProductReviewController(Lazy<IProductReviewManager> productReviewManager)
        {
            this.productReviewManager = productReviewManager;
        }

        #endregion        
    }
}