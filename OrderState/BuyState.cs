

namespace sofa3.OrderState
{
    public class BuyState : IOrderState
    {
        Order order;
        public BuyState(Order order)
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
            Console.WriteLine("Submitting to this state 😏");
            order.SetState(order.GetReservateState());
        }
    }
}
