using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;



namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
       
        private ApplicationDbContext _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModels
            {
                Customers = customers,
                Movie = movie

            };
            //This is the first way to pass data to the view
            return View(viewModel); 

            //This is the second way to pass data to the view, using a dictionary, but is fragile not recommended
            //ViewData["Movie"] = movie;
            //return View();


            //we can return different ActionResult objects
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

        }

        public ActionResult Edit(int id)
        {

            return Content("id= " + id);
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


        [Route("movies/released/{year}/{month:range(1,12):regex(\\d{2})}")] //when using regex constraint You need to escape the [] and {} characters in order to use regex
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }

        [Route("Movies")]
        public ActionResult List()
        {

            var moviesList = _context.Movies.Include(m => m.Genre).ToList();

            return View(moviesList);
        }

        [Route("Movies/Details/{id}")]
        public ActionResult Details(int id)
        {

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);

            }

            _context.SaveChanges();

            return RedirectToAction("List");
        }

        public ActionResult New()
        {
            var viewModel = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View("MoviesForm",viewModel);
        }
    }

}