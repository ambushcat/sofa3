namespace deel1
{
    class MovieTicket
    {
        private int rowNr;
        private int seatNr;
        private bool isPremium;

        public MovieTicket(bool isPremiumReservation, int seatRow, int seatNr)
        {
            this.isPremium = isPremiumReservation;
            this.seatNr = seatNr;
            this.rowNr = seatRow;

        }
        public bool isPremiumTicket()
        {
            return true;
        }

        public double getPrice()
        {
            return 0;
        }

        public string toString()
        {
            return null;
        }
    }
}
