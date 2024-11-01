using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix.Genre.Dtos.GenreMappingDtos;
using Netflix.GenreMapping.Services.GenreMappingMappingServices;

namespace Netflix.GenreMapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreMappingController : ControllerBase
    {
        private readonly IGenreMappingMappingManager _GenreMappingsManager;

        public GenreMappingController(IGenreMappingMappingManager GenreMappingsManager)
        {
            _GenreMappingsManager = GenreMappingsManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateGenreMappings(CreateGenreMappingDto createGenreMappingsDto)
        {
            await _GenreMappingsManager.CreateGenreMappingAsync(createGenreMappingsDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListGenreMappings()
        {
            var value = await _GenreMappingsManager.GetAllGenreMappingAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGenreMappings(UpdateGenreMappingDto updateGenreMappingsDto)
        {
            await _GenreMappingsManager.UpdateGenreMappingAsync(updateGenreMappingsDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdGenreMappings")]
        public async Task<IActionResult> GetByIdGenreMappings(int id)
        {
            var value = await _GenreMappingsManager.GetGenreMappingByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteGenreMappings(int id)
        {
            await _GenreMappingsManager.DeleteGenreMappingAsync(id);
            return Ok("Silindi");
        }
        [HttpGet("GetGenreListWithGenreNameByContentId")]
        public async Task<IActionResult> GetGenreListWithGenreNameByContentId(int contentId)
        {
           var value= await _GenreMappingsManager.GetGenreListWithGenreNameByContentId(contentId);
            return Ok(value);
        }
    }
}
