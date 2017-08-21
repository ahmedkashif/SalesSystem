
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.Models
{
    public partial class Image
    {
        public IEnumerable<Image> GetImagesBy(int ?productID)
        {            
            return List().Where(i => i.productID == productID).Select (i => i); ;
        }

        private IEnumerable<Image> List()
        {
            return new List<Image>()
            {
                new Image() { ID = 1, productID = 1,  FileName = "a.jpg",  Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 2, productID = 1,  FileName = "a1.jpg", Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 3, productID = 1,  FileName = "a2.jpg", Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 4, productID = 1,  FileName = "a3.jpg", Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 5, productID = 2,  FileName = "b.jpg",  Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 6, productID = 2,  FileName = "b1.jpg", Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 7, productID = 2,  FileName = "b2.jpg", Width = 276, Height = 357,Size = 52  },
                new Image() { ID = 8, productID = 2,  FileName = "b3.jpg", Width = 276, Height = 357,Size = 52  }
            };
        }
    }
}