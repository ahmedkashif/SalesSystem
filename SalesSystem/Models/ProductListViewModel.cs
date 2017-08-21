

using System.Collections.Generic;

namespace SalesSystem.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo pagingInfo { get; set; }

        
    }
}