namespace DomainModel.Reservation.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DomainModel.Reservation.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<DomainModel.Reservation.Context.ReservationModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DomainModel.Reservation.Context.ReservationModelContext context)
        {
            var guestID1 = Guid.NewGuid();
            var guestID2 = Guid.NewGuid();
            var guestID3 = Guid.NewGuid();
            var guest1 = new Guest { Id = guestID1, FirstName = "John", LastName = "Miller", Email = "John@sifi.com", Phone = "+123456789" };
            var guest2 = new Guest { Id = guestID2, FirstName = "Jim", LastName = "Lance", Email = "Jim@sifi.com", Phone = "+123456789" };
            var guest3 = new Guest { Id = guestID3, FirstName = "Sivaraj", LastName = "Kumar", Email = "Shiv@sifi.com", Phone = "+123456789" };

            //var guestList = new List<Guest>
            //{
            //    guest1,
            //    guest2,
            //    guest3
            //};
            //guestList.ForEach(m=> context.Guests.Add(m));

            var hotel1 = new Hotel { Id = 1, City = "Bangalore", Description = "Oberai Bangalore" };
            var hotel2 = new Hotel { Id = 1, City = "Mumbai", Description = "Oberai Mumbai" };
            var hotel3 = new Hotel { Id = 1, City = "Hyderbad", Description = "Oberai Hyderbad" };
            //var hotelList = new List<Hotel>
            //{
            //    hotel1,
            //    hotel2,
            //    hotel3
            //};

            //hotelList.ForEach(m=> context.Hotels.Add(m));

            context.Policies.Add(new Policy { Id = 1, Percentage = 5 });

            var status1 = new Status { Id = 1, Name = "UnConfirmed", Description = "UnConfirmed Booking" };
            var status2 = new Status { Id = 2, Name = "Pending", Description = "Pending Booking" };
            var status3 = new Status { Id = 3, Name = "Confirmed", Description = "Confirmed Booking" };
            var status4 = new Status { Id = 4, Name = "Cancelled", Description = "Cancelled Booking" };
            //context.Statuses.Add(status1);
            //context.Statuses.Add(status2);
            //context.Statuses.Add(status3);
            //context.Statuses.Add(status4);

            //Need to fill Room class
            var room1 = new Room { Id = short.Parse("1"), Description = "Sleep Dorm", NoOfRooms = 20, AdditionalDetails = "Some additional text" };
            room1.Hotel = hotel1;
            var room2 = new Room { Id = short.Parse("2"), Description = "RnR", NoOfRooms = 20, AdditionalDetails = "Some additional text" };
            room2.Hotel = hotel1;
            var room3 = new Room { Id = short.Parse("3"), Description = "Working Suite", NoOfRooms = 20, AdditionalDetails = "Some additional text" };
            room3.Hotel = hotel2;
            var room4 = new Room { Id = short.Parse("4"), Description = "Office Away", NoOfRooms = 20, AdditionalDetails = "Some additional text" };
            room4.Hotel = hotel3;
            var room5 = new Room { Id = short.Parse("5"), Description = "Home Away", NoOfRooms = 20, AdditionalDetails = "Some additional text" };
            room5.Hotel = hotel3;

            //context.Rooms.Add(room1);
            //context.Rooms.Add(room2);
            //context.Rooms.Add(room3);
            //context.Rooms.Add(room4);
            //context.Rooms.Add(room5);


            var reservationID1 = Guid.NewGuid();
            var reservationID2 = Guid.NewGuid();
            var reservationID3 = Guid.NewGuid();
            var reservationID4 = Guid.NewGuid();
            var reservationID5 = Guid.NewGuid();

            var reservation1 = new Reservation { Id = reservationID1, CreatedDate = DateTime.Now, Date = DateTime.Now, ModifiedDate = DateTime.Now, NoOfRooms = 1 };
            reservation1.Status = status1;
            reservation1.Room = room1;
            reservation1.Guest = guest1;

            context.Reservations.Add(reservation1);
            var reservation2 = new Reservation { Id = reservationID2, CreatedDate = DateTime.Now, Date = DateTime.Now, ModifiedDate = DateTime.Now, NoOfRooms = 2 };
            reservation2.Status = status2;
            reservation2.Room = room2;
            reservation2.Guest = guest2;

            context.Reservations.Add(reservation2);

            var reservation3 = new Reservation { Id = reservationID3, CreatedDate = DateTime.Now, Date = DateTime.Now, ModifiedDate = DateTime.Now, NoOfRooms = 1 };
            reservation3.Status = status3;
            reservation3.Room = room3;
            reservation3.Guest = guest3;

            context.Reservations.Add(reservation3);

            var reservation4 = new Reservation { Id = reservationID4, CreatedDate = DateTime.Now, Date = DateTime.Now, ModifiedDate = DateTime.Now, NoOfRooms = 2 };
            reservation4.Status = status4;
            reservation4.Room = room4;
            reservation4.Guest = guest3;

            context.Reservations.Add(reservation4);

            var reservation5 = new Reservation { Id = reservationID5, CreatedDate = DateTime.Now, Date = DateTime.Now, ModifiedDate = DateTime.Now, NoOfRooms = 2 };
            reservation5.Status = status4;
            reservation5.Room = room5;
            reservation5.Guest = guest3;

            context.Reservations.Add(reservation5);
        }
    }
}
