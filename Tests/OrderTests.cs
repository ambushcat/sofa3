using FluentAssertions;
using sofa3;
using sofa3.Export;
using sofa3.PriceCalculation;
using Xunit;

namespace deel1.Tests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldCalculatePrice()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Now;
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket firstTicket = new MovieTicket(false, 4, 12, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, true, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(firstTicket);
            var result = studentOrder.calculatePrice();

            //Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void ShouldCalculatePremiumPrice()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Now;
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket firstTicket = new MovieTicket(true, 4, 12, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, false, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(firstTicket);
            var result = studentOrder.calculatePrice();

            //Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void ShouldCalculateStudentPremiumPrice()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Now;
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket firstTicket = new MovieTicket(true, 4, 12, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, true, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(firstTicket);
            var result = studentOrder.calculatePrice();

            //Assert
            Assert.Equal(14, result);
        }

        [Fact]
        public void ShouldCalculateStudentPremiumPriceWithFreeTicket()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Now;
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket firstTicket = new MovieTicket(true, 4, 12, movieScreening);
            MovieTicket secondTicket = new MovieTicket(true, 4, 13, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, true, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(firstTicket);
            studentOrder.addSeatReservation(secondTicket);
            var result = studentOrder.calculatePrice();

            //Assert
            result.Should().Be(14);
        }

        [Fact]
        public void ShouldCalculateGroupDiscountPrice()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Parse("2024/02/04");
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket ticket1 = new MovieTicket(false, 4, 12, movieScreening);
            MovieTicket ticket2 = new MovieTicket(false, 4, 13, movieScreening);
            MovieTicket ticket3 = new MovieTicket(false, 4, 14, movieScreening);
            MovieTicket ticket4 = new MovieTicket(false, 4, 15, movieScreening);
            MovieTicket ticket5 = new MovieTicket(false, 4, 16, movieScreening);
            MovieTicket ticket6 = new MovieTicket(false, 4, 17, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, false, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(ticket1);
            studentOrder.addSeatReservation(ticket2);
            studentOrder.addSeatReservation(ticket3);
            studentOrder.addSeatReservation(ticket4);
            studentOrder.addSeatReservation(ticket5);
            studentOrder.addSeatReservation(ticket6);
            var result = studentOrder.calculatePrice();

            //Assert
            result.Should().Be((decimal)64.8);
        }

        [Fact]
        public void ShouldCalculateGroupDiscountPriceWithPremiumTickets()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Parse("2024/02/04");
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket ticket1 = new MovieTicket(true, 4, 12, movieScreening);
            MovieTicket ticket2 = new MovieTicket(true, 4, 13, movieScreening);
            MovieTicket ticket3 = new MovieTicket(true, 4, 14, movieScreening);
            MovieTicket ticket4 = new MovieTicket(true, 4, 15, movieScreening);
            MovieTicket ticket5 = new MovieTicket(true, 4, 16, movieScreening);
            MovieTicket ticket6 = new MovieTicket(true, 4, 17, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, false, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(ticket1);
            studentOrder.addSeatReservation(ticket2);
            studentOrder.addSeatReservation(ticket3);
            studentOrder.addSeatReservation(ticket4);
            studentOrder.addSeatReservation(ticket5);
            studentOrder.addSeatReservation(ticket6);
            var result = studentOrder.calculatePrice();

            //Assert
            result.Should().Be(81);
        }

        [Fact]
        public void ShouldCalculateGroupDiscountPriceWithMixedTickets()
        {
            //Arrange
            DateTime dateAndTime = DateTime.Parse("2024/02/04");
            Movie movie = new Movie("Godzilla vs Kong");
            MovieScreening movieScreening = new MovieScreening(movie, dateAndTime, 12);
            MovieTicket ticket1 = new MovieTicket(true, 4, 12, movieScreening);
            MovieTicket ticket2 = new MovieTicket(true, 4, 13, movieScreening);
            MovieTicket ticket3 = new MovieTicket(true, 4, 14, movieScreening);
            MovieTicket ticket4 = new MovieTicket(false, 4, 15, movieScreening);
            MovieTicket ticket5 = new MovieTicket(false, 4, 16, movieScreening);
            MovieTicket ticket6 = new MovieTicket(false, 4, 17, movieScreening);
            ExportFactory exportFactory = new ExportFactory();
            PriceCalculationFactory priceCalculationFactory = new PriceCalculationFactory();
            Order studentOrder = new Order(1, false, exportFactory, priceCalculationFactory);

            //Act
            studentOrder.addSeatReservation(ticket1);
            studentOrder.addSeatReservation(ticket2);
            studentOrder.addSeatReservation(ticket3);
            studentOrder.addSeatReservation(ticket4);
            studentOrder.addSeatReservation(ticket5);
            studentOrder.addSeatReservation(ticket6);
            var result = studentOrder.calculatePrice();

            //Assert
            result.Should().Be((decimal)72.9);
        }
    }
}
