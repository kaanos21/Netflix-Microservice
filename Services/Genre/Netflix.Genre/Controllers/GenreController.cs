using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix.Genre.Dtos.GenresDtos;
using Netflix.Genre.Services.GenresServices;

namespace Netflix.Genre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenresManager _GenresManager;

        public GenreController(IGenresManager GenresManager)
        {
            _GenresManager = GenresManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateGenres(CreateGenresDto createGenresDto)
        {
            await _GenresManager.CreateGenreAsync(createGenresDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListGenres()
        {
            var value = await _GenresManager.GetAllGenreAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGenres(UpdateGenresDto updateGenresDto)
        {
            await _GenresManager.UpdateGenreAsync(updateGenresDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdGenres")]
        public async Task<IActionResult> GetByIdGenres(int id)
        {
            var value = await _GenresManager.GetGenreByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteGenres(int id)
        {
            await _GenresManager.DeleteGenreAsync(id);
            return Ok("Silindi");
        }
    }
}
