
using deel1;

namespace sofa3.OrderState
{
    public interface IOrderState
    {
        void Submit();
        void EditOrder();
        void Pay();
        void Cancel();
        void CheckPayed();
    }
}
