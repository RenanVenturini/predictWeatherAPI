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

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.ToTable("TbUsuario");

                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<TbDispositivo>(entity =>
            {
                entity.ToTable("TbDispositivo");

                entity.HasKey(x => x.DispositivoId);
            });

            modelBuilder.Entity<TbMedicaoChuva>(entity =>
            {
                entity.ToTable("TbMedicaoChuva");

                entity.HasKey(x => x.MedicaoId);

                entity.Property(x => x.DataHora).HasColumnName("data_hora");

                entity.Property(x => x.VolumetriaChuva).HasColumnName("volumetria_chuva");

                entity.HasOne(x => x.Dispositivo)
                .WithMany(x => x.MedidorChuva)
                .HasForeignKey(x => x.DispositivoId);
            });
        }
    }
}
