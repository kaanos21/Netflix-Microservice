using FluentValidation;
using Microsoft.Identity.Client;
using Netflix.Content.Entities;

namespace Netflix.Content.FluentValidation.SeasonValidation
{
    public class SeasonValidator : AbstractValidator<Season>
    {
        public SeasonValidator() 
        {
            RuleFor(x => x.SeriesId).NotEmpty().WithMessage("Dizi numarası boş geçilemez");
            RuleFor(x => x.EpisodeCount).NotEmpty().WithMessage("Toplam bölüm boş geçilemez");
        }
    }
}
