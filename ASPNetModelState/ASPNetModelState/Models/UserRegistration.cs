using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetModelState.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage="First Name is required!!")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Last Name is required!!")]
        [MinLength(5, ErrorMessage="Last Name must be longer the 5 Characters!")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "User Name is required!!")]
        public string UserName { get; set; }
        
        [DataType(DataType.CreditCard)]
        [CreditCard(ErrorMessage="enter valid Credit Card number")]
        [Required(ErrorMessage = "Credit Card is required!!")]
        public int CreditCaard { get; set; }

        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!!")]
        public string Password { get; set; }

        
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Required(ErrorMessage = "Confirm Password is required!!")]
        public string ConfirmPassword { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "SSN is required!!")]
        public int SSN { get; set; }

        [MaxLength(50, ErrorMessage="Comments must be less than 50 characters")]
        public string Comments { get; set; }

    }
}