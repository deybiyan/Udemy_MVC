using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Udemy_MVC.Models;
using Udemy_MVC.ViewModels;

namespace Udemy_MVC.Controllers
{
    public class HomeController : Controller

        
    {
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string testCommit { get; set; }
        public IActionResult Index()


        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
