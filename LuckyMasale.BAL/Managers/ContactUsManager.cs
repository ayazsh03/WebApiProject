using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IContactUsManager
    { }

    public class ContactUsManager : IContactUsManager
    {
        private Lazy<IContactUsDataProvider> contactUsDataProvider;

        #region Constructors

        public ContactUsManager(Lazy<IContactUsDataProvider> contactUsDataProvider)
        {
            this.contactUsDataProvider = contactUsDataProvider;
        }

        #endregion
    }
}
