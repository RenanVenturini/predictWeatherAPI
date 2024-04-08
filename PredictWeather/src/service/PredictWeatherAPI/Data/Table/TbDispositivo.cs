using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Data.Table
{
    public class TbDispositivo
    {
        [Key]
        public int DispositivoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Fabricante { get; set; }

        public string ComandosDisponiveis { get; set; }

    }
}
