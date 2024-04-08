using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Interfaces
{
    public interface IMedidorChuvaRepository
    {
        Task AdicionarMedicaoChuvaAsync(TbMedicaoChuva medicaoChuva);
        Task<IEnumerable<TbMedicaoChuva>> ListarMedicaoChuvaAsync(int dispositivoId);
        Task<TbMedicaoChuva> ObterUltimaMedicaoChuvaAsync(int dispositivoId);
    }
}