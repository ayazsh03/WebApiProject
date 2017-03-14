using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IOrderDataProvider : IBaseDataProvider
    {
        Task<int> DeleteOrder(int id);
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderByID(int id);
        Task<int> InsertOrder(Order order);
        Task<int> UpdateOrder(Order order);
        Task<List<Order>> GetOrderByUserID(int id);
    }

    public class OrderDataProvider : BaseDataProvider, IOrderDataProvider
    {
        #region Constructors

        public OrderDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion

        #region Methods

        public async Task<List<Order>> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    orderList = await ds.GetResults<Order>("usp_GetAllOrders");
                }
            }
            catch (Exception)
            {
                return null;
            }

            return orderList;
        }

        public async Task<Order> GetOrderByID(int id)
        {
            Order order = new Order();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    order = await ds.GetResult<Order>("usp_GetOrderByID", ds.CreateParameter("OrderID", id));
                }
            }
            catch (Exception)
            {
                return null;
            }

            return order;
        }

        public async Task<int> InsertOrder(Order order)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_InsertOrder", 
                        ds.CreateParameter("UserID", order.UserID),
                        ds.CreateParameter("PaymentStatusID", order.PaymentStatusID),
                        ds.CreateParameter("TransactionID", order.TransactionID),
                        ds.CreateParameter("TrackingNumber", order.TrackingNumber),
                        ds.CreateParameter("SubTotal", order.SubTotal),
                        ds.CreateParameter("OrderTotal", order.OrderTotal),
                        ds.CreateParameter("Tax", order.Tax),
                        ds.CreateParameter("ShippingCharges", order.ShippingCharges),
                        ds.CreateParameter("OrderDate", order.OrderDate),
                        ds.CreateParameter("DeliveryDate", order.DeliveryDate),
                        ds.CreateParameter("SpecialInstruction", order.SpecialInstruction));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return result;
        }

        public async Task<int> DeleteOrder(int id)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_DeleteOrder", ds.CreateParameter("OrderID", id));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return result;
        }

        public async Task<int> UpdateOrder(Order order)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_UpdateOrder", 
                        ds.CreateParameter("OrderID", order.OrderID),
                        ds.CreateParameter("UserID", order.UserID),
                        ds.CreateParameter("PaymentStatusID", order.PaymentStatusID),
                        ds.CreateParameter("TransactionID", order.TransactionID),
                        ds.CreateParameter("TrackingNumber", order.TrackingNumber),
                        ds.CreateParameter("SubTotal", order.SubTotal),
                        ds.CreateParameter("OrderTotal", order.OrderTotal),
                        ds.CreateParameter("Tax", order.Tax),
                        ds.CreateParameter("ShippingCharges", order.ShippingCharges),
                        ds.CreateParameter("OrderDate", order.OrderDate),
                        ds.CreateParameter("DeliveryDate", order.DeliveryDate),
                        ds.CreateParameter("SpecialInstruction", order.SpecialInstruction));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return result;
        }

        public async Task<List<Order>> GetOrderByUserID(int id)
        {
            List<Order> orderList = new List<Order>();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    orderList = await ds.GetResults<Order>("usp_GetOrderByUserID", ds.CreateParameter("UserID", id));
                }
            }
            catch (Exception)
            {
                return null;
            }

            return orderList;
        }

        #endregion
    }
}
