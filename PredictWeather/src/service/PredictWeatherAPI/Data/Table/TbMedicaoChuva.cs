using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Data.Table
{
    public class TbMedicaoChuva
    {
        [Key]
        public int MedicaoId { get; set; }

        [Required]
        public int DispositivoId { get; set; }

        [ForeignKey("DispositivoId")]
        public TbDispositivo Dispositivo { get; set; }

        public DateTime DataHora { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal VolumetriaChuva { get; set; }
    }
}
