
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
            Console.WriteLine("There goes your order. Can't say I didn't warn ya");
        }

        public void CheckPaid()
        {
            if (DateTime.Now.AddHours(-12) < order.GetScreeningTime())
            {
                order.SetState(order.GetCancelState());
                order.Cancel();
            }
            else
            {
                Console.WriteLine("Pay up bitch");
            }
        }

        public void EditOrder()
        {
            order.SetState(order.GetBuyState());
        }

        public void Pay()
        {
           order.SetState(order.GetDoneState());  
        }

        public void Submit()
        {
            Console.WriteLine("Already submitted");
        }
    }
}
