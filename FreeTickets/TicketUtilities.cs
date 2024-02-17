using deel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.FreeTickets
{
    public class TicketUtilities
    {
        public static int CalculateFreeTickets(bool isStudentOrder, bool isWeekend, List<MovieTicket> tickets)
        {
            if (isStudentOrder || !isWeekend)
            {
                return tickets.Count / 2;
            }
            return 0;
        }

        public static bool CheckForDiscount(bool isStudentOrder, bool isWeekend)
        {
            if (!isStudentOrder && isWeekend)
            {
                return true;
            }
            return false;
        }

        public static decimal GetPremiumPrice(bool isStudentOrder, MovieTicket ticket)
        {
            if (isStudentOrder)
            {
                return ticket.getPrice() + 2;
            }
            return ticket.getPrice() + 3;
        }
        public static bool CheckIsWeekend(List<MovieTicket> tickets)
        {
            return tickets.First().isWeekend();
        }
    }
}
