using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SearchingOMDB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SearchingOMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDAL movieDAL = new MovieDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            MovieModel result = movieDAL.GetMovie(title);
            return View(result);
        }
        [HttpPost]
        public IActionResult MovieNight(string title, string title2, string title3)
        {
            MovieModel result1 = movieDAL.GetMovie(title);
            MovieModel result2 = movieDAL.GetMovie(title2);
            MovieModel result3 = movieDAL.GetMovie(title3);
            List<MovieModel> movielist = new List<MovieModel>();
            movielist.Add(result1);
            movielist.Add(result2);
            movielist.Add(result3);
            return View(movielist);
        }

        public IActionResult MovieNight()
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
