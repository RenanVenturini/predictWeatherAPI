using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IUsuarioService
    {
        Task AdicionarUsuarioAsync(UsuarioRequest usuarioRequest);
        Task<Token> AutenticarAsync(Login login);
        Token GerarTokenAsync(TbUsuario usuario);
    }
}