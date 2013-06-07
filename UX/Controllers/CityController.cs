using System.Collections.Generic;
using System.Web.Http;
using API.Models;

namespace UX.Controllers
{
    public class CityController : ApiController
    {
        public IEnumerable<City> GetCities()
        {
            return new[] { new City() };
        }
  
    }
}
