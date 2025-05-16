using GamesListApp.Web.Services;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace GamesListApp.Web.Attributes
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var gamesService = validationContext.GetService<GamesListService>();
            string name = value as string;

            if (name == null || gamesService == null)
                return ValidationResult.Success;

            if (gamesService.GameNameExists(name))
            {
                return new ValidationResult($"The game name '{name}' must be unique.");
            }

            return ValidationResult.Success;
        }
    }
}
