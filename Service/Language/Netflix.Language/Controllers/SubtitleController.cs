using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Netflix.Language.Dtos.SubtitleDtos;
using Netflix.Subtitle.Services.SubtitleService;

namespace Netflix.Subtitle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtitleController : ControllerBase
    {
        private readonly ISubtitleService _SubtitleManager;

        public SubtitleController(ISubtitleService SubtitleManager)
        {
            _SubtitleManager = SubtitleManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubtitle(CreateSubtitleDto createSubtitleDto)
        {
            await _SubtitleManager.CreateSubtitleAsync(createSubtitleDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListSubtitle()
        {
            var value = await _SubtitleManager.GetAllSubtitleAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubtitle(UpdateSubtitleDto updateSubtitleDto)
        {
            await _SubtitleManager.UpdateSubtitleAsync(updateSubtitleDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdSubtitle")]
        public async Task<IActionResult> GetByIdSubtitle(int id)
        {
            var value = await _SubtitleManager.GetSubtitleByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSubtitle(int id)
        {
            await _SubtitleManager.DeleteSubtitleAsync(id);
            return Ok("Silindi");
        }
        [HttpGet("GetSubtitlesWithLanguageByContentId")]
        public async Task<IActionResult> GetSubtitlesWithLanguageByContentId(int contentId)
        {
            var value=await _SubtitleManager.GetSubtitlesWithLanguageByContentId(contentId);
            return Ok(value);
        }
    }
}
