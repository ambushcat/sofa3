using deel1;
using sofa3.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.PriceCalculation
{
    public class PriceCalculationFactory
    {
        public PriceCalculation createPriceCalculation(Order order)
        {
            if (order.isStudentOrder())
            {
                return new StudentPriceCalculation(new StudentTicketUtilities());
            }
            return new RegularPriceCalculation(new RegularTicketUtilities());
        }
    }
}
