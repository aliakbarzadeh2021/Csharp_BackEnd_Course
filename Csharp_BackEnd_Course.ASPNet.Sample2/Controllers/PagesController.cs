using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example5._4._1.Models;

namespace Example5._4._1.Controllers
{
    [Route("mypages")]
    public class PagesController : Controller
    {
        [Route("mygames", Name = "MyGames")]
        public IActionResult Games()
        {
            ViewData["games"] = new List<Game>()
            {
                new Game() { Title = "The Witcher", Genre = "RPG" },
                new Game() { Title = "Need for Speed", Genre = "Racing" },
                new Game() { Title = "Crysis", Genre = "FPS" }
            };
            return View();
        }

        [Route("mymovies", Name = "MyMovies")]
        public IActionResult Movies()
        {
            var movies = new List<Movie>()
            {
                new Movie() { Title = "Star Wars", Ranking = 1 },
                new Movie() { Title = "Inception", Ranking = 2 },
                new Movie() { Title = "Ghost In A Shell", Ranking = 3 }
            };
            return View(movies);
        }
    }
}