using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Repository
{
    public class DispositivoRepository : IDispositivoRepository
    {
        private readonly PredictWeatherContext _context;

        public DispositivoRepository(PredictWeatherContext context)
        {
            _context = context;
        }

        public async Task CriarDispositivoAsync(TbDispositivo dispositivo)
        {
            await _context.Dispositivos.AddAsync(dispositivo);
            await _context.SaveChangesAsync();
        }
        public async Task AtualizarDispositivoAsync(TbDispositivo dispositivo)
        {
            _context.Dispositivos.Update(dispositivo);
            await _context.SaveChangesAsync();
        }
        public async Task<TbDispositivo> ObterDispositivoAsync(int id)
            => await _context.Dispositivos.FirstOrDefaultAsync(d => d.DispositivoId == id);

        public async Task<IEnumerable<TbDispositivo>> ListarDispositivoAsync()
            => await _context.Dispositivos.ToListAsync();

        public async Task DeletarDispositivoAsync(TbDispositivo dispositivo)
        {
            _context.Remove(dispositivo);
            await _context.SaveChangesAsync();
        }
       
    }
}
