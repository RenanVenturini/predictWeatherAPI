using FluentValidation;

namespace PredictWeatherAPI.Models.Request.Validator
{
    public class DispositivoRequestValidator : AbstractValidator<DispositivoRequest>
    {
        public DispositivoRequestValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().WithMessage("O campo 'Nome' é obrigatório.");
            RuleFor(x => x.Fabricante).NotEmpty().NotNull().WithMessage("O campo 'Fabricante' é obrigatório.");
            RuleFor(x => x.Comando).NotEmpty().NotNull().WithMessage("O campo 'Comando' é obrigatório.");
            RuleFor(x => x.EnderecoIP).NotEmpty().NotNull().WithMessage("O campo 'Endereço IP' é obrigatório.");
            RuleFor(x => x.Porta).NotEmpty().NotNull().WithMessage("O campo 'Porta' é obrigatório.")
                                 .GreaterThan(0).WithMessage("O campo 'Porta' deve ser maior que zero.");
        }
    }
}
