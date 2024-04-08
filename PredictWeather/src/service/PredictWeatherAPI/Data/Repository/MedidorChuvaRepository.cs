using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Repository
{
    public class MedidorChuvaRepository : IMedidorChuvaRepository
    {
        private readonly PredictWeatherContext _context;

        public MedidorChuvaRepository(PredictWeatherContext context)
        {
            _context = context;
        }

        public async Task AdicionarMedicaoChuvaAsync(TbMedicaoChuva medicaoChuva)
        {
            await _context.MedicaoChuvas.AddAsync(medicaoChuva);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TbMedicaoChuva>> ListarMedicaoChuvaAsync(int dispositivoId)
            => await _context.MedicaoChuvas.Include(x => x.Dispositivo)
            .Where(d => d.DispositivoId == dispositivoId)
            .OrderByDescending(m => m.DataHora)
            .ToListAsync();

        public async Task<TbMedicaoChuva> ObterUltimaMedicaoChuvaAsync(int dispositivoId)
        {
            return await _context.MedicaoChuvas.Include(x => x.Dispositivo)
                .Where(m => m.DispositivoId == dispositivoId)
                .OrderByDescending(m => m.DataHora)
                .FirstOrDefaultAsync();
        }
    }
}
