
using SalesSystem.Areas.Admin.Models;
using System.Web.Mvc;

namespace SalesSystem.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order
        public ActionResult Index()
        {
                        
            return View(OrderMaster.GetAllOrders());
        }
    }
}