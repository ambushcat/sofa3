using deel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.Export
{
    class ExportPlainText : Export
    {
        public void doExport(List<MovieTicket> tickets)
        {
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.toString());
            }
        }
    }
}
