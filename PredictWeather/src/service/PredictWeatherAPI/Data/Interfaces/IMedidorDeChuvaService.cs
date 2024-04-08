using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IMedidorDeChuvaService
    {
        Task<MedicaoChuvaResponse> ObterMedicaoChuvaAsync(int dispositivoId);
    }
}