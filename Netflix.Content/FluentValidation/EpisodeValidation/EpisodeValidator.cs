using FluentValidation;
using Netflix.Content.Entities;

namespace Netflix.Content.FluentValidation.EpisodeValidation
{
    public class EpisodeValidator:AbstractValidator<Episode>
    {
        public EpisodeValidator()
        {
            RuleFor(x => x.EpisodeNumber).NotEmpty().WithMessage("Bölüm numarası boş geçilemez");
            RuleFor(x => x.EpisodeNumber).GreaterThan(0).WithMessage("Bölüm numarası - li değer olamaz");
            RuleFor(x => x.Title).Length(2, 50).WithMessage("Bölüm başlığı 2 ile 50 harf arası olması gerekmektedir");
            RuleFor(x => x.StreamFileUrl).NotEmpty().WithMessage("Dosya Url i boş olamaz");
        }
    }
}
