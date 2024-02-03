// See https://aka.ms/new-console-template for more information
using deel1;
using System;

Console.WriteLine("Hello, World!");

DateTime dateAndTime= DateTime.Now;

Movie movie = new Movie("Godzilla vs Kong");
MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
MovieTicket movieTicket = new MovieTicket(true, 4, 12, movieScreening);

Console.WriteLine(movie.toString());
Console.WriteLine(movieScreening.toString());
Console.WriteLine(movieTicket.toString());