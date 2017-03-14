using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface IRelatedProductsManager
    { }

    public class RelatedProductsManager : IRelatedProductsManager
    {
        private Lazy<IRelatedProductsDataProvider> relatedProductsDataProvider;

        #region Constructors

        public RelatedProductsManager(Lazy<IRelatedProductsDataProvider> relatedProductsDataProvider)
        {
            this.relatedProductsDataProvider = relatedProductsDataProvider;
        }

        #endregion
    }
}
