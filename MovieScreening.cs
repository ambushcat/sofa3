using sofa3.Theater;

namespace deel1
{
    public class MovieScreening : Component
    {
        private List<Component> children = new List<Component>();

        public DateTime dateAndTime;
        private decimal pricePerSeat;

        public MovieScreening(Movie movie, DateTime dateAndTime, decimal pricePerSeat)
        {
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
        }
        public decimal getPricePerSeat()
        {
            return pricePerSeat;
        }
        public string toString()
        {
            return "Movie Screening ~ Date an time; " + dateAndTime + ", Price per seat; " + pricePerSeat;
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Screening(";

            foreach (Component component in this.children)
            {
                result += component.Operation();
                if (i != children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }

    }
}
