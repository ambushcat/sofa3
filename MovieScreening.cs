namespace deel1
{
    class MovieScreening
    {
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
    }
}
