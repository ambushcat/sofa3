

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
            order.SetState(order.GetCancelState());
            order.Cancel();
        }

        public void CheckPaid()
        {
            Console.WriteLine("You must sumbit order first");
        }

        public void EditOrder()
        {
            Console.WriteLine("Already editing order");
        }

        public void Pay()
        {
            Console.WriteLine("Submit order");
        }

        public void Submit()
        {
            order.NotifyObserver("Submitting order");
            order.SetState(order.GetReservateState());
        }
    }
}
