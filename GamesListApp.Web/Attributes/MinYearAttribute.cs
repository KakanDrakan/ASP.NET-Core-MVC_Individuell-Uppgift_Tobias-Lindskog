using System.ComponentModel.DataAnnotations;

namespace GamesListApp.Web.Attributes
{
    public class MinYearAttribute(int minYear): ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int currentYear = DateTime.Now.Year;
            if (value is int year)
            {
                if (year <= minYear)
                {
                  return new ValidationResult($"The year must be after {minYear}.");  
                }
                if (year > currentYear)
                {
                    return new ValidationResult($"The year cannot be in the future. The current year is {currentYear}.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
