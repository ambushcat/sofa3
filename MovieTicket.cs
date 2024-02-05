namespace deel1
{
    class MovieTicket
    {
        private int rowNr;
        private int seatNr;
        public bool isPremium;
        private MovieScreening movieScreening;
        
        public MovieTicket(bool isPremiumReservation, int seatRow, int seatNr, MovieScreening movieScreening)
        {
            this.isPremium = isPremiumReservation;
            this.seatNr = seatNr;
            this.rowNr = seatRow;
            this.movieScreening = movieScreening;

        }

        public decimal getPrice()
        {
            return movieScreening.getPricePerSeat();
        }

        public string toString()
        {
            return "Movieticket ~ Seat nummer; " + seatNr + ", Row nummer; " + rowNr + ", Is a premium seat; " + isPremium;
        }

        public bool isWeekend()
        {
            if(movieScreening.dateAndTime.DayOfWeek == DayOfWeek.Saturday || movieScreening.dateAndTime.DayOfWeek == DayOfWeek.Sunday || movieScreening.dateAndTime.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            return false;
        }
    }
}
