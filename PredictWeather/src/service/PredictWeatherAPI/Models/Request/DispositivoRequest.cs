using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Request
{
    public class DispositivoRequest
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ComandosDisponiveis { get; set; }
    }
}
