using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Request
{
    public class UsuarioRequest
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
