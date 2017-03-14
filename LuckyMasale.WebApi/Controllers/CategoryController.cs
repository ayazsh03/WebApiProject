using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        #region Properties

        private Lazy<ICategoryManager> categoryManager;

        #endregion

        #region Constructors

        public CategoryController(Lazy<ICategoryManager> categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        #endregion
    }
}