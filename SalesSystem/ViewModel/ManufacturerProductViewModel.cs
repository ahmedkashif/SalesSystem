using SalesSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.ViewModel
{
    public class ManufacturerProductViewModel
    {
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public ManufacturerProductViewModel GetByCategoryID(int? categoryID)
        {
            ManufacturerProductViewModel model = Product.List().Where(p => p.categoryID == categoryID).GroupJoin( Manufacturer.List(),
              p => p.manufacturerID,
              m => m.ID,
              (prod, manu) =>
              new ManufacturerProductViewModel
              {
                  Manufacturers = (IEnumerable<Manufacturer>) manu,
                  Products = (IEnumerable<Product>) prod
              }).SingleOrDefault();

            return model;
        }
    }
}