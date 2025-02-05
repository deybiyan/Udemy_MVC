using System.ComponentModel.DataAnnotations;

namespace Udemy_MVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        public DateOnly DateAdded { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}
