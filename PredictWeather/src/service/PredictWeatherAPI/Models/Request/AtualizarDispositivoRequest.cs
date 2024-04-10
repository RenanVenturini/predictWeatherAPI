using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Request
{
    public class AtualizarDispositivoRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Comando { get; set; }
    }
}
