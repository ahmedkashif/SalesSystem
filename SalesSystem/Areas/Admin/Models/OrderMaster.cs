using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Areas.Admin.Models
{
    public class OrderMaster
    { 
        
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public static IEnumerable<OrderMaster> GetAllOrders()
        {
            return new List<OrderMaster>
            {
                new OrderMaster { CustomerID = 1, OrderDate = DateTime.Now, OrderNo = "1111" },
                new OrderMaster { CustomerID = 2, OrderDate = DateTime.Now, OrderNo = "2222" }
            };
        }

    }
}