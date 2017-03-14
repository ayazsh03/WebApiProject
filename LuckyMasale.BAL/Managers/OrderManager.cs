using LuckyMasale.DAL.DataProviders;
using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IOrderManager
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderByID(int id);
        Task<int> InsertOrder(Order order);
        Task<int> DeleteOrder(int id);
        Task<int> UpdateOrder(Order order);
        Task<List<Order>> GetOrderByUserID(int id);
    }

    public class OrderManager : IOrderManager
    {
        private Lazy<IOrderDataProvider> orderDataProvider;

        #region Constructors

        public OrderManager(Lazy<IOrderDataProvider> orderDataProvider)
        {
            this.orderDataProvider = orderDataProvider;
        }

        #endregion

        #region Methods

        public async Task<List<Order>> GetAllOrders()
        {
            return await orderDataProvider.Value.GetAllOrders();
        }

        public async Task<Order> GetOrderByID(int id)
        {
            return await orderDataProvider.Value.GetOrderByID(id);
        }

        public async Task<int> InsertOrder(Order order)
        {
            return await orderDataProvider.Value.InsertOrder(order);
        }

        public async Task<int> DeleteOrder(int id)
        {
            return await orderDataProvider.Value.DeleteOrder(id);
        }

        public async Task<int> UpdateOrder(Order order)
        {
            return await orderDataProvider.Value.UpdateOrder(order);
        }

        public async Task<List<Order>> GetOrderByUserID(int id)
        {
            return await orderDataProvider.Value.GetOrderByUserID(id);
        }

        #endregion
    }
}
