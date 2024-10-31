using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.LanguageServices.SubtitlesServices;

namespace Netflix.WebUı.ViewComponents.EpisodeViewComponents
{
    public class _EpisodeSubtitleViewComponents:ViewComponent
    {
        private readonly ISubtitleService _subtitleService;

        public _EpisodeSubtitleViewComponents(ISubtitleService subtitleService)
        {
            _subtitleService = subtitleService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int contentId)
        {
            contentId =3;
            var values = await _subtitleService.GetSubtitlesWithLanguageByContentId(contentId);
            return View(values);
        }
    }
}
