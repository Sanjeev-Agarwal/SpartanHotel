using System.Web.Mvc;

namespace UX.Controllers
{
    public class BookingCentralController : Controller
    {

        public ActionResult Index()
        {
            var model = new Models.InitialBookingViewModel
                {
                    BookingIntroduction =
                        "Welcome to Spartan's online room reservation system.  To researve a room, simply select a city, dates, the number of adults and click the 'show available rooms' button.",
                    Splash = "Room Reservations",
                    Title = "Spartan's Online Room Reservation System",
                };
            return View(model);
        }

    }
}
