using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class OrderProductController : ApiController
    {
        #region Properties

        private Lazy<IOrderProductManager> orderProductManager;

        #endregion

        #region Constructors

        public OrderProductController(Lazy<IOrderProductManager> orderProductManager)
        {
            this.orderProductManager = orderProductManager;
        }

        #endregion
    }
}