using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.MovieService.MoviesService;

namespace Netflix.WebUı.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> MovieList()
        {
            var value=await _movieService.GetAllMovieAsync();
            return View(value);
        }
        public async Task<IActionResult> MovieDetail(int id)
        {
            var value = await _movieService.GetMovieByIdAsync(id);
            return View(value);
        }
    }
}
