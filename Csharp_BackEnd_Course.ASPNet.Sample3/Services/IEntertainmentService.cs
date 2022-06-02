using Example5._5._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example5._5._1.Services
{
    public interface IEntertainmentService
    {
        IEnumerable<Game> GetGames();
        IEnumerable<Movie> GetMovies();
    }
}
