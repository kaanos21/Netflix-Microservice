using FluentValidation;
using Netflix.Content.Entities;

namespace Netflix.Content.FluentValidation.SeriesValidation
{
    public class SeriesValidator : AbstractValidator<Series>
    {
        public SeriesValidator() 
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Dizi açıklaması boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Dizi başlığı boş geçilemez");
        }
    }
}
