using Microsoft.AspNetCore.Mvc;
using Netflix.Content.Dtos.EpisodeDto;
using Netflix.Content.Services.EpisodeServices;

namespace Netflix.Content.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeManager _EpisodeManager;

        public EpisodeController(IEpisodeManager EpisodeManager)
        {
            _EpisodeManager = EpisodeManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEpisode(CreateEpisodeDto createEpisodeDto)
        {
            await _EpisodeManager.CreateEpisodeAsync(createEpisodeDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListEpisode()
        {
            var value = await _EpisodeManager.GetAllEpisodeAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEpisode(UpdateEpisodeDto updateEpisodeDto)
        {
            await _EpisodeManager.UpdateEpisodeAsync(updateEpisodeDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdEpisode")]
        public async Task<IActionResult> GetByIdEpisode(int id)
        {
            var value = await _EpisodeManager.GetEpisodeByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEpisode(int id)
        {
            await _EpisodeManager.DeleteEpisodeAsync(id);
            return Ok("Silindi");
        }
    }
}
