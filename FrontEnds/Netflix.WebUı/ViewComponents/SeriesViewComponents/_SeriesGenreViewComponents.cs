using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.GenreServices.GenreMappingServices;

namespace Netflix.WebUı.ViewComponents.SeriesViewComponents
{
    public class _SeriesGenreViewComponents:ViewComponent
    {
        private readonly IGenreMappingService _genreMappingService;

        public _SeriesGenreViewComponents(IGenreMappingService genreMappingService)
        {
            _genreMappingService = genreMappingService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int contentId)
        {
            var value = await _genreMappingService.GetGenreListWithGenreNameByContentId(contentId);
            return View(value);
        }
    }
}
