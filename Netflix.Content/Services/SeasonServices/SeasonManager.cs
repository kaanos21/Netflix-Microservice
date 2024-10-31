using Microsoft.EntityFrameworkCore;
using Netflix.Content.Context;
using Netflix.Content.Dtos.SeasonDto;
using Netflix.Content.Entities;

namespace Netflix.Content.Services.SeasonServices
{
    public class SeasonManager : ISeasonManager
    {
        private readonly NetflixContentContext _context;

        public SeasonManager(NetflixContentContext context)
        {
            _context = context;
        }

        public async Task CreateSeasonAsync(CreateSeasonDto seasonDto)
        {
            var season = new Season
            {
                SeriesId = seasonDto.SeriesId,
                SeasonNumber = seasonDto.SeasonNumber,
                SeasonName=seasonDto.SeasonName,
                EpisodeCount = seasonDto.EpisodeCount
            };

            _context.Seasons.Add(season);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSeasonAsync(int id)
        {
            var season = await _context.Seasons.FindAsync(id);
            _context.Seasons.Remove(season);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultSeasonDto>> GetAllSeasonAsync()
        {
            var seasonList = await _context.Seasons.ToListAsync();

            var resultList = seasonList.Select(s => new ResultSeasonDto
            {
                SeasonId = s.SeasonId,
                SeriesId = s.SeriesId,
                SeasonName = s.SeasonName,
                SeasonNumber = s.SeasonNumber,
                EpisodeCount = s.EpisodeCount,
            }).ToList();

            return resultList;
        }
        // Dizi Id ye göre sezon listelerini isme göre getirir
        public async Task<List<SeasonWithSeriesNameDto>> GetListSeasonWithSeriesNameBySeriesId(int seriesId)
        {
            var seasons = await _context.Seasons
        .Where(season => season.SeriesId == seriesId)
        .Include(season => season.Series) // Series ismini almak için ilişkiyi dahil ediyoruz
        .ToListAsync();

            // DTO dönüşümü
            var seasonDtos = seasons.Select(season => new SeasonWithSeriesNameDto
            {
                SeriesId = season.SeriesId,
                SeasonId = season.SeasonId,
                SeasonName= season.SeasonName,
                SeasonNumber = season.SeasonNumber,
                EpisodeCount = season.EpisodeCount,
                SeriesName = season.Series.Title // Dizi adı ekleniyor
            }).ToList();

            return seasonDtos;
        }

        public async Task<GetByIdSeasonDto> GetSeasonByIdAsync(int id)
        {
            var value = await _context.Seasons.FindAsync(id);
            var result = new GetByIdSeasonDto
            {
                SeasonId = value.SeasonId,
                SeriesId = value.SeriesId,
                SeasonName = value.SeasonName,
                SeasonNumber = value.SeasonNumber,
                EpisodeCount = value.EpisodeCount
            };
            return result;
        }

        public async Task UpdateSeasonAsync(UpdateSeasonDto seasonDto)
        {
            var season = await _context.Seasons.FindAsync(seasonDto.SeasonId);

            if (season == null)
            {
                throw new KeyNotFoundException($"Seri bulunamadı: {seasonDto.SeasonId}");
            }
            season.SeasonName = seasonDto.SeasonName;
            season.SeriesId = seasonDto.SeriesId;
            season.SeasonNumber = seasonDto.SeasonNumber;
            season.EpisodeCount = seasonDto.EpisodeCount;

            await _context.SaveChangesAsync();
        }
    }
}
