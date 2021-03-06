﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace TestFirstWebApp.Validators
{
    public class CustomEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = value.ToString();
            var emailRegex = new Regex("\\w+@\\w+.\\w");

            var isValidEmail = emailRegex.IsMatch(email);
            if(isValidEmail)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("This is an invalid email address.");
            }
            
        }
    }
}