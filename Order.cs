using deel1;
using sofa3.CustomerNotification;
using sofa3.Export;
using sofa3.OrderState;
using sofa3.PriceCalculation;
using System.Net.Sockets;
using System.Text.Json;

namespace sofa3
{
    public class Order : ISubject
    {
        IOrderState buyState;
        IOrderState doneState;
        IOrderState reservateState;
        IOrderState cancelState;
        IOrderState state;

        private List<Customer> customersToNotify = [];
        private int orderNr;
        private bool studentOrder;
        private List<MovieTicket> tickets = new List<MovieTicket>();
        private ExportFactory exportFactory;
        private PriceCalculationFactory priceCalculationFactory;
        public Order(int orderNr, bool studentOrder, ExportFactory exportFactory, PriceCalculationFactory priceCalculationFactory)
        {
            this.orderNr = orderNr;
            this.studentOrder = studentOrder;
            this.exportFactory = exportFactory;
            this.priceCalculationFactory = priceCalculationFactory;
            this.buyState = new BuyState(this);
            this.reservateState = new ReservateState(this);
            this.doneState = new DoneState(this);
            this.cancelState = new CancelSate(this);
            state = buyState;
        }
        public int getOrderNr()
        {
            return orderNr;
        }

        public bool isStudentOrder()
        {
            return studentOrder;
        }

        public void addSeatReservation(MovieTicket ticket)
        {
            tickets.Add(ticket);
        }

        public decimal calculatePrice()
        {
            var pc = priceCalculationFactory.createPriceCalculation(this);
            return pc.CalculatePrice(tickets);
        }

        public void export(TicketExportFormat exportFormat)
        {
            exportFactory.createExport(exportFormat);
        }

        public void Submit()
        {
            state.Submit();
        }
        public void EditOrder()
        {
            state.EditOrder();

        }
        public void Pay()
        {
            state.Pay();
        }
        public void Cancel()
        {
            state.Cancel();
        }
        public IOrderState GetBuyState()
        {
            return buyState;
        }
        public IOrderState GetReservateState()
        {
            return reservateState;
        }

        public IOrderState GetCancelState()
        {
            return cancelState;
        }
        public IOrderState GetDoneState()
        {
            return doneState;
        }
        public void SetState(IOrderState state)
        {
            this.state = state;
        }
        public void CheckPaid()
        {
            state.CheckPaid();
        }

        public DateTime GetScreeningTime()
        {
            return tickets.First().GetScreeningTime();
        }

        public void RegisterObserver(Customer customer)
        {
            customersToNotify.Add(customer);
        }

        public void RemoveObserver(Customer customer)
        {
            customersToNotify.Remove(customer);
        }

        public void NotifyObserver(string message)
        {
            foreach (Customer customer in customersToNotify)
            {
                customer.GetNotificationService().Update(message);
            }
        }
    }
}
