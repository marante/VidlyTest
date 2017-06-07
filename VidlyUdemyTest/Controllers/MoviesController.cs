using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyUdemyTest.Models;
using VidlyUdemyTest.ViewModel;

namespace VidlyUdemyTest.Controllers
{
    public class MoviesController : Controller
    {

        // GET: Movies/Index
        public ActionResult Index()
        {

            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Terminator 3" },
                new Movie { Id = 2, Name = "Shrek" },
                new Movie { Id = 3, Name = "Top Gun" },
                new Movie { Id = 4, Name = "Lord of the Rings" },
                new Movie { Id = 5, Name = "Star Wars" }
            };

            return View(movies);
        }

        // GET: Movies/Details/{id}
        public ActionResult Details(int id)
        {
            
        }


    }
}