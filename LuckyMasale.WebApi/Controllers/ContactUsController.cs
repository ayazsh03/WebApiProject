using LuckyMasale.BAL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class ContactUsController : ApiController
    {
        #region Properties

        Lazy<IContactUsManager> contactUsManager;

        #endregion

        #region Constructors

        public ContactUsController(Lazy<IContactUsManager> contactUsManager)
        {
            this.contactUsManager = contactUsManager;
        }

        #endregion
    }
}