using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task AdicionarUsuarioAsync(UsuarioRequest usuarioRequest);
        Task<Token> AutenticarAsync(LoginRequest login);
        Token GerarTokenAsync(Usuario usuario);
    }
}