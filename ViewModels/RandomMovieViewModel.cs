using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Udemy_MVC.Models;

namespace Udemy_MVC.ViewModels
{
    public class RandomMovieViewModel
    {
        [Required]
        public List<Movie> Movies { get; set; }
        [Required]
        public List<Customer> Customers { get; set; }

    }
}
