using sofa3.Export;
using sofa3.PriceCalculation;
using System.Net.Sockets;
using System.Text.Json;

namespace deel1
{
    public class Order
    {
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
    }
}
