using LuckyMasale.DAL.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Managers
{
    public interface ISubscriberListManager
    { }

    public class SubscriberListManager:ISubscriberListManager
    {
        private Lazy<ISubscriberListDataProvider> subscriberListDataProvider;

        public SubscriberListManager(Lazy<ISubscriberListDataProvider> subscriberListDataProvider)
        {
            this.subscriberListDataProvider = subscriberListDataProvider;
        }
    }
}
