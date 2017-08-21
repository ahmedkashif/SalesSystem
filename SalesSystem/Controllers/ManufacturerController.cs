using SalesSystem.Models;
using System.Web.Mvc;

namespace SalesSystem.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: Manufacturer
        public PartialViewResult List()
        {
            return PartialView(new Manufacturer().GetManufacturersBy(null));
        }

        
        public ActionResult ManufacturerListByCategoryID(int ?categoryID)
        {
            Product product = new Product();            

            TempData["categoryID"] = categoryID;            

            return View(product.GetManufacturersByCategoryID(categoryID));
        }
    }
}