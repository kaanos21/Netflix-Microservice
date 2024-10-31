using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix.Language.Dtos.LanguageDtos;
using Netflix.Language.Services.LanguageService;

namespace Netflix.Language.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService _LanguageManager;

        public LanguageController(ILanguageService LanguageManager)
        {
            _LanguageManager = LanguageManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateLanguage(CreateLanguagesDto createLanguageDto)
        {
            await _LanguageManager.CreateLanguageAsync(createLanguageDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListLanguage()
        {
            var value = await _LanguageManager.GetAllLanguageAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLanguage(UpdateLanguagesDto updateLanguageDto)
        {
            await _LanguageManager.UpdateLanguageAsync(updateLanguageDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdLanguage")]
        public async Task<IActionResult> GetByIdLanguage(int id)
        {
            var value = await _LanguageManager.GetLanguageByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteLanguage(int id)
        {
            await _LanguageManager.DeleteLanguageAsync(id);
            return Ok("Silindi");
        }
    }
}
