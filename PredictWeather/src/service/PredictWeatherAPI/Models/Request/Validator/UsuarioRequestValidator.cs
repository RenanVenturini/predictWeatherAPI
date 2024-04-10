using FluentValidation;

namespace PredictWeatherAPI.Models.Request.Validator
{
    public class UsuarioRequestValidator : AbstractValidator<UsuarioRequest>
    {
        public UsuarioRequestValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().WithMessage("O campo 'Nome' é obrigatório.");
            RuleFor(x => x.Senha).NotEmpty().NotNull().WithMessage("O campo 'Senha' é obrigatório.");
        }
    }
}
