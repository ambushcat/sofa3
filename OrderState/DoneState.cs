

namespace sofa3.OrderState
{
    public class DoneState : IOrderState
    {
        Order order;

        public DoneState(Order order)
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
