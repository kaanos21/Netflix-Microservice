using Netflix.Language.Context;
using Netflix.Language.Dtos.LanguageDtos;
using Netflix.Language.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Language.Services.LanguageService
{
    public class LanguageService : ILanguageService
    {
        private readonly NetflixLanguagesContext _context;

        public LanguageService(NetflixLanguagesContext context)
        {
            _context = context;
        }


        public async Task CreateLanguageAsync(CreateLanguageDto languageDto)
        {
            var language = new Languages
            {
                LanguageName = languageDto.LanguageName
            };

            _context.Languages.Add(language);
            await _context.SaveChangesAsync();
        }


        public async Task<List<ResultLanguageDto>> GetAllLanguageAsync()
        {
            var languageList = await _context.Languages.ToListAsync();

            var resultList = languageList.Select(l => new ResultLanguageDto
            {
                LanguagesId = l.LanguagesId,
                LanguageName = l.LanguageName
            }).ToList();

            return resultList;
        }

        public async Task<GetByIdLanguageDto> GetLanguageByIdAsync(int id)
        {
            var value = await _context.Languages.FindAsync(id);
            if (value == null)
            {
                throw new KeyNotFoundException($"Language bulunamadı: {id}");
            }

            return new GetByIdLanguageDto
            {
                LanguagesId = value.LanguagesId,
                LanguageName = value.LanguageName
            };
        }


        public async Task UpdateLanguageAsync(UpdateLanguageDto languageDto)
        {
            var language = await _context.Languages.FindAsync(languageDto.LanguagesId);
            if (language == null)
            {
                throw new KeyNotFoundException($"Language bulunamadı: {languageDto.LanguagesId}");
            }

            language.LanguageName = languageDto.LanguageName;

            await _context.SaveChangesAsync();
        }


        public async Task DeleteLanguageAsync(int id)
        {
            var language = await _context.Languages.FindAsync(id);
            if (language == null)
            {
                throw new KeyNotFoundException($"Language bulunamadı: {id}");
            }
            _context.Languages.Remove(language);
            await _context.SaveChangesAsync();
        }
    }
}
