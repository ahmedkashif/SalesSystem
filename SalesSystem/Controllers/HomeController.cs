
using System.Web.Mvc;

namespace SalesSystem.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }     

        public PartialViewResult LowerHeader()
        {
            return PartialView();
        }

        public PartialViewResult NavigationBar()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult Copyright()
        {
            return PartialView();
        }

        public PartialViewResult WelcomePanel()
        {
            return PartialView();
        }

        public PartialViewResult BookingOptions()
        {
            return PartialView();
        }
    }
}