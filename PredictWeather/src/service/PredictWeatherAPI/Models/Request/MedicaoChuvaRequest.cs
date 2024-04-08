using PredictWeatherAPI.Data.Table;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Request
{
    public class MedicaoChuvaRequest
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int DispositivoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal VolumetriaChuva { get; set; }
    }
}
