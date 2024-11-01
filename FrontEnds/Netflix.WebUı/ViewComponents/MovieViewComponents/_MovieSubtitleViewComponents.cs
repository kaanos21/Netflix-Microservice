using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Netflix.WebUı.Services.LanguageServices.SubtitlesServices;

namespace Netflix.WebUı.ViewComponents.MovieViewComponents
{
    public class _MovieSubtitleViewComponents:ViewComponent
    {
        private readonly ISubtitleService _subtitleService;

        public _MovieSubtitleViewComponents(ISubtitleService subtitleService)
        {
            _subtitleService = subtitleService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int contentId)
        {
            var values = await _subtitleService.GetSubtitlesWithLanguageByContentId(contentId);
            return View(values);
        }
    }
}
