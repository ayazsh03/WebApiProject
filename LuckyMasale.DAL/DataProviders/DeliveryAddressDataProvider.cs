using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IDeliveryAddressDataProvider : IBaseDataProvider
    {
        Task<List<DeliveryAddress>> GetAllDeliveryAddress();
        Task<DeliveryAddress> GetDeliveryAddressByOrderID(int id);
        Task<List<DeliveryAddress>> GetDeliveryAddressByUserID(int id);
        Task<int> InsertDeliveryAddress(DeliveryAddress deliveryAddress);
        Task<int> UpdateDeliveryAddress(DeliveryAddress deliveryAddress);
    }

    public class DeliveryAddressDataProvider : BaseDataProvider, IDeliveryAddressDataProvider
    {
        #region Constructors

        public DeliveryAddressDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion

        #region Methods

        public async Task<List<DeliveryAddress>> GetAllDeliveryAddress()
        {
            List<DeliveryAddress> deliveryAddresses = new List<DeliveryAddress>();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    deliveryAddresses = await ds.GetResults<DeliveryAddress>("usp_GetAllDeliveryAddress", null);
                }

                return deliveryAddresses;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<DeliveryAddress> GetDeliveryAddressByOrderID(int id)
        {
            DeliveryAddress deliveryAddress = new DeliveryAddress();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    deliveryAddress = await ds.GetResult<DeliveryAddress>("usp_GetDeliveryAddressByOrderID", ds.CreateParameter("OrderID", id));

                    return deliveryAddress;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<DeliveryAddress>> GetDeliveryAddressByUserID(int id)
        {
            List<DeliveryAddress> deliveryAddresses = new List<DeliveryAddress>();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    deliveryAddresses = await ds.GetResults<DeliveryAddress>("usp_GetDeliveryAddressByUserID", ds.CreateParameter("UserID", id));
                }

                return deliveryAddresses;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> InsertDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_InsertDeliveryAddress",
                        ds.CreateParameter("UserID", deliveryAddress.UserID),
                        ds.CreateParameter("OrderID", deliveryAddress.OrderID),
                        ds.CreateParameter("Name", deliveryAddress.Name),
                        ds.CreateParameter("Pincode", deliveryAddress.Pincode),
                        ds.CreateParameter("Address", deliveryAddress.Address),
                        ds.CreateParameter("Landmark", deliveryAddress.Landmark),
                        ds.CreateParameter("country", deliveryAddress.country),
                        ds.CreateParameter("state", deliveryAddress.state),
                        ds.CreateParameter("city", deliveryAddress.city),
                        ds.CreateParameter("phone", deliveryAddress.phone));
                }

                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<int> UpdateDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_UpdateDeliveryAddress",
                        ds.CreateParameter("DeliveryAddressID", deliveryAddress.DeliveryAddessID),
                        ds.CreateParameter("UserID", deliveryAddress.UserID),
                        ds.CreateParameter("OrderID", deliveryAddress.OrderID),
                        ds.CreateParameter("Name", deliveryAddress.Name),
                        ds.CreateParameter("Pincode", deliveryAddress.Pincode),
                        ds.CreateParameter("Address", deliveryAddress.Address),
                        ds.CreateParameter("Landmark", deliveryAddress.Landmark),
                        ds.CreateParameter("country", deliveryAddress.country),
                        ds.CreateParameter("state", deliveryAddress.state),
                        ds.CreateParameter("city", deliveryAddress.city),
                        ds.CreateParameter("phone", deliveryAddress.phone));
                }

                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        #endregion
    }
}
