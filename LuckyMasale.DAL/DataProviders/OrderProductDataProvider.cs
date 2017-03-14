using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IOrderProductDataProvider : IBaseDataProvider
    {
        Task<List<OrderProduct>> GetOrderProductByOrderID(int id);
        Task<int> InsertOrderProduct(OrderProduct orderProduct);
        Task<int> UpdateOrderProduct(OrderProduct orderProduct);
    }

    public class OrderProductDataProvider : BaseDataProvider, IOrderProductDataProvider
    {
        #region Constructors

        public OrderProductDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion

        #region Methods

        public async Task<List<OrderProduct>> GetOrderProductByOrderID(int id)
        {
            List<OrderProduct> orderProducts = new List<OrderProduct>();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    orderProducts = await ds.GetResults<OrderProduct>("usp_GetOrderProduct", ds.CreateParameter("OrderID", id));
                }
            }
            catch (Exception)
            {
                return null;
            }

            return orderProducts;
        }

        public async Task<int> InsertOrderProduct(OrderProduct orderProduct)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_InsertOrderProduct",
                        ds.CreateParameter("ProductID", orderProduct.ProductId),
                        ds.CreateParameter("OrderID", orderProduct.OrderId),
                        ds.CreateParameter("Price", orderProduct.Price),
                        ds.CreateParameter("Quantity", orderProduct.Quantity));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return result;
        }

        public async Task<int> UpdateOrderProduct(OrderProduct orderProduct)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_UpdateOrderProduct",
                        ds.CreateParameter("OrderProductID", orderProduct.OrderProductID),
                        ds.CreateParameter("ProductId", orderProduct.ProductId),
                        ds.CreateParameter("OrderId", orderProduct.OrderId),
                        ds.CreateParameter("Price", orderProduct.Price),
                        ds.CreateParameter("Quantity", orderProduct.Quantity));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return result;
        }

        #endregion
    }
}
