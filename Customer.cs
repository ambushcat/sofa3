using sofa3.CustomerNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3
{
    public class Customer
    {
        private IObserver notificationService;
        public Customer(IObserver notificationService)
        {
            this.notificationService = notificationService;
        }

        public IObserver GetNotificationService()
        {
            return notificationService;
        }
    }
}
