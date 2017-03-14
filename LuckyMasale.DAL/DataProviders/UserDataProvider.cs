using LuckyMasale.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataProviders
{
    public interface IUserDataProvider : IBaseDataProvider
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByID(int id);
        Task<int> UpdateUser(User user);
        Task<int> DeleteUser(int id);
        Task<int> InsertUser(User user);
    }

    public class UserDataProvider : BaseDataProvider, IUserDataProvider
    {
        #region Constructors

        public UserDataProvider(IDataSourceFactory dataSourceFactory)
            : base(dataSourceFactory)
        {
        }

        #endregion

        #region Methods

        public async Task<List<User>> GetAllUsers()
        {
            List<User> userList = new List<User>();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    userList = await ds.GetResults<User>("usp_GetAllUsers");
                }
            }
            catch (Exception)
            {
            }

            return userList;
        }

        public async Task<User> GetUserByID(int id)
        {
            User user = new User();

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    user = await ds.GetResult<User>("usp_GetUserByID", ds.CreateParameter("UserID", id));
                }
            }
            catch (Exception)
            {
            }

            return user;
        }

        public async Task<int> UpdateUser(User user)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_UpdateUser",
                        ds.CreateParameter("UserId", user.UserId),
                        ds.CreateParameter("FirstName", user.FirstName),
                        ds.CreateParameter("LastName", user.LastName),
                        ds.CreateParameter("DateOfBirth", user.DateOfBirth),
                        ds.CreateParameter("EmailID", user.UserId),
                        ds.CreateParameter("Gender", user.Gender),
                        ds.CreateParameter("CompanyName", user.CompanyName),
                        ds.CreateParameter("StreetAddress1", user.StreetAddress1),
                        ds.CreateParameter("StreetAddress2", user.StreetAddress2),
                        ds.CreateParameter("PostCode", user.PostCode),
                        ds.CreateParameter("City", user.City),
                        ds.CreateParameter("StateId", user.StateId),
                        ds.CreateParameter("Country", user.Country),
                        ds.CreateParameter("Phone", user.Phone),
                        ds.CreateParameter("Fax", user.Fax),
                        ds.CreateParameter("Password", user.Password),
                        ds.CreateParameter("IsTaxExempt", user.IsTaxExempt),
                        ds.CreateParameter("IsAdmin", user.IsAdmin),
                        ds.CreateParameter("AdminComment", user.AdminComment),
                        ds.CreateParameter("Status", user.Status),
                        ds.CreateParameter("RegistrationDate", user.RegistrationDate),
                        ds.CreateParameter("OrderUser", user.OrderUser),
                        ds.CreateParameter("IsEmailValidated", user.IsEmailValidated),
                        ds.CreateParameter("UpdateDate", user.UpdateDate));
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

            return result;
        }

        public async Task<int> DeleteUser(int id)
        {
            int result = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    result = await ds.ExecuteNonQuery("usp_DeleteUser", ds.CreateParameter("UserId", id));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return result;
        }

        public async Task<int> InsertUser(User user)
        {
            int userID = 0;

            try
            {
                using (var ds = DataSourceFactory.CreateDataSource())
                {
                    userID = await ds.ExecuteNonQuery("usp_InsertUser",                        
                        ds.CreateParameter("FirstName", user.FirstName),
                        ds.CreateParameter("LastName", user.LastName),
                        ds.CreateParameter("DateOfBirth", user.DateOfBirth),
                        ds.CreateParameter("EmailID", user.UserId),
                        ds.CreateParameter("Gender", user.Gender),
                        ds.CreateParameter("CompanyName", user.CompanyName),
                        ds.CreateParameter("StreetAddress1", user.StreetAddress1),
                        ds.CreateParameter("StreetAddress2", user.StreetAddress2),
                        ds.CreateParameter("PostCode", user.PostCode),
                        ds.CreateParameter("City", user.City),
                        ds.CreateParameter("StateId", user.StateId),
                        ds.CreateParameter("Country", user.Country),
                        ds.CreateParameter("Phone", user.Phone),
                        ds.CreateParameter("Fax", user.Fax),
                        ds.CreateParameter("Password", user.Password),
                        ds.CreateParameter("IsTaxExempt", user.IsTaxExempt),
                        ds.CreateParameter("IsAdmin", user.IsAdmin),
                        ds.CreateParameter("AdminComment", user.AdminComment),
                        ds.CreateParameter("Status", user.Status),
                        ds.CreateParameter("RegistrationDate", user.RegistrationDate),
                        ds.CreateParameter("OrderUser", user.OrderUser),
                        ds.CreateParameter("IsEmailValidated", user.IsEmailValidated),
                        ds.CreateParameter("UpdateDate", user.UpdateDate));
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return userID;
        }

        #endregion
    }
}
