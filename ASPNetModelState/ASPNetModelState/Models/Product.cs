﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetModelState.Models
{
    public class Product
    {
        [Required(ErrorMessage="Product Name is required!!")]
        [MaxLength(20, ErrorMessage= "Product Name is too long!!")]
        [Remote("ValidateProduct", "Product", ErrorMessage="Product Name must be unique!!", HttpMethod="POST")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage="Product price must be greater than 0 and less than 100")]
        public decimal Price { get; set; }
    }
}