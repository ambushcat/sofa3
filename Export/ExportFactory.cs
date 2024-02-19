using deel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.Export
{
    public class ExportFactory
    {
        public Export createExport(TicketExportFormat format)
        {
            switch (format)
            {
                case TicketExportFormat.PLAINTEXT:
                    {
                        return new ExportPlainText();
                    }
                case TicketExportFormat.JSON:
                    {
                        return new ExportJSON();
                    }
                default:
                    {
                        return new ExportPlainText();
                    }
            }
        }
    }
}
