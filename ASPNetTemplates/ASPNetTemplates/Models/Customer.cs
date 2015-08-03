using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetTemplates.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public uint PhoneNumber { get; set; }
        public int Id { get; set; }


    }
}