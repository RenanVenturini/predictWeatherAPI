using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IDispositivoRepository
    {
        Task CriarDispositivoAsync(TbDispositivo dispositivo);
        Task AtualizarDispositivoAsync(TbDispositivo dispositivo);
        Task<TbDispositivo> ObterDispositivoAsync(int id);
        Task DeletarDispositivoAsync(TbDispositivo dispositivo);
        Task<IEnumerable<TbDispositivo>> ListarDispositivoAsync();
    }
}