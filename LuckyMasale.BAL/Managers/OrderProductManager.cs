using LuckyMasale.DAL.DataProviders;
using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IOrderProductManager
    {
        Task<List<OrderProduct>> GetOrderProductByOrderID(int id);
        Task<int> InsertOrderProduct(OrderProduct orderProduct);
    }

    public class OrderProductManager : IOrderProductManager
    {
        private Lazy<IOrderProductDataProvider> orderProductDataProvider;

        #region Constructors

        public OrderProductManager(Lazy<IOrderProductDataProvider> orderProductDataProvider)
        {
            this.orderProductDataProvider = orderProductDataProvider;
        }

        #endregion

        #region Methods

        public async Task<List<OrderProduct>> GetOrderProductByOrderID(int id)
        {
            return await orderProductDataProvider.Value.GetOrderProductByOrderID(id);
        }

        public async Task<int> InsertOrderProduct(OrderProduct orderProduct)
        {
            return await orderProductDataProvider.Value.InsertOrderProduct(orderProduct);
        }

        #endregion
    }
}
