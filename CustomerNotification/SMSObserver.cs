

namespace sofa3.CustomerNotification
{
    public class SMSObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
