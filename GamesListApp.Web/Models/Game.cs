using System.ComponentModel.DataAnnotations;

namespace GamesListApp.Web.Models
{
    public class Game
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [Range(1958, 2025, ErrorMessage = "Year must be between 1958 and 2025")] //should make own validation attribute
        public int ReleaseYear { get; set; }
        [Range(1, 10, ErrorMessage = "Rating should be between 1 and 10, or be left empty")]
        public int? Rating { get; set; }
    }
}
