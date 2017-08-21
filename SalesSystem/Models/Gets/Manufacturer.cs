// Get
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.Models
{
    public partial class Manufacturer
    {
        public IEnumerable<Manufacturer> GetManufacturersBy(int ?manufacturerID)
        {
            if(manufacturerID == 0 || manufacturerID == null)
            {
                return List();
            }
            else
            {
                return List().Where(m => m.ID == manufacturerID).Select(m => m);
            }
        }

        public static List<Manufacturer> List()
        {
            return new List<Manufacturer>()
            {
                new Manufacturer {ID = 1, Name = "Manufacturer1" },
                new Manufacturer {ID = 2, Name = "Manufacturer2" }                
            };
        }
    }
}