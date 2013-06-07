using System.Collections.Generic;

namespace DomainModel.Reservation.Model
{
    public class Room
    {
        public Room()
        {
            this.Reservations = new List<Reservation>();
        }
    
        public short Id { get; set; }
        public string Description { get; set; }
        public short NoOfRooms { get; set; }
        public string AdditionalDetails { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
