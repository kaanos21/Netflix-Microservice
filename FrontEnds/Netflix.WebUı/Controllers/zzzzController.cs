using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.LanguageServices.SubtitlesServices;

namespace Netflix.WebUı.Controllers
{
    public class zzzzController : Controller
    {
        private readonly ISubtitleService _subtitleService;

        public zzzzController(ISubtitleService subtitleService)
        {
            _subtitleService = subtitleService;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _subtitleService.GetSubtitlesWithLanguageByContentId(3);
            return View(value);
        }
    }
}
