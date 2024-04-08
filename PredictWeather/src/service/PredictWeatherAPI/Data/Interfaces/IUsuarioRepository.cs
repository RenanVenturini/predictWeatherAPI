using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        Task AdicionarUsuarioAsync(TbUsuario usuario);
        Task<TbUsuario> ObterUsuarioAsync(string username, string senha);
    }
}