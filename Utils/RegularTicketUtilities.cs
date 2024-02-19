using deel1;

namespace sofa3.Utils
{
    public class RegularTicketUtilities : TicketUtilities
    {
        public int CalculateFreeTickets(List<MovieTicket> tickets, bool isWeekend)
        {
            if (!isWeekend)
            {
                return tickets.Count / 2;
            }
            return 0;
        }

        public bool CheckForDiscount(bool isWeekend)
        {
            if (isWeekend)
            {
                return true;
            }
            return false;
        }

        public decimal GetPremiumPrice(MovieTicket ticket)
        {
            return ticket.getPrice() + 3;
        }
        public bool CheckIsWeekend(List<MovieTicket> tickets)
        {
            return tickets.First().isWeekend();
        }
    }
}
