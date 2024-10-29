using Microsoft.EntityFrameworkCore;
using Netflix.Content.Context;
using Netflix.Content.Dtos.EpisodeDto;
using Netflix.Content.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.Content.Services.EpisodeServices
{
    public class EpisodeManager : IEpisodeManager
    {
        private readonly NetflixContentContext _context;

        public EpisodeManager(NetflixContentContext context)
        {
            _context = context;
        }

        public async Task CreateEpisodeAsync(CreateEpisodeDto episodeDto)
        {
            var episode = new Episode
            {
                EpisodeNumber = episodeDto.EpisodeNumber,
                Duration = episodeDto.Duration,
                StreamFileUrl = episodeDto.StreamFileUrl,
                Title = episodeDto.Title,
                ReleaseDate = episodeDto.ReleaseDate,
                SeasonId = episodeDto.SeasonId,
            };

            _context.Episodes.Add(episode);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEpisodeAsync(int id)
        {
            var episode = await _context.Episodes.FindAsync(id);
            if (episode == null)
            {
                throw new KeyNotFoundException($"Bölüm bulunamadı: {id}");
            }
            _context.Episodes.Remove(episode);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultEpisodeDto>> GetAllEpisodeAsync()
        {
            var episodeList = await _context.Episodes.ToListAsync();

            var resultList = episodeList.Select(s => new ResultEpisodeDto
            {
                EpisodeId = s.EpisodeId,
                Title = s.Title,
                ReleaseDate = s.ReleaseDate,
                EpisodeNumber = s.EpisodeNumber,
                Duration = s.Duration,
                StreamFileUrl = s.StreamFileUrl,
                SeasonId = s.SeasonId,
            }).ToList();

            return resultList;
        }

        public async Task<GetByIdEpisodeDto> GetEpisodeByIdAsync(int id)
        {
            var value = await _context.Episodes.FindAsync(id);
            if (value == null)
            {
                throw new KeyNotFoundException($"Bölüm bulunamadı: {id}");
            }

            var result = new GetByIdEpisodeDto
            {
                EpisodeId = value.EpisodeId,
                Title = value.Title,
                ReleaseDate = value.ReleaseDate,
                EpisodeNumber = value.EpisodeNumber,
                Duration = value.Duration,
                StreamFileUrl = value.StreamFileUrl,
                SeasonId = value.SeasonId,
            };
            return result;
        }

        public async Task UpdateEpisodeAsync(UpdateEpisodeDto episodeDto)
        {
            var episode = await _context.Episodes.FindAsync(episodeDto.EpisodeId);
            if (episode == null)
            {
                throw new KeyNotFoundException($"Bölüm bulunamadı: {episodeDto.EpisodeId}");
            }

            episode.Title = episodeDto.Title;
            episode.ReleaseDate = episodeDto.ReleaseDate;
            episode.EpisodeNumber = episodeDto.EpisodeNumber;
            episode.Duration = episodeDto.Duration;
            episode.StreamFileUrl = episodeDto.StreamFileUrl;
            episode.SeasonId = episodeDto.SeasonId;

            await _context.SaveChangesAsync();
        }
    }
}
