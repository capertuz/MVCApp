using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.Ajax.Utilities;


namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == Customer.Unknown | customer.MembershipTypeId == Customer.PayAsYouGo)
            {
                return ValidationResult.Success;    
            }

            if (customer.Birthdate == null)
            {
                return  new ValidationResult("Birhdate is required");
            }

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return(age >=18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to be on a membership");

        }
    }
}