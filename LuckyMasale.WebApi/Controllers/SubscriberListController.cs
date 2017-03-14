using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{    
    public class SubscriberListController : ApiController
    {
        #region Properties

        private Lazy<ISubscriberListManager> subscriberListManager;

        #endregion

        #region Constructors

        public SubscriberListController(Lazy<ISubscriberListManager> subscriberListManager)
        {
            this.subscriberListManager = subscriberListManager;
        }

        #endregion
    }
}