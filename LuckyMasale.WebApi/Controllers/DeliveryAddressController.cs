using LuckyMasale.BAL.Managers;
using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class DeliveryAddressController : ApiController
    {
        #region Properties

        private Lazy<IDeliveryAddressManager> deliveryAddressManager;

        #endregion

        #region Constructors

        public DeliveryAddressController(Lazy<IDeliveryAddressManager> deliveryAddressManager)
        {
            this.deliveryAddressManager = deliveryAddressManager;
        }

        #endregion

        #region Methods

        public async Task<List<DeliveryAddress>> GetAllDeliveryAddress()
        {
            return await deliveryAddressManager.Value.GetAllDeliveryAddress();
        }

        public async Task<DeliveryAddress> GetDeliveryAddressByOrderID(int id)
        {
            return await deliveryAddressManager.Value.GetDeliveryAddressByOrderID(id);
        }

        public async Task<List<DeliveryAddress>> GetDeliveryAddressByUserID(int id)
        {
            return await deliveryAddressManager.Value.GetDeliveryAddressByUserID(id);
        }

        public async Task<int> InsertDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            return await deliveryAddressManager.Value.InsertDeliveryAddress(deliveryAddress);
        }

        public async Task<int> UpdateDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            return await deliveryAddressManager.Value.UpdateDeliveryAddress(deliveryAddress);
        }

        #endregion
    }
}