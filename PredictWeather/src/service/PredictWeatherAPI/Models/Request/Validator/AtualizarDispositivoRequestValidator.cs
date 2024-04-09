using FluentValidation;

namespace PredictWeatherAPI.Models.Request.Validator
{
    public class AtualizarDispositivoRequestValidator : AbstractValidator<AtualizarDispositivoRequest>
    {
        public AtualizarDispositivoRequestValidator()
        {
            RuleFor(x => x.DispositivoId).NotEmpty().NotNull().GreaterThan(0).WithMessage("O campo 'DispositivoId' deve ser maior que zero.");
            RuleFor(x => x.Nome).NotEmpty().NotNull().WithMessage("O campo 'Nome' é obrigatório.");
            RuleFor(x => x.Fabricante).NotEmpty().NotNull().WithMessage("O campo 'Fabricante' é obrigatório.");
        }
    }
}
