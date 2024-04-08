using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IDispositivoService
    {
        Task CriarDispositivoAsync(DispositivoRequest dispositivoRrequest);
        Task AtualizarDispositivoAsync(AtualizarDispositivoRequest dispositivoRrequest);
        Task<DispositivoResponse> ObterDispositivoAsync(int id);
        Task DeletarDispositivoAsync(int id);
        Task<IEnumerable<DispositivoResponse>> ListarDispositivoAsync();
    }
}
