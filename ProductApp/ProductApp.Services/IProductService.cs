using ProductApp.Services.Models;
using System;
using System.Collections.Generic;
namespace ProductApp.Services
{
    public interface IProductService
    {
        ProductDTO Get(int id);
        IList<ProductApp.Services.Models.ProductDTO> List();
    }
}
