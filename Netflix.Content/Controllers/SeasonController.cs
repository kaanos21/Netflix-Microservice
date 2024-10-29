using Microsoft.AspNetCore.Mvc;
using Netflix.Content.Dtos.SeasonDto;
using Netflix.Content.Services.SeasonServices;

namespace Netflix.Content.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonController : ControllerBase
    {
        private readonly ISeasonManager _SeasonManager;

        public SeasonController(ISeasonManager SeasonManager)
        {
            _SeasonManager = SeasonManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSeason(CreateSeasonDto createSeasonDto)
        {
            await _SeasonManager.CreateSeasonAsync(createSeasonDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListSeason()
        {
            var value = await _SeasonManager.GetAllSeasonAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSeason(UpdateSeasonDto updateSeasonDto)
        {
            await _SeasonManager.UpdateSeasonAsync(updateSeasonDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdSeason")]
        public async Task<IActionResult> GetByIdSeason(int id)
        {
            var value = await _SeasonManager.GetSeasonByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSeason(int id)
        {
            await _SeasonManager.DeleteSeasonAsync(id);
            return Ok("Silindi");
        }
        [HttpGet("GetListSeasonWithSeriesNameBySeriesId")]
        public async Task<IActionResult> GetListSeasonWithSeriesNameBySeriesId(int id)
        {
            return Ok(await _SeasonManager.GetListSeasonWithSeriesNameBySeriesId(id));
        }
    }
}
