using deel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace sofa3.Export
{
    class ExportJSON : Export
    {
        public void doExport(List<MovieTicket> tickets)
        {
            foreach (var ticket in tickets)
            {
                string jsonFormatTicket = JsonSerializer.Serialize(ticket);
                Console.WriteLine(jsonFormatTicket);
            }
        }
    }
}
