
using System.Web.Mvc;

namespace SalesSystem.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public PartialViewResult List()
        {
            return PartialView();
        }
    }
}