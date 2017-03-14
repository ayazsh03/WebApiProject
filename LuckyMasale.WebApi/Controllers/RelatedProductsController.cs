using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class RelatedProductsController : ApiController
    {
        #region Properties

        private Lazy<IRelatedProductsManager> relatedProductsManager;

        #endregion

        #region Constructors

        public RelatedProductsController(Lazy<IRelatedProductsManager> relatedProductsManager)
        {
            this.relatedProductsManager = relatedProductsManager;
        }

        #endregion       
    }
}