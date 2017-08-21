

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using SalesSystem.Models;
using SalesSystem.Areas.Admin.Models;
using SalesSystem.Areas.Admin.Models.ViewModels;


namespace SalesSystem.Areas.Admin.Controllers
{
    public class CustomerController : Controller
    {

        const int PAGESIZE = 5;
        // GET: Admin/Customer
        public ActionResult Index(int page=1)
        {
            IList<Customer> customers = Customer.GetList();

            CustomerListViewModel customersViewModel = new CustomerListViewModel

            {
                Customers = customers.Skip((page - 1) * 5 ).Take(PAGESIZE),
                pagingInfo = new PagingInfo()
                {
                    TotalItems = customers.Count,
                    ItemsPerPage = PAGESIZE,
                    CurrentPage = page
                }

            };

            return View(customersViewModel);
        }

        public ActionResult Create()
        {
            Customer customer = new Customer();

            List<SelectListItem> genders = new List<SelectListItem>();
            //genders.Add(new SelectListItem { Text = "please select..", Value = "",  });
            genders.Add(new SelectListItem { Text = "Male", Value = "0", Selected = true });
            genders.Add(new SelectListItem { Text = "Female", Value = "1", Selected = false });
            customer.GenderID = 0;
            customer.Genders = genders;
            customer.CustomerName = "please specify your name.";

           return View(customer);
        }

        public ActionResult Detail(int id)
        {
            Customer customer = Customer.GetList().Where(x => x.ID == id).SingleOrDefault(); 

            if(customer != null)
            {
                return View(customer);
            }

            TempData["Message"] = "Record not found";

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Customer customer = Customer.GetList().Where(x => x.ID == id).SingleOrDefault();

            if (customer != null)
            {
                return View(customer);
            }

            TempData["Message"] = "Record not found";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            Customer editCustomer = Customer.GetList().Where(x => x.ID == customer.ID).SingleOrDefault();

            if (customer != null)
            {
                TempData["Message"] = "Record has been updated.";

                return RedirectToAction("Index");                
            }

            TempData["Message"] = "Record not found";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            List<Customer> customers = Customer.GetList();

            if (ModelState.IsValid)
            {
                Customer newCustomer = new Models.Customer();
                newCustomer.ID = customers.Count + 1;
                newCustomer.CustomerName = customer.CustomerName;
                newCustomer.NIC = customer.NIC;
                newCustomer.GenderID = customer.GenderID;
                customers.Add(newCustomer);
                return RedirectToAction(actionName: "Index", controllerName: "Customer", routeValues: null);
            }
            else
            {
                Customer customer1 = new Customer();

                List<SelectListItem> genders = new List<SelectListItem>();
                //genders.Add(new SelectListItem { Text = "please select..", Value = "",  });
                genders.Add(new SelectListItem { Text = "Male", Value = "0", Selected = true });
                genders.Add(new SelectListItem { Text = "Female", Value = "1", Selected = false });
                customer1.GenderID = 0;
                customer1.Genders = genders;
                customer1.CustomerName = "please specify your name.";

                return View(customer1);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Customer deleteCustomer = Customer.GetList().Where(x => x.ID == id).SingleOrDefault();

            if(deleteCustomer != null)
            {
                Customer.GetList().Remove(deleteCustomer);
                TempData["Message"] = "Record has been deleted";
                return RedirectToAction(actionName: "Index", controllerName: "Customer");
            }

            TempData["Message"] = "Record not found";
            return View();
        }
    }
}