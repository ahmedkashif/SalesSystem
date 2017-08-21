using System.Collections.Generic;
using System.Linq;
// Gets
namespace SalesSystem.Models
{
    public partial class Product
    {
        public IEnumerable<Product> GetProductBy(int ?categoryID)
        {
            if (categoryID == null || categoryID == 0)
            {
                return List();                
            }
            else
            {
                return List().Where(c => c.categoryID == categoryID).Select(p => p);
            }
        }

        public IEnumerable<Manufacturer> GetManufacturersByCategoryID(int? categoryID)
        {
            IEnumerable<Manufacturer> manufacturerList = Manufacturer.List();

            IEnumerable<Manufacturer> manufacturers = (IEnumerable<Manufacturer>)List().
                    Where(p => p.categoryID == categoryID ||
                                categoryID == 0 ||
                                categoryID == null).Join(manufacturerList,
                    p => p.manufacturerID,
                    m => m.ID,
                    (prod, manu) =>
                    new Manufacturer
                    {
                        ID = manu.ID,
                        Name = manu.Name
                    }).GroupBy(manu => manu.ID).Select(m => m.First());

            //

            return manufacturers;
        }

        public IEnumerable<Product> GetProductByManufacturerCategoryID(int? categoryID, int? manufacturerID)
        {
            return List().Where(p => (p.categoryID == categoryID || categoryID == 0 || categoryID == null)
                               && (p.manufacturerID == manufacturerID || manufacturerID == null || manufacturerID == 0)).Select(p => p);            
        }

        public Product GetProduct(int? productID)
        {
            return List().Where(p => p.ID == productID).SingleOrDefault();
        }

        public static List<Product> List()
        {
            return new List<Product> {
                new Product {ID=1, manufacturerID = 1, categoryID = 1, Name="Rice", Rate=1.0},
                new Product {ID=2, manufacturerID = 1, categoryID = 2, Name="Rass barry", Rate=2.0},
                new Product {ID=3, manufacturerID = 2, categoryID = 1, Name="Palao", Rate=3.0},
                new Product {ID=4, manufacturerID = 2, categoryID = 2, Name="Mango", Rate=4.0}
            };
        }
    }
}