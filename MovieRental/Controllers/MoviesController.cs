using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrek!"};

            var customers = new List<Customer>()
            {
                new Customer { Name = "Johne"},
                new Customer { Name = "Anna"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //ViewData["RandomMovieD"] = movie;

            //ViewBag.RandomMovieB = movie;

            //ViewData["RandomMoviesD"] = "Shrak (string from ViewData)";

            //ViewBag.RandomMoviesB = "Shrak (string from ViewBag)";

        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+ month);
        }

    }
}