using System;

namespace DomainModel.Search.Model
{
    public class RoomAvailability
    {
        public int Id { get; set; }
        public string RoomDescription { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public short RoomId { get; set; }
        public short NoofAvailableRooms { get; set; }
        public DateTime LastRefreshed { get; set; }
    }
}
