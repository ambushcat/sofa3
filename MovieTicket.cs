namespace deel1
{
    public class MovieTicket
    {
        private int rowNr;
        private int seatNr;
        private bool premiumTicket;
        private MovieScreening movieScreening;
        
        public MovieTicket(bool premiumTicket, int seatRow, int seatNr, MovieScreening movieScreening)
        {
            this.premiumTicket = premiumTicket;
            this.seatNr = seatNr;
            this.rowNr = seatRow;
            this.movieScreening = movieScreening;

        }

        public decimal getPrice()
        {
            return movieScreening.getPricePerSeat();
        }

        public bool isPremium()
        {
            return premiumTicket;
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
