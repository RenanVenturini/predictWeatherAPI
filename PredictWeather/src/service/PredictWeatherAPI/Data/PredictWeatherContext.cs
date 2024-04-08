using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data.Table;
using System.Reflection;

namespace PredictWeatherAPI.Data
{
    public class PredictWeatherContext : DbContext
    {
        public PredictWeatherContext(DbContextOptions<PredictWeatherContext> options) : base(options) { }

        public DbSet<TbUsuario> Usuarios { get; set; }
        public DbSet<TbDispositivo> Dispositivos { get; set; }
        public DbSet<TbMedicaoChuva> MedicaoChuvas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<TbUsuario>()
                .ToTable("TbUsuario");

            modelBuilder.Entity<TbDispositivo>()
                .ToTable("TbDispositivo");

            modelBuilder.Entity<TbMedicaoChuva>()
                .ToTable("TbMedicaoChuva");
        }
    }
}
