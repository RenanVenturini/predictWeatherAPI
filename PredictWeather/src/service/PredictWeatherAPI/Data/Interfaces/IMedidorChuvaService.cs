using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IMedidorChuvaService
    {
        Task AdicionarMedicaoChuvaAsync(MedicaoChuvaRequest medicaoChuvaRequest);
        Task<IEnumerable<MedicaoChuvaResponse>> ListarMedicaoChuvaAsync(int dispositivoId);
        Task<MedicaoChuvaResponse> ObterUltimaMedicaoChuvaAsync(int dispositivoId);
    }
}