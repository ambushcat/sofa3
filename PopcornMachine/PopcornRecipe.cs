

namespace sofa3.PopcornMachine
{
    public abstract class PopcornRecipe
    {
        public void PreparePopcorn()
        {
            HeatOil();
            AddPopcorn();
            GetPopcorn();
            ChooseTaste();
            MixPopcorn();
            AddTopping();

        }
        void HeatOil()
        {
            Console.WriteLine("Heating the oil");
        }
        void AddPopcorn()
        {
            Console.WriteLine("Adds dried corn");
        }
        void GetPopcorn()
        {
            Console.WriteLine("Popcorn!");
        }
        public abstract void ChooseTaste();
        void MixPopcorn()
        {
            Console.WriteLine("Mix the popcorn!");
        }
        public abstract void AddTopping();
        
    }
}
