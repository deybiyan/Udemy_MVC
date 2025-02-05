using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Udemy_MVC.Models;
using Udemy_MVC.ViewModels;



namespace Udemy_MVC.Controllers
{
    public class CustomersController : Controller
    {
        private AppDbContext _context;

        public CustomersController(AppDbContext context) => _context = context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // Main List of Customers
        private IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.Include(c => c.MembershipType).ToList();
        }
        public IActionResult Index()
        {
            var customers = GetCustomers();

            var viewmodel = new RandomMovieViewModel
            {
                Customers = (List<Customer>)customers
            };
                     
            return View(viewmodel);
            
        }

        public IActionResult Details(int id)
        {



            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null) 
            {
                return NotFound();
            };

            return View(customer);
        }
    }
}
