using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsToBeMembership : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown
                || customer.MembershipTypeId == MembershipType.PayAsYouGo) return ValidationResult.Success;

            if (customer.Birthday == null) return new ValidationResult("Birthday is required.");

            return DateTime.Now.Year - customer.Birthday.Value.Year >= 18
                ? ValidationResult.Success
                : new ValidationResult("Membership must be older than 18 years.");
        }
    }
}