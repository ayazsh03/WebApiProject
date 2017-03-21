using LuckyMasale.BAL.Managers;
using LuckyMasale.Shared.DTO;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class PayPalController : ApiController
    {
        #region Properties

        private Lazy<IPayPalManager> payPalManager;

        #endregion

        #region Constructors

        public PayPalController(Lazy<IPayPalManager> payPalManager)
        {
            this.payPalManager = payPalManager;
        }

        #endregion

        #region Methods

        [HttpPost]
        public async Task<Payment> MakePayment(PaymentInformation paymentInformation)       
        {
            return await payPalManager.Value.RunSample(paymentInformation);
        }

        #endregion
    }
}