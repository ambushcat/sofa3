using sofa3.Utils;

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
