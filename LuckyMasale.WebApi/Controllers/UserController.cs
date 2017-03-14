using LuckyMasale.BAL.Managers;
using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace LuckyMasale.WebApi.Controllers
{
    public class UserController : ApiController
    {
        #region Properties

        private Lazy<IUserManager> userManager;
        private Lazy<IOrderManager> orderManager;
        private Lazy<IDeliveryAddressManager> deliveryAddressManager;

        #endregion

        #region Constructors

        public UserController(Lazy<IUserManager> userManager, Lazy<IOrderManager> orderManager, Lazy<IDeliveryAddressManager> deliveryAddressManager) 
        {
            this.userManager = userManager;
            this.orderManager = orderManager;
            this.deliveryAddressManager = deliveryAddressManager;
        }

        #endregion

        #region Methods

        [HttpPost]
        public async Task<int> DeleteUser(int id)
        {
            return await userManager.Value.DeleteUser(id);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await userManager.Value.GetAllUsers();
        }

        public async Task<User> GetUserByID(int id)
        {
            return await userManager.Value.GetUserByID(id);
        }

        [HttpPost]
        public async Task<int> InsertUser(User user)
        {
            return await userManager.Value.InsertUser(user);
        }

        [HttpPost]
        public async Task<int> UpdateUser(User user)
        {
            return await userManager.Value.UpdateUser(user);
        }

        public async Task<List<Order>> GetOrderByUserID(int id)
        {
            return await orderManager.Value.GetOrderByUserID(id);
        }           

        #endregion
    }
}