using deel1;

namespace sofa3.Utils
{
    public class StudentTicketUtilities : TicketUtilities
    {
        public int CalculateFreeTickets(List<MovieTicket> tickets, bool isWeekend = false)
        {
            return tickets.Count / 2;
        }

        public decimal GetPremiumPrice(MovieTicket ticket)
        {
            return ticket.getPrice() + 2;
        }
        public bool CheckIsWeekend(List<MovieTicket> tickets)
        {
            return tickets.First().isWeekend();
        }

        public List<MovieTicket> GetRegularTickets()
        {
            throw new NotImplementedException();
        }

        public List<MovieTicket> GetPremiumTickets()
        {
            throw new NotImplementedException();
        }
    }
}
