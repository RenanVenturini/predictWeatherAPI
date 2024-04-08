using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IMedidorDeChuvaRepository
    {
        Task<TbMedicaoChuva> ObterUltimaMedicaoChuvaAsync(int dispositivoId);
    }
}