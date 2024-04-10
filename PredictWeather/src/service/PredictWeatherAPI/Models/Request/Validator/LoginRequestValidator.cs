using FluentValidation;

namespace PredictWeatherAPI.Models.Request.Validator
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Usuario).NotEmpty().NotNull().WithMessage("O campo 'Usuário' é obrigatório.");
            RuleFor(x => x.Senha).NotEmpty().NotNull().WithMessage("O campo 'Senha' é obrigatório.");
        }
    }
}
