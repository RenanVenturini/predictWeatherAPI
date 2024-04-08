using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;

namespace PredictWeatherAPI.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PredictWeatherContext _context;

        public UsuarioRepository(PredictWeatherContext context)
        {
            _context = context;
        }

        public async Task AdicionarUsuarioAsync(TbUsuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }
        public async Task<TbUsuario> ObterUsuarioAsync(string username, string senha)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Nome == username && u.Senha == senha);
            return usuario;
        }
    }
}
