using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface ICategoryManager
    { }

    public class CategoryManager:ICategoryManager
    {
        private Lazy<ICategoryDataProvider> categoryDataProvider;

        public CategoryManager(Lazy<ICategoryDataProvider> categoryDataProvider)
        {
            this.categoryDataProvider = categoryDataProvider;
        }
    }
}
