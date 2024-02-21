using deel1;
using sofa3.Utils;

namespace sofa3.PriceCalculation
{
    public class StudentPriceCalculation : PriceCalculation
    {
        private StudentTicketUtilities studentTicketUtilities;
        public StudentPriceCalculation(StudentTicketUtilities studentTicketUtilities)
        {
            this.studentTicketUtilities = studentTicketUtilities;
        }

        public decimal CalculatePrice(List<MovieTicket> tickets)
        {
            var isWeekend = studentTicketUtilities.CheckIsWeekend(tickets);
            var freeTickets = studentTicketUtilities.CalculateFreeTickets(tickets);

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
                    ticketPrice += studentTicketUtilities.GetPremiumPrice(premiumTicket);
                }
                price += ticketPrice;
            }
            return price;
        }

        public decimal normalPrice(List<MovieTicket> tickets)
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
                price += studentTicketUtilities.GetPremiumPrice(premiumTicket);
            }
            return price;
        }
    }
}
