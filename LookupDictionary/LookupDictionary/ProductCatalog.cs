using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupDictionary
{    
    class ProductCatalog
    {
        Dictionary<int, Products> _products = new Dictionary<int, Products>();
        
        public ProductCatalog()
        {
            _products.Add(01, new Products { Price = 1.99m, Name = "Apple", Id = 01 });
            _products.Add(02, new Products { Price = 2.99m, Name = "Paper", Id = 02 });
            _products.Add(03, new Products { Price = 4.39m, Name = "409", Id = 03 });
        }
        public Products Lookup(int id)
        {
            return _products[id];
        }
    }
}
