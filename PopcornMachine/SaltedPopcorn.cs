using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.PopcornMachine
{
    public class SaltedPopcorn : PopcornRecipe
    {
        public override void AddTopping()
        {
            Console.WriteLine("No need for extra toppings");
        }

        public override void ChooseTaste()
        {
            Console.WriteLine("Adds salt");
        }
    }
}
