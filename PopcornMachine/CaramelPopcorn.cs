
namespace sofa3.PopcornMachine
{
    public class CaramelPopcorn : PopcornRecipe
    {
        public override void AddTopping()
        {
            Console.WriteLine("Adds a chocolate topping to the popcorn");
        }

        public override void ChooseTaste()
        {
            Console.WriteLine("Adds caramel");
        }
    }
}
