// See https://aka.ms/new-console-template for more information
using deel1;
using sofa3;
using sofa3.Export;
using sofa3.PriceCalculation;
using System;

Console.WriteLine("Hello, World!");

DateTime dateAndTime= DateTime.Now;

Movie movie = new Movie("Godzilla vs Kong");
MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
MovieTicket firstTicket = new MovieTicket(true, 4, 12, movieScreening);
MovieTicket secondTicket = new MovieTicket(true, 4, 13, movieScreening);
ExportFactory exportFactory = new ExportFactory();
PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
Order studentOrder = new Order(1, false, exportFactory, priceCalculationFactory);

studentOrder.addSeatReservation(firstTicket);
//studentOrder.addSeatReservation(secondTicket);
studentOrder.Submit();
Console.WriteLine(studentOrder.calculatePrice());
studentOrder.Submit();
studentOrder.Pay();
studentOrder.Cancel();
//studentOrder.export(TicketExportFormat.JSON);