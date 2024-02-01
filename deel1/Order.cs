﻿namespace deel1
{
    class Order
    {
        private int orderNr;
        private bool isStudentOrder;
        private int price;
        private List<MovieTicket> tickets;
        private List<MovieTicket> premiumtickets;
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
                premiumtickets.Add(ticket);
            }
            else
            {
                tickets.Add(ticket);
            }
        }
        public double calculatePrice()
        {
            var freeTickets = calculateFreeTickets();

            Console.WriteLine("Free tickets: ", freeTickets);

            if (isStudentOrder)
            {
                return calculateStudentPrice(freeTickets);
            }
            return calculateNormalPrice(freeTickets);

        }
        public void export(TicketExportFormat exportFormat)
        {

        }

        private int calculateFreeTickets()
        {
            if (isStudentOrder || !isWeekend)
            {
                return (tickets.Count + premiumtickets.Count) / 2;
            }
            return 0;
        }

        private double calculateStudentPrice(int freeTickets)
        {
            double price = 0;
            foreach (var ticket in tickets)
            {
                if (ticket.isPremium)
                {

                }
            }
            return price;
        }

        private double calculateNormalPrice(int freeTickets)
        {
            double price = 0;
            foreach (var ticket in tickets)
            {
                double ticketPrice = 0;
                if(freeTickets > 0)
                {
                    freeTickets --;
                } else
                {
                    ticketPrice += ticket.getPrice();
                }
                price += ticketPrice;
            }
            foreach(var premiumTicket in premiumtickets)
            {

            }
            return price;
        }
    }
}
