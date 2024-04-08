using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Repository
{
    public class MedidorDeChuvaRepository : IMedidorDeChuvaRepository
    {
        private readonly PredictWeatherContext _context;

        public MedidorDeChuvaRepository(PredictWeatherContext context)
        {
            _context = context;
        }

        public async Task<TbMedicaoChuva> ObterUltimaMedicaoChuvaAsync(int dispositivoId)
        {
            return await _context.MedicaoChuvas
                .Where(m => m.DispositivoId == dispositivoId)
                .OrderByDescending(m => m.DataHora)
                .FirstOrDefaultAsync();
        }
    }
}
