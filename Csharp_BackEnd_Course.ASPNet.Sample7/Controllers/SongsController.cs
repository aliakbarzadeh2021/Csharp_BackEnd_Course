using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example6._2._1.Services;
using Example6._2._1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Example6._2._1.Controllers
{
    public class SongsController : Controller
    {
        private ISongsService _songsService;

        public SongsController(ISongsService songsService)
        {
            _songsService = songsService;
        }
                
        [Route("songs/all")]
        public async Task<IActionResult> Index()
        {
            return View(await _songsService.GetAllAsync());
        }

        [Route("songs/new")]
        public IActionResult NewSongForm()
        {
            return View("Form");
        }

        [Route("songs/add")]
        public async Task<IActionResult> Add(Song song)
        {
            await _songsService.CreateAsync(song);
            return RedirectToAction("Index");
        }
    }
}
