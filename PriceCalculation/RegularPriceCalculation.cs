using deel1;
using sofa3.FreeTickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.PriceCalculation
{
    public class RegularPriceCalculation : PriceCalculation
    {
        public decimal CalculatePrice(List<MovieTicket> tickets)
        {
            var isWeekend = TicketUtilities.CheckIsWeekend(tickets);
            var freeTickets = TicketUtilities.CalculateFreeTickets(false, isWeekend, tickets);
            var hasDiscount = TicketUtilities.CheckForDiscount(false, isWeekend);

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
                    ticketPrice += TicketUtilities.GetPremiumPrice(false, premiumTicket);
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
                price += TicketUtilities.GetPremiumPrice(false, premiumTicket);
            }
            return price;
        }
    }
}
