using deel1;
using sofa3.FreeTickets;

namespace sofa3.PriceCalculation
{
    public class StudentPriceCalculation : PriceCalculation
    {
        public decimal CalculatePrice(List<MovieTicket> tickets)
        {
            var isWeekend = TicketUtilities.CheckIsWeekend(tickets);
            var freeTickets = TicketUtilities.CalculateFreeTickets(true, isWeekend, tickets);

            if (freeTickets > 0)
            {
                return calculatePriceWithFreeTickets(freeTickets, tickets);
            }
            else
            {
                return normalPrice(tickets);
            }
        }

        private decimal calculatePriceWithFreeTickets(int freeTickets, List<MovieTicket> tickets)
        {
            var premiumTickets = tickets.GroupBy(x => x.isPremium());
            var regularTickets = tickets.GroupBy(x => !x.isPremium());

            decimal price = 0;

            foreach (MovieTicket ticket in regularTickets)
            {
                decimal ticketPrice = 0;
                if (freeTickets > 0)
                {
                    freeTickets--;
                }
                else
                {
                    ticketPrice += ticket.getPrice();
                }
                price += ticketPrice;
            }

            foreach (MovieTicket premiumTicket in premiumTickets)
            {
                decimal ticketPrice = 0;
                if (freeTickets > 0)
                {
                    freeTickets--;
                }
                else
                {
                    ticketPrice += TicketUtilities.GetPremiumPrice(true, premiumTicket);
                }
                price += ticketPrice;
            }
            return price;
        }

        private decimal normalPrice(List<MovieTicket> tickets)
        {
            var premiumTickets = tickets.GroupBy(x => x.isPremium());
            var regularTickets = tickets.GroupBy(x => !x.isPremium());

            decimal price = 0;

            foreach (MovieTicket ticket in tickets)
            {
                price += ticket.getPrice();
            }
            foreach (MovieTicket premiumTicket in premiumTickets)
            {
                price += TicketUtilities.GetPremiumPrice(true, premiumTicket);
            }
            return price;
        }
    }
}
