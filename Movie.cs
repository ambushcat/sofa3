namespace deel1
{
    class Movie
    {
        private string title;
        private List<MovieScreening> screening;
        public Movie(string title)
        {
            this.title = title;
        }
        public void addScreening(MovieScreening movieScreening)
        {
            screening.Add(movieScreening);
        }
        public string toString()
        {
            return "Movie ~ Title; " + title;
        }
    }
}
