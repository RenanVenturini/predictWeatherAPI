using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Repository;
using PredictWeatherAPI.Services;

namespace PredictWeatherAPI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IDispositivoRepository, DispositivoRepository>();
            services.AddScoped<IDispositivoService, DispositivoService>();
            services.AddScoped<IMedidorChuvaRepository, MedidorChuvaRepository>();
            services.AddScoped<IMedidorChuvaService, MedidorChuvaService>();
        }
    }
}
