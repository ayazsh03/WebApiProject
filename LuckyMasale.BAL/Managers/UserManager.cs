using LuckyMasale.DAL.DataProviders;
using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IUserManager
    {
        Task<int> DeleteUser(int id);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByID(int id);
        Task<int> InsertUser(User user);
        Task<int> UpdateUser(User user);  
    }

    public class UserManager : IUserManager
    {
        private Lazy<IUserDataProvider> userDataProvider;

        #region Constructors

        public UserManager(Lazy<IUserDataProvider> userDataProvider)
        {
            this.userDataProvider = userDataProvider;
        }

        #endregion

        #region Methods

        public async Task<int> DeleteUser(int id)
        {
            return await userDataProvider.Value.DeleteUser(id);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await userDataProvider.Value.GetAllUsers();
        }

        public async Task<User> GetUserByID(int id)
        {
            return await userDataProvider.Value.GetUserByID(id);
        }

        public async Task<int> InsertUser(User user)
        {
            return await userDataProvider.Value.InsertUser(user);
        }

        public async Task<int> UpdateUser(User user)
        {
            return await userDataProvider.Value.UpdateUser(user);
        }   

        #endregion
    }
}
