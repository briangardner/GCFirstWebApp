using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestFirstWebApp.Validators;

namespace TestFirstWebApp.Models
{
    public class User
    {
        [MinLength(2)]
        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        [RegularExpression("\\D+", ErrorMessage = "Cannot have digits")]
        public string FirstName { get; set; }

        [MinLength(2)]
        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        [RegularExpression("\\D+", ErrorMessage = "Cannot have digits")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [CustomEmail]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [MinLength(6)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string FavoriteCoffee { get; set; }
    }
}