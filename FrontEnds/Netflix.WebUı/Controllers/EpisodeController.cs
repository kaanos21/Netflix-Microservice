using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.ContentServices.EpisodeServices;

namespace Netflix.WebUı.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IEpisodeService _episodeService;

        public EpisodeController(IHttpClientFactory httpClientFactory, IEpisodeService episodeService)
        {
            _httpClientFactory = httpClientFactory;
            _episodeService = episodeService;
        }

        public async Task<IActionResult> Index()
        {
            var values=await _episodeService.GetAllEpisodeAsync();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> EpisodeList(int id)
        {
            var value=await _episodeService.GetEpisodeListDetail(id);
            return View(value);
        }
    }
}
