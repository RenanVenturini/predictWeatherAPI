using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Data.Table
{
    public class Login
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }
    }
}
