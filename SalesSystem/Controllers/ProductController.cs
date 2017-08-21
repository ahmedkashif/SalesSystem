using System.Web.Mvc;
using SalesSystem.Models;
using System.Collections.Generic;
using SalesSystem.ViewModel;

namespace SalesSystem.Controllers
{
    public class ProductController : Controller
    {
        Product product = new Product();

        public ProductController()
        {

        }

        // GET: Product
        public PartialViewResult ProductMenus()
        {   
            return PartialView(model: Product.List());
        }

        public PartialViewResult TopPurchasedProductsByCategory()
        {
            return PartialView();
        }

        public PartialViewResult NewProducts()
        {
            return PartialView();
        }

        public PartialViewResult FeaturedProducts()
        {
            return PartialView();
        }

        public PartialViewResult PopularProducts()
        {
            return PartialView();
        }

        public PartialViewResult BestSellingProducts()
        {
            return PartialView(Product.List());
        }

        [ChildActionOnly]
        public PartialViewResult ProductView(int? categoryID, int ?manufacturerID)
        {               
            return PartialView(product.GetProductByManufacturerCategoryID(categoryID, manufacturerID));
        }

        public ActionResult ProductList(int? categoryID)
        {
            // string ViewName = "ProductListBy";  
            
            string ViewName = "List";

            ManufacturerProductViewModel vmManufacturerProduct = new ManufacturerProductViewModel();             

            return View(ViewName, vmManufacturerProduct.GetByCategoryID(categoryID));
        }

        public ActionResult Details(int? productID)
        {            
            return View(product.GetProduct(productID));
        }

        [ChildActionOnly]
        public PartialViewResult ImageSlider(int ?productID)
        {
            return PartialView(new Image().GetImagesBy(productID));
        }

        //public ActionResult List()
        //{
        //    return View(model: Product.List());
        //}

        //public ActionResult Edit(int ID)
        //{
        //    var product = Product.List().Where(x => x.ID == ID);
        //    return View(model: product);
        //}
    }
}