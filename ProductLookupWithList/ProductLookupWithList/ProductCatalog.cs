using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class ProductCatalog
    {
        List<Product> _items = new List<Product>();


        public ProductCatalog()
        {
            
            _items.Add(new Product { Id = "UB3459456UD",  Name = "Apple", Price = 1.15m});
            _items.Add(new Product { Id = "HYFH982745", Price = 4.99m, Name = "Paper towels" });
            _items.Add(new Product { Name = "banana", Price = .99m, Id = "ABCDEFGHI" });
        }

        public Product Lookup(string id) 
        {
            return _items.FirstOrDefault(p => p.Id == id);
        }
        

        
    }
}
