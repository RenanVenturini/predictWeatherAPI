using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Request
{
    public class AtualizarDispositivoRequest
    {
        public string Nome { get; set; }

        public string Fabricante { get; set; }

        public string ComandosDisponiveis { get; set; }
    }
}
