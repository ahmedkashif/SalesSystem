using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SalesSystem.Areas.Admin.Models
{
     public class Customer
    {
        public int ID { get; set; }

        [Required (ErrorMessage = "Please specify customer name.")]
        [MaxLength (50,ErrorMessage = "Max Length for customer name should not greater than 50")]
        public string CustomerName { get; set; }

        [Required (ErrorMessage = "Please specify NIC.")]
        [MaxLength (18, ErrorMessage = "Max Length for NIC should not greater than 18.")]
        public string NIC { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify Gender.")]
        public Nullable< int> GenderID { get; set; }

        public List<SelectListItem> Genders { get; set; }       

        public static List<Customer> GetList()
        {
            return new List<Customer>
            {
                new Customer {ID=1, CustomerName = "A",  NIC = "11111", GenderID=0 },
                new Customer {ID=2, CustomerName = "B",  NIC = "22222", GenderID=1 },
                //new Customer {ID=3, CustomerName = "C",  NIC = "33333", Gender = new List<SelectListItem> {new SelectListItem { Text ="Male", Value="M", Selected = false } } },
                //new Customer {ID=4, CustomerName = "D",  NIC = "44444", Gender = new List<SelectListItem> {new SelectListItem { Text ="Female", Value="F", Selected = false } } },
                //new Customer {ID=5, CustomerName = "E",  NIC = "55555", Gender = new List<SelectListItem> {new SelectListItem { Text ="", Value="M", Selected = false } } },
                //new Customer {ID=6, CustomerName = "F",  NIC = "66666", Gender = new List<SelectListItem> {new SelectListItem { Text ="Male", Value="M", Selected = false } } },
                //new Customer {ID=7, CustomerName = "G",  NIC = "77777", Gender = new List<SelectListItem> {new SelectListItem { Text ="Female", Value="F", Selected = false } } },
                //new Customer {ID=8, CustomerName = "H",  NIC = "88888", Gender = new List<SelectListItem> {new SelectListItem { Text ="Male", Value="M", Selected = false } } },
                //new Customer {ID=9, CustomerName = "I",  NIC = "99999", Gender = new List<SelectListItem> {new SelectListItem { Text ="Male", Value="M", Selected = false } } },
                //new Customer {ID=10, CustomerName = "J", NIC = "12222", Gender = new List<SelectListItem> {new SelectListItem { Text ="Female", Value="F", Selected = false } } },
                //new Customer {ID=11, CustomerName = "K", NIC = "12223", Gender = new List<SelectListItem> {new SelectListItem { Text ="Female", Value="F", Selected = false } } },
                //new Customer {ID=12, CustomerName = "L", NIC = "12224", Gender = new List<SelectListItem> {new SelectListItem { Text ="Male", Value="M", Selected = false } } },
                //new Customer {ID=13, CustomerName = "M", NIC = "12225", Gender = new List<SelectListItem> {new SelectListItem { Text ="Female", Value="F", Selected = false } } },
                //new Customer {ID=14, CustomerName = "N", NIC = "12226", Gender = new List<SelectListItem> {new SelectListItem { Text ="Female", Value="F", Selected = false } } },
                //new Customer {ID=15, CustomerName = "O", NIC = "12227", Gender = new List<SelectListItem> {new SelectListItem { Text ="Male", Value="M", Selected = false } } }
            };
        }
    }
}