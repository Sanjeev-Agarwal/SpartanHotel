using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using API.Models;

namespace UX.Controllers
{
    public class SearchRoomController : ApiController
    {
        public IEnumerable<AvailableRoom> GetRooms([FromUri] BookingDetails details)
        {
            //return new[]
            //    {
            //        new AvailableRoom(){ Description = "Minimalist room for the economist traveller.", Name = "Sleep Dorm", Id = "1" }, 
            //        new AvailableRoom(){ Description = "Just the basics - bed and bathroom with shower.", Name = "RnR", Id = "2" }, 
            //        new AvailableRoom(){ Description = "Bedroom with workspace for the business traveller.", Name = "Working Suite", Id = "3" }, 
            //        new AvailableRoom(){ Description = "Private office space with minimalist sleeping quarters.", Name = "Office Away", Id = "4" }, 
            //        new AvailableRoom(){ Description = "Sleeping, living and dining accomodations.", Name = "Home Away", Id = "5" }, 
            //    };
            var criteria = new Runtime.DataContract.Criteria()
                {
                    City = details.CityId.ToString(),
                    FromDate = DateTime.Parse(details.CheckinDate),
                    ToDate = DateTime.Parse(details.CheckoutDate),
                    NoOfRooms = short.Parse(details.NumberOfRooms)
                };

            var domainModel = new Runtime.Engine.SearchEngine();
            var rooms = domainModel.GetRooms(criteria);
            //bulild view model
            var availableRooms = (from r in rooms
                                  select new AvailableRoom()
                                      {
                                          City = r.City,
                                          RoomDescription = r.RoomDescription,
                                          RoomId = r.RoomId
                                      });
            availableRooms = availableRooms.GroupBy(x => x.RoomDescription).Select(g => g.OrderByDescending(rs => rs.RoomId).First()).ToList(); 
            return availableRooms;
        }

    }
}
