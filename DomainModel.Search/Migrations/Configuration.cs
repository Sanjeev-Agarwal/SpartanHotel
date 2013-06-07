using System.Collections.Generic;
using DomainModel.Search.Model;

namespace DomainModel.Search.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DomainModel.Search.Context.SearchModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DomainModel.Search.Context.SearchModelContext context)
        {
            ////  This method will be called after migrating to the latest version.

            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data. E.g.
            ////
            //var rooms = new List<Model.RoomAvailability>();
            //for (short i = 0; i < 90; i++)
            //{
            //    rooms.Add(new RoomAvailability() { City = "Taj XYZ Bangalore", Date = DateTime.Now.Date.AddDays(i), Id = i + 1, LastRefreshed = DateTime.Now, RoomDescription = "Test descriptiuon data" + i + 1, RoomId = i, NoofAvailableRooms = 2 });
            //}
            //context.RoomAvailabilities.AddRange(rooms.ToList());

            for (int i = 0; i < 90; i++)
            {
                var roomAvailableList = new List<RoomAvailability>
                    {

                        new RoomAvailability
                            {
                                RoomDescription = "Sleep Dorm",
                                City = "Bangalore",
                                Date = DateTime.Now.Date.AddDays(i),
                                RoomId = 1,
                                NoofAvailableRooms = 20,
                                LastRefreshed = DateTime.Now
                            },
                        new RoomAvailability
                            {
                                RoomDescription = "RnR",
                                City = "Bangalore",
                                Date = DateTime.Now.Date.AddDays(i),
                                RoomId = 2,
                                NoofAvailableRooms = 20,
                                LastRefreshed = DateTime.Now
                            },
                        new RoomAvailability
                            {
                                RoomDescription = "Working Suite",
                                City = "Bangalore",
                                Date = DateTime.Now.Date.AddDays(i),
                                RoomId = 3,
                                NoofAvailableRooms = 20,
                                LastRefreshed = DateTime.Now
                            },
                        new RoomAvailability
                            {
                                RoomDescription = "Office Away",
                                City = "Bangalore",
                                Date = DateTime.Now.Date.AddDays(i),
                                RoomId = 4,
                                NoofAvailableRooms = 20,
                                LastRefreshed = DateTime.Now
                            },
                        new RoomAvailability
                            {
                                RoomDescription = "Home Away",
                                City = "Bangalore",
                                Date = DateTime.Now.Date.AddDays(i),
                                RoomId = 5,
                                NoofAvailableRooms = 20,
                                LastRefreshed = DateTime.Now
                            }
                    };
                roomAvailableList.ForEach(m => context.RoomAvailabilities.AddOrUpdate(m));
            }
        }
    }
}
