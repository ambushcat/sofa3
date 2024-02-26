using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.PopcornMachine
{
    public class SweetPopcorn : PopcornRecipe
    {
        public override void AddTopping()
        {
            Console.WriteLine("Adds a caramel topping to the popcorn");
        }

        public override void ChooseTaste()
        {
            Console.WriteLine("Adds sugarwater");
        }
    }
}
