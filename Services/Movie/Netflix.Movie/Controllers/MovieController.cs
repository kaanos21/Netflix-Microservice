using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix.Movie.Dtos.MoviesDtos;
using Netflix.Movie.Services.MovieServices;

namespace Netflix.Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieManager _MovieManager;

        public MovieController(IMovieManager MovieManager)
        {
            _MovieManager = MovieManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieDto createMovieDto)
        {
            await _MovieManager.CreateMovieAsync(createMovieDto);
            return Ok("başarı ile eklendi");
        }



        [HttpGet]
        public async Task<IActionResult> GetListMovie()
        {
            var value = await _MovieManager.GetAllMovieAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMovie(UpdateMovieDto updateMovieDto)
        {
            await _MovieManager.UpdateMovieAsync(updateMovieDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdMovie")]
        public async Task<IActionResult> GetByIdMovie(int id)
        {
            var value = await _MovieManager.GetMovieByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _MovieManager.DeleteMovieAsync(id);
            return Ok("Silindi");
        }
    }
}
