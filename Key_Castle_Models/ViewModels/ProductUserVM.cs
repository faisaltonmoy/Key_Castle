using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models.ViewModels
{
    public class ProductUserVM
    {
        public ProductUserVM()
        {
            ProductList = new List<Product>();
        }

        public AppUser AppUser { get; set; }
        public IEnumerable<Product> ProductList { get; set; }
    }
}
