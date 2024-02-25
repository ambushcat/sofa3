

namespace sofa3.CustomerNotification
{
    public class EmailObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
