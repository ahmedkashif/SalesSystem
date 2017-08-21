using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Models
{
    public partial class Product
    {
        public int ID { get; set; }

        public int categoryID { get; set; }

        public int manufacturerID { get; set; }

        [Required  ( ErrorMessage ="Please enter Product Name.")] 
        [MaxLength (50, ErrorMessage ="Product name should not greater than 50.")]      
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Product Rate.")]
        [Range (0.1, double.MaxValue, ErrorMessage = "Please enter valid a positive rate.")]
        public double Rate { get; set; }        
    }

    public class RequiredAndMaxLength : ValidationAttribute
    {

    }
    
}