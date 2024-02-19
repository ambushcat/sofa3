using deel1;

namespace sofa3.Utils
{
    public interface TicketUtilities
    {
        int CalculateFreeTickets(List<MovieTicket> tickets, bool isWeekend);
        decimal GetPremiumPrice(MovieTicket ticket);
        bool CheckIsWeekend(List<MovieTicket> tickets);
    }
}
