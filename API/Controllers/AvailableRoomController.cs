using System.Collections.Generic;
using System.Web.Http;
using API.Models;

namespace API.Controllers
{
    public class AvailableRoomController : ApiController
    {
        public IEnumerable<AvailableRoom> GetAllRooms()
        {
            return new[]
                {
                    new AvailableRoom(){ RoomDescription = "Minimalist room for the economist traveller.", City = "Sleep Dorm", Id = 1 }, 
                    new AvailableRoom(){ RoomDescription = "Just the basics - bed and bathroom with shower.", City = "RnR", Id = 2 }, 
                    new AvailableRoom(){ RoomDescription = "Bedroom with workspace for the business traveller.", City = "Working Suite", Id = 3 }, 
                    new AvailableRoom(){ RoomDescription = "Private office space with minimalist sleeping quarters.", City = "Office Away", Id = 4 }, 
                    new AvailableRoom(){ RoomDescription = "Sleeping, living and dining accomodations.", City = "Home Away", Id = 5 }, 
                };
        }
   }
}
