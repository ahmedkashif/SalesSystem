using SalesSystem.Models;
using System.Web.Mvc;

namespace SalesSystem.Views
{
    public class CategoryController : Controller
    {
        [ChildActionOnly]
        public PartialViewResult Menus()
        {
            return PartialView (Category.GetCategories());
        }
    }
}