using System.Net.Sockets;

namespace deel1
{
    class Order
    {
        private int orderNr;
        private bool isStudentOrder;
        private decimal price;
        private List<MovieTicket> tickets;
        private List<MovieTicket> premiumTickets;
        private bool isWeekend = false;
        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
        }
        public int getOrderNr()
        {
            return 1;
        }
        public void addSeatReservation(MovieTicket ticket)
        {
            if(ticket.isWeekend())
            {
                this.isWeekend = true;
            }

            if (ticket.isPremium)
            {
                premiumTickets.Add(ticket);
            }
            else
            {
                tickets.Add(ticket);
            }
        }
        public decimal calculatePrice()
        {
            var freeTickets = calculateFreeTickets();
            Console.WriteLine("Free tickets: ", freeTickets);
            return calculatePriceWithFreeTickets(freeTickets);
        }
        public void export(TicketExportFormat exportFormat)
        {

        }

        private int calculateFreeTickets()
        {
            if (isStudentOrder || !isWeekend)
            {
                return (tickets.Count + premiumTickets.Count) / 2;
            }
            return 0;
        }

        private decimal calculatePriceWithFreeTickets(int freeTickets)
        {
            decimal price = 0;
            foreach (var ticket in tickets)
            {
                decimal ticketPrice = 0;
                if(freeTickets > 0)
                {
                    freeTickets --;
                } else
                {
                    ticketPrice += ticket.getPrice();
                }
                price += ticketPrice;
            }
            foreach(var premiumTicket in premiumTickets)
            {
                decimal ticketPrice = 0;
                if (freeTickets > 0)
                {
                    freeTickets--;
                }
                else
                {
                    ticketPrice += premiumTicket.getPrice();
                    ticketPrice += getPremiumprice();
                }
                price += ticketPrice;
            }
            return price;
        }

        private decimal getPremiumprice()
        {
            if(isStudentOrder)
            {
                return 2;
            }
            return 3;
        }
    }
}
