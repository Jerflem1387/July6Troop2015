using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetTemplates.Models
{
    public class Product
    {
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int Id { get; set; }

        public decimal Weight { get; set; }
    }
}