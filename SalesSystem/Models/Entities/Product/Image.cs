
namespace SalesSystem.Models
{
    public partial class Image
    { 
        public int ID { get; set; }
        public int productID { get; set; }
        public string FileName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }

    }
}