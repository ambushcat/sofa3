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

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void CheckPayed()
        {
            throw new NotImplementedException();
        }

        public void EditOrder()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
