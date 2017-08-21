
using SalesSystem.Models;
using System.Collections.Generic;

namespace SalesSystem.Areas.Admin.Models.ViewModels
{
    public class CustomerListViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public PagingInfo pagingInfo { get; set; }
    }
}