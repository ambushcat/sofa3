// See https://aka.ms/new-console-template for more information
using deel1;
using sofa3.Theater;

DateTime dateAndTime= DateTime.Now;

Movie movie = new Movie("Godzilla vs Kong");
Movie imaxMovie = new Movie("IMAX Godzilla vs Kong");
MovieTheater theater = new MovieTheater();
Room regularRoom = new Room();
Room imaxRoom = new Room();

MovieScreening movieScreening = new MovieScreening(imaxMovie, dateAndTime, 12);
MovieScreening imaxMovieScreening = new MovieScreening(movie, dateAndTime, 12);

MovieTicket regularTicket = new MovieTicket(false, 1, 1, movieScreening);
MovieTicket imaxTicket = new MovieTicket(false, 1, 1, imaxMovieScreening);
MovieTicket imaxTicket2 = new MovieTicket(false, 1, 2, imaxMovieScreening);

theater.Add(regularRoom);
theater.Add(imaxRoom);

imaxRoom.Add(imaxMovieScreening);
regularRoom.Add(movieScreening);

movieScreening.Add(regularTicket);
imaxMovieScreening.Add(imaxTicket);
imaxMovieScreening.Add(imaxTicket2);

Console.WriteLine(theater.Operation());