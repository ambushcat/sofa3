

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
            Console.WriteLine("Already completed");
        }

        public void CheckPaid()
        {
            Console.WriteLine("This order has been paid for");
        }

        public void EditOrder()
        {
            Console.WriteLine("Already completed");
        }

        public void Pay()
        {
            Console.WriteLine("Already completed");
        }

        public void Submit()
        {
            Console.WriteLine("Already completed");
        }
    }
}
