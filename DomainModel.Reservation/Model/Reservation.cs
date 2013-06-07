
using System;

namespace DomainModel.Reservation.Model
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public short NoOfRooms { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
        public virtual Status Status { get; set; }
    }
}
