using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Customers")]
        public ActionResult Customers()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer {Name = "John Cleese", Id=1},
                new Customer {Name = "Cindy Mayes", Id=2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{customerId}")]
        public ActionResult CustomerDetail(int customerId)
        {
            //ViewBag.Message = "Here goes the customer detail";
            return Content(customerId + "");
        }

        [Route("Movies")]
        public ActionResult Movies()
        {
            return View();
        }






    }
}