
using System.Web.Mvc;
using SalesSystem.Models;
using System.Linq;
using PagedList;

namespace SalesSystem.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        const int PAGE_SIZE = 3;
       
        //public ActionResult List(int? page)
        //{
        //    int pageNumber = page ?? 1;

        //    return  View( model: Product.List().ToPagedList(pageNumber, PAGE_SIZE));
        //}

        public ActionResult List(int page=1)
        {
            //return View(model: Product.List());

            ProductListViewModel model = new ProductListViewModel
            {
                Products = Product.List()                      
                       .OrderBy(p => p.ID)
                       .Skip((page - 1) * PAGE_SIZE)
                       .Take(PAGE_SIZE),
                pagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PAGE_SIZE,
                    TotalItems = (Product.List().Count())
                },
                
            };
            return View(model);
        }

        public ActionResult Edit(int ID)
        {            
            Product product = Product.List().Where(x => x.ID == ID).SingleOrDefault();
            return View(model: product);
        }

        [HttpGet]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                Product p = new Product();
                p.Name = product.Name;
                p.Rate = product.Rate;
                p.ID = Product.List().Count + 1;
                Product.List().Add(p);
                return View(viewName: "List", model: Product.List());
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            return View();
        }
    }
}