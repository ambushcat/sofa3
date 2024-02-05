// See https://aka.ms/new-console-template for more information
using deel1;
using System;

Console.WriteLine("Hello, World!");

DateTime dateAndTime= DateTime.Now;

Movie movie = new Movie("Godzilla vs Kong");
MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
MovieTicket firstTicket = new MovieTicket(true, 4, 12, movieScreening);
MovieTicket secondTicket = new MovieTicket(true, 4, 13, movieScreening);

Order studentOrder = new Order(1, true);

studentOrder.addSeatReservation(firstTicket);
//studentOrder.addSeatReservation(secondTicket);
Console.WriteLine(studentOrder.calculatePrice());