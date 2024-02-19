using deel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.PriceCalculation
{
    public interface PriceCalculation
    {
        public decimal CalculatePrice(List<MovieTicket> tickets);
    }
}
