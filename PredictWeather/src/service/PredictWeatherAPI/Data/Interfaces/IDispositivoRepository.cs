using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IDispositivoRepository
    {
        Task CriarDispositivoAsync(Dispositivo dispositivo);
        Task AtualizarDispositivoAsync(Dispositivo dispositivo);
        Task<Dispositivo> ObterDispositivoAsync(int id);
        Task DeletarDispositivoAsync(Dispositivo dispositivo);
        Task<IEnumerable<Dispositivo>> ListarDispositivoAsync();
    }
}