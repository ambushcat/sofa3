
namespace sofa3.CustomerNotification
{
    public interface ISubject
    {
        void RegisterObserver(Customer customer);
        void RemoveObserver(Customer customer);
        void NotifyObserver(string message);
    }
}
