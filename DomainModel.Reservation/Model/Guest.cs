
using System;
using System.Collections.Generic;

namespace DomainModel.Reservation.Model
{
    public class Guest
    {
        public Guest()
        {
            this.Reservations = new List<Reservation>();
        }
    
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
