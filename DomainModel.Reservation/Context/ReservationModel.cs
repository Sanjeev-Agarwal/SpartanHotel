using System.Data.Entity;
using DomainModel.Reservation.Model;

namespace DomainModel.Reservation.Context
{
    public class ReservationModelContext : DbContext 
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Model.Reservation> Reservations { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
