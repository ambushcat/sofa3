namespace deel1
{
    class MovieScreening
    {
        public DateTime dateAndTime;
        private double pricePerSeat;

        public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
        {
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
        }
        public double getPricePerSeat()
        {
            return 0;
        }
        public string toString()
        {
            return null;
        }
    }
}
