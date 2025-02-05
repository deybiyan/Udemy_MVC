using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Udemy_MVC.Models;
using Udemy_MVC.ViewModels;


namespace Udemy_MVC.Controllers
{
    //Controller class
    public class MoviesController : Controller
    {
        // GET: Movies/
        private AppDbContext _context;

        public MoviesController(AppDbContext context) => _context = context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        private IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
        public ActionResult Index()
        {
            var movies = GetMovies();

            var viewmodel = new RandomMovieViewModel
            {
                Movies = (List<Movie>) movies
            };

            return View(viewmodel);

        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return NotFound();
            };

            return View(movie);
        }


    }
}