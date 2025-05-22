using GamesListApp.Web.Attributes;
using System.ComponentModel.DataAnnotations;

namespace GamesListApp.Web.Views.GamesList
{
    public class CreateVM
    {
        [Required]
        [UniqueName(ErrorMessage = "A game with that exact name has already been added")]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [MinYear(1958)]
        public int ReleaseYear { get; set; }
        [Range(1, 10, ErrorMessage = "Rating should be between 1 and 10, or be left empty")]
        public int? Rating { get; set; }
    }
}
