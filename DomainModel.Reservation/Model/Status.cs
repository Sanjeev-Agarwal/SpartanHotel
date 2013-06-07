using System.Collections.Generic;

namespace DomainModel.Reservation.Model
{
    public class Status
    {
        public Status()
        {
            this.Reservations = new List<Reservation>();
        }
    
        public short Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
