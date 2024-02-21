
namespace sofa3.OrderState
{
    public class ReservateState : IOrderState
    {
        Order order;

        public ReservateState(Order order)
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
            order.SetState(order.GetBuyState());
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
