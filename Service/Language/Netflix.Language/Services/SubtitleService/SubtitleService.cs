using Netflix.Language.Context;
using Netflix.Language.Dtos.SubtitleDtos;
using Netflix.Language.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Subtitle.Services.SubtitleService
{
    public class SubtitleService : ISubtitleService
    {
        private readonly NetflixLanguagesContext _context;

        public SubtitleService(NetflixLanguagesContext context)
        {
            _context = context;
        }


        public async Task CreateSubtitleAsync(CreateSubtitleDto subtitleDto)
        {
            var subtitle = new Subtitles
            {
                ContentId = subtitleDto.ContentId,
                LanguageId = subtitleDto.LanguageId,
                SubtitleFileUrl = subtitleDto.SubtitleFileUrl
            };

            _context.Subtitles.Add(subtitle);
            await _context.SaveChangesAsync();
        }

        
        public async Task<List<ResultSubtitleDto>> GetAllSubtitleAsync()
        {
            var subtitleList = await _context.Subtitles.ToListAsync();

            var resultList = subtitleList.Select(s => new ResultSubtitleDto
            {
                SubtitlesId = s.SubtitlesId,
                ContentId = s.ContentId,
                LanguageId = s.LanguageId,
                SubtitleFileUrl = s.SubtitleFileUrl
            }).ToList();

            return resultList;
        }

        
        public async Task<GetByIdSubtitleDto> GetSubtitleByIdAsync(int id)
        {
            var subtitle = await _context.Subtitles.FindAsync(id);
            if (subtitle == null)
            {
                throw new KeyNotFoundException($"Subtitle bulunamadı: {id}");
            }

            return new GetByIdSubtitleDto
            {
                SubtitlesId = subtitle.SubtitlesId,
                ContentId = subtitle.ContentId,
                LanguageId = subtitle.LanguageId,
                SubtitleFileUrl = subtitle.SubtitleFileUrl
            };
        }

        
        public async Task UpdateSubtitleAsync(UpdateSubtitleDto subtitleDto)
        {
            var subtitle = await _context.Subtitles.FindAsync(subtitleDto.SubtitlesId);
            if (subtitle == null)
            {
                throw new KeyNotFoundException($"Subtitle bulunamadı: {subtitleDto.SubtitlesId}");
            }

            subtitle.ContentId = subtitleDto.ContentId;
            subtitle.LanguageId = subtitleDto.LanguageId;
            subtitle.SubtitleFileUrl = subtitleDto.SubtitleFileUrl;

            await _context.SaveChangesAsync();
        }

        
        public async Task DeleteSubtitleAsync(int id)
        {
            var subtitle = await _context.Subtitles.FindAsync(id);
            if (subtitle == null)
            {
                throw new KeyNotFoundException($"Subtitle bulunamadı: {id}");
            }
            _context.Subtitles.Remove(subtitle);
            await _context.SaveChangesAsync();
        }

        public async Task<List<GetSubtitlesWithLanguageByContentIdDto>> GetSubtitlesWithLanguageByContentId(int contentId)
        {
            var responseMessage = await _context.Subtitles.Where(x => x.ContentId == contentId).Include(x=>x.Language).ToListAsync();

            var result = responseMessage.Select(x => new GetSubtitlesWithLanguageByContentIdDto
            {
                SubtitlesId = x.SubtitlesId,
                ContentId = x.ContentId,
                LanguageId = x.LanguageId,
                SubtitleFileUrl = x.SubtitleFileUrl,
                LanguageName = x.Language.LanguageName
            }).ToList();

            return result;
        }
    }
}
