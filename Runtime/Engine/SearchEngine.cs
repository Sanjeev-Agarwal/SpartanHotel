using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Search;
using DomainModel.Search.Model;
using Runtime.DataContract;

namespace Runtime.Engine
{
    public class SearchEngine
    {
        public  SearchEngine()
        {

        }

        public IList<RoomAvailability> GetRooms(Criteria criteria)
        {
            return DbAccess.GetRooms(criteria);
        }

    }
}
