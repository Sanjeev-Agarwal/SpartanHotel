using System.Data.Entity;
using DomainModel.Search.Model;

namespace DomainModel.Search.Context
{
    public class SearchModelContext: DbContext 
    {
        public DbSet<RoomAvailability> RoomAvailabilities { get; set; } 
        

    }
}

