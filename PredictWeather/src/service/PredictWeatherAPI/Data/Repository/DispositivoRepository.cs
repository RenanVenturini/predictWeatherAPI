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

        public async Task CriarDispositivoAsync(Dispositivo dispositivo)
        {
            await _context.Dispositivos.AddAsync(dispositivo);
            await _context.SaveChangesAsync();
        }
        public async Task AtualizarDispositivoAsync(Dispositivo dispositivo)
        {
            _context.Dispositivos.Update(dispositivo);
            await _context.SaveChangesAsync();
        }
        public async Task<Dispositivo> ObterDispositivoAsync(int id)
            => await _context.Dispositivos.FirstOrDefaultAsync(d => d.Id == id);

        public async Task<IEnumerable<Dispositivo>> ListarDispositivoAsync()
            => await _context.Dispositivos
            .Where(x => x.Comando == "get_rainfall_intensity")
            .Where(x => x.Fabricante == "PredictWeather")
            .ToListAsync();

        public async Task DeletarDispositivoAsync(Dispositivo dispositivo)
        {
            _context.Remove(dispositivo);
            await _context.SaveChangesAsync();
        }
       
    }
}
