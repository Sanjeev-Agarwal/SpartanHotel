using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runtime.Engine;
using Runtime.DataContract;

namespace Runtime.UnitTest
{
    [TestClass]
    public class SearchEngineTest
    {
        [TestMethod]
        public void GetRoomsTest()
        {
            Criteria criteria = new Criteria();
            criteria.City = "";
            criteria.FromDate = DateTime.Now;
            criteria.NoOfRooms = 1;
            criteria.ToDate = DateTime.Now;
            SearchEngine engine = new SearchEngine();
            engine.GetRooms(criteria);
        }
    }
}
