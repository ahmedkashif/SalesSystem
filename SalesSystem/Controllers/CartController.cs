using System.Web.Mvc;

namespace SalesSystem.Controllers
{
    public class CartController : Controller
    {
        public PartialViewResult CartHeader()
        {
            return PartialView();
        }

        public PartialViewResult CartDetails()
        {
            return PartialView();
        }
    }
}