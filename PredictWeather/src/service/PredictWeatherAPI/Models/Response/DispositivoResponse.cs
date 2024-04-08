using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Response
{
    public class DispositivoResponse
    {
        public int DispositivoId { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string ComandosDisponiveis { get; set; }
    }
}
