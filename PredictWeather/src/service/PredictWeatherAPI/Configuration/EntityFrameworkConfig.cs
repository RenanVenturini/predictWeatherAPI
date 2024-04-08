using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PredictWeatherAPI.Data;

namespace PredictWeatherAPI.Configuration
{
    public static class EntityFrameworkConfig
    {
        public static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PredictWeatherContext>(options
                => options.UseSqlServer(configuration
                .GetConnectionString("PredictWeatherConnection")));
        }
    }
}
