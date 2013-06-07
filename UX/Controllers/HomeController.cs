using System.Web.Mvc;
using UX.Models;

namespace UX.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new HomeViewModel
                {
                    Title = "Spartan Hotels",
                    ConvincingMarketingWords = "Spartan Hotels - Everything to need, nothing you don't.  We need to hire a Marketing Firm.  And a UI Designer . . . this is pretty sad looking.",
                    Splash = "Welcome to Spartan Hotels"
                };
            return View(model);
        }

    }
}
