using Microsoft.CodeAnalysis.Host;
using Netflix.WebUı.Services.CommentServices.CommentsServices;
using Netflix.WebUı.Services.ContentServices.EpisodeServices;
using Netflix.WebUı.Services.ContentServices.SeasonService;
using Netflix.WebUı.Services.ContentServices.SeriesServices;
using Netflix.WebUı.Services.GenreServices.GenreMappingServices;
using Netflix.WebUı.Services.GenreServices.GenreServicess;
using Netflix.WebUı.Services.LanguageServices.LanguagesServices;
using Netflix.WebUı.Services.LanguageServices.SubtitlesServices;
using Netflix.WebUı.Services.MovieService.MoviesService;
using Netflix.WebUı.Settings;
using ILanguageService = Netflix.WebUı.Services.LanguageServices.LanguagesServices.ILanguageService;
using ISubtitleService = Netflix.WebUı.Services.LanguageServices.SubtitlesServices.ISubtitleService;

namespace Netflix.WebUı.Extensions.HttpClient
{
    public static class HttpClientExtensions
    {
        public static IServiceCollection AddCustomHttpClients(this IServiceCollection services, ServiceApiSettings values)
        {
            services.AddHttpContextAccessor();
            //Comment mikroservis
            services.AddHttpClient<ICommentServices, CommentServices>(opt =>
             {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Comment.Path}");
             });
            //Content mikroservis
            services.AddHttpClient<IEpisodeService, EpisodeService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Content.Path}");
            });
            services.AddHttpClient<ISeasonService, SeasonService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Content.Path}");
            });
            services.AddHttpClient<ISeriesService, SeriesService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Content.Path}");
            });
            //Genre mikroservis
            services.AddHttpClient<IGenreService, GenreService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Genre.Path}");
            });
            services.AddHttpClient<IGenreMappingService, GenreMappingService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Genre.Path}");
            });
            //Language mikroservis
            services.AddHttpClient<ILanguageService, LanguageService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Language.Path}");
            });
            services.AddHttpClient<ISubtitleService, SubtitleService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Language.Path}");
            });
            //Movie mikroservis
            services.AddHttpClient<IMovieService, MovieService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values.OcelotUrl}/{values.Genre.Path}");
            });

            return services;
        }
    }
}
