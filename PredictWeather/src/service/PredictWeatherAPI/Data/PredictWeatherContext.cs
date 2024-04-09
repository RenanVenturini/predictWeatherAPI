using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data.Table;
using System.Reflection;

namespace PredictWeatherAPI.Data
{
    public class PredictWeatherContext : DbContext
    {
        public PredictWeatherContext(DbContextOptions<PredictWeatherContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Dispositivo> Dispositivos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("TbUsuario");

                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Dispositivo>(entity =>
            {
                entity.ToTable("TbDispositivo");

                entity.HasKey(x => x.DispositivoId);
            });
        }
    }
}
