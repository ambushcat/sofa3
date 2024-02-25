

namespace sofa3.CustomerNotification
{
    public class WhatsappObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
