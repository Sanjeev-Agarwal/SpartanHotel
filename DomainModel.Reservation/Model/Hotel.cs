using System.Collections.Generic;

namespace DomainModel.Reservation.Model
{
    public class Hotel
    {
        public Hotel()
        {
            this.Rooms = new List<Room>();
        }
    
        public short Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
    
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
