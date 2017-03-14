using LuckyMasale.DAL.DataProviders;
using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IDeliveryAddressManager
    {
        Task<List<DeliveryAddress>> GetAllDeliveryAddress();
        Task<DeliveryAddress> GetDeliveryAddressByOrderID(int id);
        Task<List<DeliveryAddress>> GetDeliveryAddressByUserID(int id);
        Task<int> InsertDeliveryAddress(DeliveryAddress deliveryAddress);
        Task<int> UpdateDeliveryAddress(DeliveryAddress deliveryAddress);
    }

    public class DeliveryAddressManager : IDeliveryAddressManager
    {
        private Lazy<IDeliveryAddressDataProvider> deliveryAddressDataProvider;

        #region Constructors

        public DeliveryAddressManager(Lazy<IDeliveryAddressDataProvider> deliveryAddressDataProvider)
        {
            this.deliveryAddressDataProvider = deliveryAddressDataProvider;
        }

        #endregion

        #region Methods

        public async Task<List<DeliveryAddress>> GetAllDeliveryAddress()
        {
            return await deliveryAddressDataProvider.Value.GetAllDeliveryAddress();
        }

        public async Task<DeliveryAddress> GetDeliveryAddressByOrderID(int id)
        {
            return await deliveryAddressDataProvider.Value.GetDeliveryAddressByOrderID(id);
        }

        public async Task<List<DeliveryAddress>> GetDeliveryAddressByUserID(int id)
        {
            return await deliveryAddressDataProvider.Value.GetDeliveryAddressByUserID(id);
        }

        public async Task<int> InsertDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            return await deliveryAddressDataProvider.Value.InsertDeliveryAddress(deliveryAddress);
        }

        public async Task<int> UpdateDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            return await deliveryAddressDataProvider.Value.UpdateDeliveryAddress(deliveryAddress);
        }

        #endregion
    }
}
