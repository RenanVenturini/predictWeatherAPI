using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        Task AdicionarUsuarioAsync(Usuario usuario);
        Task<Usuario> ObterUsuarioAsync(string username, string senha);
    }
}