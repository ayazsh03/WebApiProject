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
    public class OrderController : ApiController
    {
        #region Properties

        private Lazy<IOrderManager> orderManager;
        private Lazy<IOrderProductManager> orderProductManager;

        #endregion

        #region Constructors

        public OrderController(Lazy<IOrderManager> orderManager, Lazy<IOrderProductManager> orderProductManager)
        {
            this.orderManager = orderManager;
            this.orderProductManager = orderProductManager;
        }

        #endregion

        #region Methods

        public async Task<List<Order>> GetAllOrders()
        {
            return await orderManager.Value.GetAllOrders();
        }

        public async Task<Order> GetOrderByID(int id)
        {
            return await orderManager.Value.GetOrderByID(id);
        }

        [HttpPost]
        public async Task<int> InsertOrder(Order order)
        {
            return await orderManager.Value.InsertOrder(order);
        }

        [HttpPost]
        public async Task<int> DeleteOrder(int id)
        {
            return await orderManager.Value.DeleteOrder(id);
        }

        [HttpPost]
        public async Task<int> UpdateOrder(Order order)
        {
            return await orderManager.Value.UpdateOrder(order);
        }

        public async Task<List<OrderProduct>> GetOrderProductByOrderID(int id)
        {
            return await orderProductManager.Value.GetOrderProductByOrderID(id);
        }

        public async Task<int> InsertOrderProduct(OrderProduct orderProduct)
        {
            return await orderProductManager.Value.InsertOrderProduct(orderProduct);
        }

        #endregion
    }
}