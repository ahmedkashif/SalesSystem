using System.Collections;
using System.Collections.Generic;

// Gets functionality.

namespace SalesSystem.Models
{
    public partial class Category
    {
        
        public void Save()
        {
            
        }

        public static IEnumerable<Category> GetCategories()
        {
            return new List<Category>() {
                new Category() { ID = 1, Name = "Rice" },
                new Category() { ID = 2, Name = "Sweat" },                
                new Category() { ID = 0, Name = "See All" }
            };
        }
    }
}