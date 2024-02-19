using deel1;
using sofa3.Utils;

namespace sofa3.PriceCalculation
{
    public class RegularPriceCalculation : PriceCalculation
    {
        private RegularTicketUtilities regularTicketUtilities;
        public RegularPriceCalculation(RegularTicketUtilities regularTicketUtilities)
        {
            this.regularTicketUtilities = regularTicketUtilities;
        }

        public decimal CalculatePrice(List<MovieTicket> tickets)
        {
            var isWeekend = regularTicketUtilities.CheckIsWeekend(tickets);
            var freeTickets = regularTicketUtilities.CalculateFreeTickets(tickets, isWeekend);
            var hasDiscount = regularTicketUtilities.CheckForDiscount(isWeekend);

            if (freeTickets > 0)
            {
                return calculatePriceWithFreeTickets(freeTickets, tickets);
            }
            if (hasDiscount)
            {
                return calculatePriceWithDiscount(tickets);
            }
            else
            {
                return normalPrice(tickets);
            }
        }

        private decimal calculatePriceWithDiscount(List<MovieTicket> tickets)
        {
            if (tickets.Count >= 6)
            {
                return normalPrice(tickets) * (decimal)0.9;
            }
            else
            {
                return normalPrice(tickets);
            }

        }

        private decimal calculatePriceWithFreeTickets(int freeTickets, List<MovieTicket> tickets)
        {
            var premiumTickets = tickets.Where(x => x.isPremium());
            var regularTickets = tickets.Where(x => !x.isPremium());

            decimal price = 0;

            foreach (MovieTicket regularTicket in regularTickets)
            {
                decimal ticketPrice = 0;
                if (freeTickets > 0)
                {
                    freeTickets--;
                }
                else
                {
                    ticketPrice += regularTicket.getPrice();
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
                    ticketPrice += regularTicketUtilities.GetPremiumPrice(premiumTicket);
                }
                price += ticketPrice;
            }
            return price;
        }

        private decimal normalPrice(List<MovieTicket> tickets)
        {
            var premiumTickets = tickets.Where(x => x.isPremium());
            var regularTickets = tickets.Where(x => !x.isPremium());

            decimal price = 0;

            foreach (MovieTicket regularTicket in regularTickets)
            {
                price += regularTicket.getPrice();
            }
            foreach (MovieTicket premiumTicket in premiumTickets)
            {
                price += regularTicketUtilities.GetPremiumPrice(premiumTicket);
            }
            return price;
        }
    }
}
