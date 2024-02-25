using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.OrderState
{
    public class CancelSate : IOrderState
    {
        Order order;

        public CancelSate(Order order)
        {
            this.order = order;
        }

        public void Bought()
        {
            Console.WriteLine("Order canceled");
        }

        public void Cancel()
        {
            order.NotifyObserver("Canceling order...");
        }

        public void CheckPaid()
        {
            Console.WriteLine("Order canceled");
        }

        public void EditOrder()
        {
            Console.WriteLine("Order canceled");
        }

        public void Pay()
        {
            Console.WriteLine("Order canceled");
        }

        public void Submit()
        {
            Console.WriteLine("Order canceled");
        }
    }
}
